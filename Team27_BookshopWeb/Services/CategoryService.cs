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
    public class CategoryService : ICategoryService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public CategoryService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
        }

        //Truy vấn theo slug
        public IQueryable<Category> WhereSlug(string slug, IQueryable<Category> categories)
        {
            return categories.Where(c => c.Slug == slug).AsQueryable();
        }

        public string CreateSlug(string source, string id)
        {
            //Tạo slug
            string slug = _booksService.GenerateNewSlug(source);
            IQueryable<Category> allCategories = myDbContext.Categories;
            //Không đếm slug từ id hiện tại (khi edit category)
            if (!string.IsNullOrEmpty(id))
            {
                allCategories = allCategories.Where(c => c.Id != id).AsQueryable();
            }
            //Đếm slug có tồn tại trong db
            var countSlug = this.WhereSlug(slug, allCategories).Count();
            //Tồn tại slug trong db
            if (countSlug > 0)
            {
                int checkSlug = countSlug;
                string tmp;
                //Kiểm tra và tạo slug mới
                do
                {
                    tmp = slug + "-" + checkSlug;
                    checkSlug = this.WhereSlug(tmp, allCategories).Count();
                    countSlug++;
                }
                while (checkSlug > 0);
                slug = tmp;
            }
            return slug;
        }

        //Lấy sách theo loại
        public Category GetCategory(string type, string slugOrId)
        {
            IQueryable<Category> category = this.GetNotDeleteCategories();
            //Kiểm tra lấy loại từ slug hay id
            if (type == "id")
            {
                category = category.Where(c => c.Id == slugOrId);
            }
            else
            {
                category = category.Where(c => c.Slug == slugOrId);
            }
            //Load các sách
            GetAvailableBooks(category.ToList());
            return category.FirstOrDefault();
        }

        //Lấy các loại sách chưa bị xóa, không có các đối tượng liên quan
        public IEnumerable<Category> GetCategoriesWithoutBooks()
        {
            return this.GetNotDeleteCategories().ToList();
        }

        //Lấy những loại sách chưa tạm xóa
        public IQueryable<Category> GetNotDeleteCategories()
        {
            return myDbContext.Categories
                        //Chỉ lấy sách chưa xóa
                        .Where(b => b.DeletedAt == null)
                        //Sắp xếp tăng dần theo Id
                        .OrderBy(c => c.Id)
                        ;
        }

        //Lấy những loại sách đã tạm xóa
        public IQueryable<Category> GetDeleteCategories()
        {
            return myDbContext.Categories
                        //Chỉ lấy sách chưa xóa
                        .Where(b => b.DeletedAt != null)
                        //Sắp xếp tăng dần theo Id
                        .OrderBy(c => c.Id);
        }

        //Lấy ra các loại sách hiện có cùng với sách của từng loại(chưa bị tạm xóa)
        public IEnumerable<Category> GetAvailableCategories(int amountOfCategories)
        {
            //Truy vấn các Category chưa bị tạm xóa
            IQueryable<Category> categories = this.GetNotDeleteCategories();
            //Lấy số lượng theo yêu cầu
            IEnumerable<Category> availableCategories = TakeAmountOfCategories(amountOfCategories, categories);
            //Load các sách chưa bị tạm xóa của từng Category
            GetAvailableBooks(availableCategories);
            return availableCategories;
        }

        //Lấy số lượng loại sách theo yêu cầu
        private IEnumerable<Category> TakeAmountOfCategories(int amountOfCategories, IQueryable<Category> categories)
        {
            IEnumerable<Category> res;

            //Nếu không yêu cầu số lượng sách thì lấy tất cả sách
            res = (amountOfCategories != 0) ? categories.Take(amountOfCategories).ToList() : res = categories.ToList();

            return res;
        }

        //Load các sách chưa bị tạm xóa của từng Category
        private void GetAvailableBooks(IEnumerable<Category> categories)
        {
            foreach (var category in categories)
            {
                //Load sách của từng category
                myDbContext.Entry(category)
                    .Collection(c => c.Books)
                    .Query()
                    //Chỉ lấy sách chưa bị tạm xóa
                    .Where(b => b.DeletedAt == null)
                    //Sắp xếp tăng dần theo Id
                    .OrderBy(b => b.Id)
                    //Load các đối tượng có liên quan
                    .Include(b => b.Author)
                    .Include(b => b.Category)
                    .Include(b => b.Translator)
                    .Include(b => b.Publisher)
                    .Include(b => b.BookImages)
                    .Include(b => b.BookViews)
                    .Load();
            }
        }

        public MessagesViewModel Create( CategoryEditModel categoryEditModel, IFormFile VerticalImage, IFormFile HorizontalImage)
        {
            var ktTrungId = myDbContext.Categories.Where(p => p.Id == categoryEditModel.Id).Count();
            if (ktTrungId > 0)
            {
                return new MessagesViewModel(false, "Trùng ID");
            }
            else
            {
                try
                {
                    Category category = new Category();
                    category = EditModelToCategory(categoryEditModel, category);
                    category.CreatedAt = DateTime.Now;

                    if (VerticalImage != null)
                    {
                        category.VerticalImage = "vc-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(VerticalImage.FileName);
                        var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "categories", category.VerticalImage);
                        using (var file = new FileStream(urlFull, FileMode.Create))
                        {
                            VerticalImage.CopyTo(file);
                        }
                    }

                    if (HorizontalImage != null)
                    {
                        category.HorizontalImage = "hz-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(VerticalImage.FileName);
                        var urlFull1 = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "categories", category.HorizontalImage);
                        using (var file1 = new FileStream(urlFull1, FileMode.Create))
                        {
                            HorizontalImage.CopyTo(file1);
                        }
                    }

                    myDbContext.Add(category);
                    myDbContext.SaveChanges();

                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Thất bại");
                }
                
                return new MessagesViewModel(true, "Thành công");

            }
        }

        public Category EditModelToCategory(CategoryEditModel categoryEditModel, Category category)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            category.Id = categoryEditModel.Id;
            category.Name = tI.ToTitleCase(tI.ToLower(categoryEditModel.Name));
            category.Slug = categoryEditModel.Slug;
            category.UpdatedAt = DateTime.Now;

            return category;
        }

        public CategoryEditModel CategoryToEditModel(Category category)
        {
            CategoryEditModel editModel = new CategoryEditModel();
            editModel.Id = category.Id;
            editModel.Name = category.DisplayName;
            editModel.Slug = category.Slug;
            editModel.CreatedAt = category.CreatedAt;
            editModel.VerticalImage = category.VerticalImage;
            editModel.HorizontalImage = category.HorizontalImage;
            return editModel;
        }

        public Category GetCategory(string id)
        {
            var category = WhereId(id, GetNotDeleteCategories()).FirstOrDefault();
            return category;
        }
        public IQueryable<Category> WhereId(string id, IQueryable<Category> categories)
        {
            return categories.Where(p => p.Id == id).AsQueryable();
        }

        public MessagesViewModel EditCategory(CategoryEditModel categoryEditModel, IFormFile VerticalImageUpLoad, IFormFile HorizontalImageUpLoad)
        {
            if (!string.IsNullOrEmpty(categoryEditModel.Id))
            {
                //ktra khách hàng đã có trong database chưa
                var checkCategory = WhereId(categoryEditModel.Id, GetNotDeleteCategories()).FirstOrDefault();
                if (checkCategory != null)
                {                  
                    try
                    {
                        checkCategory = EditModelToCategory(categoryEditModel, checkCategory);
                        if (VerticalImageUpLoad != null)
                        {
                            checkCategory.VerticalImage = "vc-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(VerticalImageUpLoad.FileName);
                            var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "categories", checkCategory.VerticalImage);
                            using (var file = new FileStream(urlFull, FileMode.Create))
                            {
                                VerticalImageUpLoad.CopyTo(file);
                            }
                        }
                        if (HorizontalImageUpLoad != null)
                        {
                            checkCategory.HorizontalImage = "hz-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(VerticalImageUpLoad.FileName);
                            var urlFull1 = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "categories", checkCategory.HorizontalImage);
                            using (var file1 = new FileStream(urlFull1, FileMode.Create))
                            {
                                HorizontalImageUpLoad.CopyTo(file1);
                            }
                        }

                        myDbContext.Update(checkCategory);
                        myDbContext.SaveChanges();
                    }
                    catch (Exception)
                    {
                        return new MessagesViewModel(false, "Thất bại");
                    }                   
                    return new MessagesViewModel(true, "Thành công");
                }
                else
                {
                    return new MessagesViewModel(false, "Không có loại sách trong database");
                }
            }
            else
            {
                return new MessagesViewModel(false, "Không có ID");
            }

        }

        public MessagesViewModel DeleteCategoryTmp(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "Id trống");
            }

            //ktra khách hàng đã có trong database chưa
            var checkCategory = WhereId(id, GetNotDeleteCategories()).FirstOrDefault();
            if (checkCategory != null)
            {
                try
                {
                    checkCategory.DeletedAt = DateTime.Now;
                    myDbContext.Update(checkCategory);
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
                return new MessagesViewModel(false, "Không có loại sách này trong database");

            }
        }

        public MessagesViewModel RestoreCategory(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "id trống");
            }

            //ktra khách hàng đã có trong database chưa
            var checkCategory = WhereId(id, GetDeleteCategories()).FirstOrDefault();
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
                return new MessagesViewModel(false, "Loại sách này chưa đc xóa tạm");

            }
        }

        public MessagesViewModel DeleteCategoryForever(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "id trống");
            }
            // ktra khách hàng đã có trong ds delete tạm chưa
            var checkCategory = WhereId(id, GetDeleteCategories()).FirstOrDefault();
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
                return new MessagesViewModel(false, "Loại sách này ko có trong danh sách tạm xóa");
            }
        }


        public IEnumerable<Category> FindCategoryName(string name)
        {
            IEnumerable<Category> list = FindCategory(name, GetNotDeleteCategories()).ToList();
            return list;
        }
        // tim theo danh sách loại sách đã tạm xóa
        public IEnumerable<Category> FindCategoryDeleteName(string name)
        {
            IEnumerable<Category> list = FindCategory(name, GetDeleteCategories()).ToList();
            return list;
        }

        public IQueryable<Category> FindCategory(string name, IQueryable<Category> categories)
        {
            return categories.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).AsQueryable();
        }
    }
}
