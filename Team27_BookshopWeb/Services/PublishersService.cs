using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class PublishersService : IPublishersService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public PublishersService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
        }

        //Truy vấn theo slug
        public IQueryable<Publisher> WhereSlug(string slug, IQueryable<Publisher> publishers)
        {
            return publishers.Where(c => c.Slug == slug).AsQueryable();
        }

        public string CreateSlug(string source, string id)
        {
            //Tạo slug
            string slug = _booksService.GenerateNewSlug(source);
            IQueryable<Publisher> allPublishers = myDbContext.Publishers;
            //Không đếm slug từ id hiện tại (khi edit publisher)
            if (!string.IsNullOrEmpty(id))
            {
                allPublishers = allPublishers.Where(c => c.Id != id).AsQueryable();
            }
            //Đếm slug có tồn tại trong db
            var countSlug = this.WhereSlug(slug, allPublishers).Count();
            //Tồn tại slug trong db
            if (countSlug > 0)
            {
                int checkSlug = countSlug;
                string tmp;
                //Kiểm tra và tạo slug mới
                do
                {
                    tmp = slug + "-" + checkSlug;
                    checkSlug = this.WhereSlug(tmp, allPublishers).Count();
                    countSlug++;
                }
                while (checkSlug > 0);
                slug = tmp;
            }
            return slug;
        }

        //Lấy sách theo nhà xuất bản
        public Publisher GetPublisher(string type, string slugOrId)
        {
            IQueryable<Publisher> publisher = this.GetNotDeletedPublishers();
            //Kiểm tra lấy nhà xuất bản từ slug hay id
            if (type == "id")
            {
                publisher = publisher.Where(c => c.Id == slugOrId);
            }
            else
            {
                publisher = publisher.Where(c => c.Slug == slugOrId);
            }
            //Load các sách
            GetAvailableBooks(publisher.ToList());
            return publisher.FirstOrDefault();
        }

        //Lấy những nhà xuất bản chưa tạm xóa
        public IQueryable<Publisher> GetNotDeletedPublishers()
        {
            return myDbContext.Publishers
                        //Chỉ lấy sách chưa xóa
                        .Where(p => p.DeletedAt == null)
                        //Sắp xếp tăng dần theo Id
                        .OrderBy(p => p.Id);
        }

        // lay nxb da xoa

        public IQueryable<Publisher> GetDeletePublishers()
        {
            return myDbContext.Publishers
                       //Chỉ lấy sách chưa xóa
                       .Where(p => p.DeletedAt != null)
                       //Sắp xếp tăng dần theo Id
                       .OrderBy(p => p.Id);

        }

        public IEnumerable<Publisher> GetPublishersWithoutBooks()
        {
            //Truy vấn các Publisher chưa bị tạm xóa
            return this.GetNotDeletedPublishers().ToList();
        }

        //Lấy ra các nhà xuất bản hiện có cùng với sách (chưa bị tạm xóa)
        public IEnumerable<Publisher> GetAllAvailablePublishers()
        {
            IEnumerable<Publisher> publishers = this.GetPublishersWithoutBooks();
            //Load các sách chưa bị tạm xóa của từng Publisher
            GetAvailableBooks(publishers);
            return publishers;
        }

        //Load các sách chưa bị tạm xóa của từng Publisher
        private void GetAvailableBooks(IEnumerable<Publisher> publishers)
        {
            foreach (var publisher in publishers)
            {
                //Load sách của từng publisher
                myDbContext.Entry(publisher)
                    .Collection(c => c.Books)
                    .Query()
                    //Chỉ lấy sách chưa bị tạm xóa
                    .Where(b => b.DeletedAt == null)
                    //Sắp xếp tăng dần theo Id
                    .OrderBy(b => b.Id)
                    //Load các đối tượng có liên quan
                    .Include(b => b.Author)
                    .Include(b => b.Translator)
                    .Include(b => b.Category)
                    .Include(b => b.Publisher)
                    .Include(b => b.BookImages)
                    .Include(b => b.BookViews)
                    .Load();
            }
        }

        public IEnumerable<Publisher> FindPublisherName(string name)
        {
            IEnumerable<Publisher> list = FindPublisher(name, GetNotDeletedPublishers()).ToList();
            return list;
        }
        // tim theo danh sách loại sách đã tạm xóa
        public IEnumerable<Publisher> FindPublisherDeleteName(string name)
        {
            IEnumerable<Publisher> list = FindPublisher(name, GetDeletePublishers()).ToList();
            return list;
        }

        public IQueryable<Publisher> FindPublisher(string name, IQueryable<Publisher> publishers)
        {
            return publishers.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).AsQueryable();
        }

        public MessagesViewModel Create(PublisherEditModel publisherEditModel, IFormFile Image)
        {
            var ktTrungId = myDbContext.Publishers.Where(p => p.Id == publisherEditModel.Id).Count();
            if (ktTrungId > 0)
            {
                return new MessagesViewModel(false, "ID này đã tồn tại");
            }
            else
            {
                
                try
                {
                    Publisher publisher = new Publisher();
                    publisher = EditModelToPublisher(publisherEditModel, publisher);
                    publisher.CreatedAt = DateTime.Now;
                    if (Image != null)
                    {
                        publisher.Image = "publisher-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(Image.FileName);
                        var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "publishers", publisher.Image);
                        using (var file = new FileStream(urlFull, FileMode.Create))
                        {
                            Image.CopyTo(file);
                        }
                    }
                    else
                    {
                        return new MessagesViewModel(false, "Chưa có hình ảnh");
                    }

                    myDbContext.Add(publisher);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Thêm mới thất bại");
                }
                return new MessagesViewModel(true, "Thành công");
            }

        }

        public Publisher EditModelToPublisher(PublisherEditModel publisherEditModel, Publisher publisher)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            publisher.Id = publisherEditModel.Id;
            publisher.Name = tI.ToTitleCase(tI.ToLower(publisherEditModel.Name));
            publisher.Slug = publisherEditModel.Slug;
            publisher.UpdatedAt = DateTime.Now;
            return publisher;
        }

        public PublisherEditModel PublisherToEditModel(Publisher publisher)
        {
            PublisherEditModel editModel = new PublisherEditModel();
            editModel.Id = publisher.Id;
            editModel.Name = publisher.DisplayName;
            editModel.Slug = publisher.Slug;
            editModel.CreatedAt = DateTime.Now;
            editModel.Image = publisher.Image;
            return editModel;
        }

        public Publisher GetPublisher(string id)
        {
            var publisher = WhereId(id, GetNotDeletedPublishers()).FirstOrDefault();
            return publisher;
        }
        public IQueryable<Publisher> WhereId(string id, IQueryable<Publisher> publishers)
        {
            return publishers.Where(p => p.Id == id).AsQueryable();
        }

        public MessagesViewModel EditPublisher(PublisherEditModel publisherEditModel, IFormFile ImageUpLoad)
        {
            if (!string.IsNullOrEmpty(publisherEditModel.Id))
            {
                //ktra khách hàng đã có trong database chưa
                var checkPublisher = WhereId(publisherEditModel.Id, GetNotDeletedPublishers()).FirstOrDefault();
                if (checkPublisher != null)
                {
                    try
                    {
                        checkPublisher = EditModelToPublisher(publisherEditModel, checkPublisher);
                        if (ImageUpLoad != null)
                        {
                            checkPublisher.Image = "publisher-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(ImageUpLoad.FileName);
                            var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "publishers", checkPublisher.Image);
                            using (var file = new FileStream(urlFull, FileMode.Create))
                            {
                                ImageUpLoad.CopyTo(file);
                            }
                        }

                        myDbContext.Update(checkPublisher);
                        myDbContext.SaveChanges();

                    }
                    catch (Exception)
                    {

                        return new MessagesViewModel(false, "Không thành công");
                    }

                    return new MessagesViewModel(true, "Thành công");
                }
                else
                {
                    return new MessagesViewModel(false, "Nhà xuất bản không tồn tại");
                }
            }
            else
            {
                return new MessagesViewModel(false, "Không có ID");
            }

        }

        public MessagesViewModel DeletePublisherTmp(string id)
        {

            //ktra khách hàng đã có trong database chưa
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "id trống");
            }
            var checkPublisher = WhereId(id, GetNotDeletedPublishers()).FirstOrDefault();
            if (checkPublisher != null)
            {
                try
                {
                    checkPublisher.DeletedAt = DateTime.Now;

                    myDbContext.Update(checkPublisher);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Không thể đưa vào danh sách");
                }

                return new MessagesViewModel(true, "Đã đưa vào danh sách xóa tạm");
            }
            else
            {
                return new MessagesViewModel(false, "chưa có nxb trong database");

            }
        }

        public MessagesViewModel RestorePublisher(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "id trống");
            }

            //ktra khách hàng đã có trong database chưa
            var checkCategory = WhereId(id, GetDeletePublishers()).FirstOrDefault();
            if (checkCategory != null)
            {
                try
                {
                    checkCategory.DeletedAt = null;

                    myDbContext.Update(checkCategory);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "không thể restore");
                }

                return new MessagesViewModel(true, "Đã restore");
            }
            else
            {
                return new MessagesViewModel(false, "chua có nxb trong database");

            }
        }

        public MessagesViewModel DeletePublisherForever(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "id trống");
            }
            // ktra khách hàng đã có trong ds delete tạm chưa
            var checkCategory = WhereId(id, GetDeletePublishers()).FirstOrDefault();
            if (checkCategory != null)
            {
                try
                {
                    myDbContext.Remove(checkCategory);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Xóa không thành công");
                }

                return new MessagesViewModel(true, "Xóa thành công");
            }
            else
            {
                return new MessagesViewModel(false, "nxb chưa đc tạm xóa");
            }
        }
    }

    //public CouponEditModel CouponToEditModel(Coupon cs)
    //{
    //    CustomerEditModel kh = new CustomerEditModel();

    //    try
    //    {
    //        kh.Id = cs.Id;
    //        kh.Name = cs.Name;
    //        kh.Phone = cs.Phone;
    //        kh.Gender = cs.Gender;
    //        kh.Email = cs.Email;
    //        kh.Address = cs.Address;
    //        kh.Username = cs.Username;
    //        kh.Password = cs.Password;

    //    }
    //    catch (Exception)
    //    {

    //        return null;
    //    }
    //    return kh;
    //}

    //public Coupon EditModelToCoupon(CouponEditModel cs, Coupon kh)
    //{
    //    try
    //    {
    //        kh.Name = cs.Name;
    //        kh.Phone = cs.Phone;
    //        kh.Gender = cs.Gender;
    //        kh.Email = cs.Email;
    //        kh.Address = cs.Address;
    //        kh.Username = cs.Username;
    //        kh.UpdatedAt = DateTime.Now;

    //        return kh;

    //    }
    //    catch (Exception)
    //    {

    //        return null;
    //    }

    //}
}
