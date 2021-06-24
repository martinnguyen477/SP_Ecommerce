using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class AuthorTranslatorService : IAuthorTranslatorService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public AuthorTranslatorService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            this._booksService = booksService;
        }

        //Filter
        public IQueryable<AuthorTranslator> Filter(string type, IQueryable<AuthorTranslator> authorTranslators)
        {
            IQueryable<AuthorTranslator> res = authorTranslators;
            switch(type)
            {
                case "All":
                    res = GetAllAuthorTranslator();
                    break;

                    //Lọc các tác giả
                case "Author":
                    res = GetOnlyAuthorOrTrans(true, res);
                    break;

                    //Lọc các dịch giả
                case "Translator":
                    res = GetOnlyAuthorOrTrans(false, res);
                    break;

                    //Lọc các tác giả/dịch giả tạm xóa
                case "Deleted":
                    res = res.Where(a => a.DeletedAt != null).OrderBy(a => a.Id).AsQueryable();
                    break;

                default:
                    res = res.Where(a => a.DeletedAt == null).OrderBy(a => a.Id).AsQueryable();
                    break;
            }

            if (type != "Deleted" && type != "All")
            {
                //Chỉ lấy tác giả/dịch giả chưa tạm xóa
                res = res.Where(a => a.DeletedAt == null).AsQueryable();
            }

            return res;
        }

        //Truy vấn theo tên
        public IQueryable<AuthorTranslator> WhereName(string name, IQueryable<AuthorTranslator> authorTranslators)
        {
            IQueryable<AuthorTranslator> authorTranslatorsResult = authorTranslators.Where(a => EF.Functions.Like(a.Name, "%" + name + "%")).AsQueryable();
            return authorTranslatorsResult;
        }

        //Khôi phục tác giả/dịch giả đã tạm xóa
        public MessagesViewModel Restore(string Id)
        {
            //Kiểm tra Id rỗng
            if (string.IsNullOrEmpty(Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            //Lấy tác giả/dịch giả chưa tạm xóa theo id
            AuthorTranslator authorTranslator = this.WhereId(Id, this.GetAllAuthorTranslator()).FirstOrDefault();
            //Cập nhật DeletedAt của tác giả/dịch giả
            try
            {
                authorTranslator.UpdatedAt = DateTime.Now;
                authorTranslator.DeletedAt = null;

                //Cập nhật và lưu vào db
                myDbContext.Update(authorTranslator);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Khôi phục thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Khôi phục thất bại");
            }
        }

        //Xóa vĩnh viễn tác giả khỏi db ( + xóa các dữ liệu con)
        public MessagesViewModel Delete(string Id)
        {
            //Kiểm tra Id rỗng
            if (string.IsNullOrEmpty(Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            //Lấy tác giả/dịch giả chưa tạm xóa theo id
            AuthorTranslator authorTranslator = this.WhereId(Id, GetAllAuthorTranslator()).FirstOrDefault();
            //Xóa sách của dịch giả
            bool deletedTranslatorBooks = DeleteTranslatorBooks(authorTranslator.Id);
            //Xóa sách dịch giả thất bại
            if (!deletedTranslatorBooks)
            {
                return new MessagesViewModel(false, "Lỗi khi xóa sách của dịch giả");
            }
            //Xóa sách dịch giả thành công => Xóa tác giả/dịch giả và sách tác giả
            try
            {
                //Xóa tác giả/dịch giả => sách của tác giả sẽ tự động xóa
                myDbContext.Remove(authorTranslator);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Xóa tác giả/dịch giả thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Xảy ra lỗi khi xóa tác giả/dịch giả. Xóa thất bại");
            }
        }

        //Xóa sách của dịch giả
        public bool DeleteTranslatorBooks(string translatorId)
        {
            //Kiểm tra Id rỗng
            if (string.IsNullOrEmpty(translatorId))
            {
                return false;
            }
            //Tìm kiếm các sách của dịch giả
            var translatorBooks = myDbContext.Books.Where(b => b.TranslatorId == translatorId);
            //Có sách => xóa
            if (translatorBooks.Count() > 0)
            {
                try
                {
                    //Xóa các sách của dịch giả
                    myDbContext.RemoveRange(translatorBooks);
                    myDbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        //Tạm xóa tác giả/ dịch giả
        public MessagesViewModel SoftDelete (string Id)
        {
            //Kiểm tra Id rỗng
            if (string.IsNullOrEmpty(Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            //Lấy tác giả/dịch giả chưa tạm xóa theo id
            AuthorTranslator authorTranslator = this.WhereId(Id, this.GetNotDeletedAuthorTranslators()).FirstOrDefault();
            //Cập nhật DeletedAt của tác giả/dịch giả
            try
            {
                authorTranslator.UpdatedAt = DateTime.Now;
                authorTranslator.DeletedAt = DateTime.Now;
                
                //Thêm và lưu vào db
                myDbContext.Update(authorTranslator);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Xóa thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Xóa thất bại");
            }
        }

        //Cập nhật tác giả/ dịch giả
        public MessagesViewModel UpdateAuthorTranslator(AuthorTranslatorEditModel authorTranslatorEditModel)
        {
            //Kiểm tra Id rỗng
            if (string.IsNullOrEmpty(authorTranslatorEditModel.Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            //Lấy tác giả/dịch giả chưa tạm xóa theo id
            AuthorTranslator authorTranslator = this.WhereId(authorTranslatorEditModel.Id, this.GetNotDeletedAuthorTranslators()).FirstOrDefault();
            //Cập nhật tác giả/dịch giả
            try
            {
                if (authorTranslatorEditModel.Author == 0 && authorTranslatorEditModel.Translator == 0)
                {
                    return new MessagesViewModel(false, "Yêu cầu phải là tác giả hoặc dịch giả", authorTranslator);
                }
                //Chuyển tên thành dạng tiêu đề
                authorTranslator = EditModelToAuthorTranslator(authorTranslatorEditModel, authorTranslator);
                //Thêm và lưu vào db
                myDbContext.Update(authorTranslator);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Cập nhật thành công", authorTranslator);
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Cập nhật thất bại", authorTranslator);
            }
        }

        //Thêm tác giả/dịch giả
        public MessagesViewModel AddAuthorTranslator(AuthorTranslatorEditModel authorTranslatorEditModel)
        {
            AuthorTranslator authorTranslator = new AuthorTranslator();
            
            //Thêm mới tác giả/dịch giả
            try
            {
                if (authorTranslatorEditModel.Author == 0 && authorTranslatorEditModel.Translator == 0)
                {
                    return new MessagesViewModel(false, "Yêu cầu phải là tác giả hoặc dịch giả");
                }
                authorTranslator.Id = this.CreateAuTransId();
                authorTranslator = EditModelToAuthorTranslator(authorTranslatorEditModel, authorTranslator);
                authorTranslator.CreatedAt = DateTime.Now;
                //Thêm và lưu vào db
                myDbContext.Add(authorTranslator);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Thêm thành công", authorTranslator);
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thêm thất bại", authorTranslator);
            }
        }

        //Gán giá trị từ edit model vào authortranslator
        private static AuthorTranslator EditModelToAuthorTranslator(AuthorTranslatorEditModel authorTranslatorEditModel, AuthorTranslator authorTranslator)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            //Chuyển tên thành dạng tiêu đề
            authorTranslator.Name = tI.ToTitleCase(tI.ToLower(authorTranslatorEditModel.Name));
            authorTranslator.Slug = authorTranslatorEditModel.Slug;
            authorTranslator.UpdatedAt = DateTime.Now;
            authorTranslator.Author = authorTranslatorEditModel.Author;
            authorTranslator.Translator = authorTranslatorEditModel.Translator;
            return authorTranslator;
        }

        //Tạo Id mới
        public string CreateAuTransId()
        {
            //Lấy tất cả các tác giả/dịch giả trong db, bao gồm đã tạm xóa và sắp xếp giảm dần theo Id
            var allAuTrans = this.GetAllAuthorTranslator().OrderByDescending(b => b.Id).ToList();
            var lastId = "";
            //Nếu có tác giả/dịch giả thì lấy ra id cuối cùng
            if (allAuTrans.Count > 0)
            {
                lastId = allAuTrans.FirstOrDefault().Id;
            }
            //Tạo Id mới theo từng bảng
            return _booksService.CreateNewId("A", allAuTrans.Count(), lastId);
        }

        //Lấy tất cả tác giả/dịch giả, bao gồm các tác giả/dịch giả đã tạm xóa, không lấy các đối tượng liên quan
        private IQueryable<AuthorTranslator> GetAllAuthorTranslator()
        {
            return myDbContext.AuthorTranslators.OrderBy(b => b.Id).AsQueryable();
        }

        //Tạo và kiểm tra slug
        public string CreateSlug(string source, string id)
        {
            //Tạo slug
            string slug = _booksService.GenerateNewSlug(source);
            IQueryable<AuthorTranslator> allAuTrans = myDbContext.AuthorTranslators;
            //Không đếm slug từ id hiện tại (khi edit sách)
            if (!string.IsNullOrEmpty(id))
            {
                allAuTrans = allAuTrans.Where(a => a.Id != id).AsQueryable();
            }
            //Đếm slug có tồn tại trong db
            var countSlug = this.WhereSlug(slug, allAuTrans).Count();
            //Tồn tại slug trong db
            if (countSlug > 0)
            {
                int checkSlug = countSlug;
                string tmp;
                //Kiểm tra và tạo slug mới
                do
                {
                    tmp = slug + "-" + checkSlug;
                    checkSlug = this.WhereSlug(tmp, allAuTrans).Count();
                    countSlug++;
                }
                while (checkSlug > 0);
                slug = tmp;
            }
            return slug;
        }

        //Truy vấn theo slug
        public IQueryable<AuthorTranslator> WhereSlug(string slug, IQueryable<AuthorTranslator> authorTranslators)
        {
            return authorTranslators.Where(b => b.Slug == slug).AsQueryable();
        }

        //Truy vấn theo id
        public IQueryable<AuthorTranslator> WhereId(string id, IQueryable<AuthorTranslator> authorTranslators)
        {
            return authorTranslators.Where(b => b.Id == id).AsQueryable();
        }

        //Tìm tác giả / dịch giả theo slug/id
        public AuthorTranslator GetAuTrans(string type, bool isAuthor, string slugOrId)
        {
            IQueryable<AuthorTranslator> autrans = this.GetNotDeletedAuthorTranslators();
            //Kiểm tra tìm tác giả/dịch giả từ slug hay id
            if (type == "id")
            {
                autrans = this.WhereId(slugOrId, autrans);
            }
            else
            {
                autrans = this.WhereSlug(slugOrId, autrans);
            }
            autrans = GetOnlyAuthorOrTrans(isAuthor, autrans);
            //Load các sách
            GetAvailableBooks(autrans.ToList());
            return autrans.FirstOrDefault();
        }

        //Tìm tác giả chưa xóa
        public IEnumerable<AuthorTranslator> GetAuthorsNotDeleted()
        {
            var notDeleted = this.GetNotDeletedAuthorTranslators();
            return GetOnlyAuthorOrTrans(true, notDeleted);
        }

        //Tìm dịch giả chưa xóa
        public IEnumerable<AuthorTranslator> GetTranslatorsNotDeleted()
        {
            var notDeleted = this.GetNotDeletedAuthorTranslators();
            return GetOnlyAuthorOrTrans(false, notDeleted);
        }

        //Tìm theo tác giả hoặc dịch giả
        private static IQueryable<AuthorTranslator> GetOnlyAuthorOrTrans(bool isAuthor, IQueryable<AuthorTranslator> autrans)
        {
            if (isAuthor)
            {
                autrans = autrans.Where(a => a.Author == 1);
            }
            else
            {
                autrans = autrans.Where(a => a.Translator == 1);
            }

            return autrans;
        }

        //Lấy những tác giả/dịch giả chưa tạm xóa
        public IQueryable<AuthorTranslator> GetNotDeletedAuthorTranslators()
        {
            return myDbContext.AuthorTranslators
                        //Chỉ lấy các tác giả/dịch giả chưa xóa
                        .Where(p => p.DeletedAt == null)
                        //Sắp xếp tăng dần theo Id
                        .OrderBy(p => p.Id);
        }

        //Chỉ lấy ra các tác giả/ dịch giả hiện có , không lấy sách
        public IEnumerable<AuthorTranslator> GetAuthorTranslatorWithoutBooks()
        {
            //Truy vấn các các tác giả/ dịch giả chưa bị tạm xóa
            return this.GetNotDeletedAuthorTranslators().ToList();
        }

        //Lấy ra các tác giả/ dịch giả hiện có cùng với sách (chưa bị tạm xóa)
        public IEnumerable<AuthorTranslator> GetAllAvailableAuthorTranslators()
        {
            IEnumerable<AuthorTranslator> autrans = this.GetAuthorTranslatorWithoutBooks();
            //Load các sách chưa bị tạm xóa của từng Publisher
            GetAvailableBooks(autrans);
            return autrans;
        }

        //Load các sách chưa bị tạm xóa của từng tác giả/dịch giả
        private void GetAvailableBooks(IEnumerable<AuthorTranslator> autrans)
        {
            foreach (var person in autrans)
            {
                //Load sách tác giả
                myDbContext.Entry(person).Collection(c => c.AuthorBooks)
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
                
                //Load sách dịch giả
                myDbContext.Entry(person).Collection(c => c.TranslatorBooks)
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
    }
}
