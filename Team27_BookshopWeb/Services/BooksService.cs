using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Slugify;
using Team27_BookshopWeb.Areas.admin.Models;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Team27_BookshopWeb.Services
{
    public class BooksService : IBooksService
    {
        private readonly MyDbContext myDbContext;
        public BooksService(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        //Thêm comment
        public MessagesViewModel Comment(CommentEditModel commentEditModel)
        {
            int isBought = 0;
            if (commentEditModel.Vote == null || commentEditModel.Vote == 0)
            {
                return new MessagesViewModel(false, "Vui lòng đánh giá cho sách này");
            }

            //Kiểm tra khách hàng
            if (!string.IsNullOrEmpty(commentEditModel.CustomerId))
            {
                Customer customer = myDbContext.Customers.Include(c => c.Orders).Where(c => c.Id == commentEditModel.CustomerId
                                                        && c.DeletedAt == null).FirstOrDefault();
                if (customer == null)
                {
                    return new MessagesViewModel(false, "Khách hàng không tồn tại");
                }
                var ordersCheck = myDbContext.OrderItems.Include(o => o.Order)
                                                .ThenInclude(o => o.Customer)
                                                .Where(oi => oi.Order.CustomerId == commentEditModel.CustomerId)
                                                .FirstOrDefault();

                if (ordersCheck != null)
                {
                    isBought = 1;
                }
            }

            //Kiểm tra sách
            Book book = WhereId(commentEditModel.BookId, GetNotDeletedBooks()).FirstOrDefault();
            if (book == null)
            {
                return new MessagesViewModel(false, "Sách không tồn tại");
            }
            try
            {
                Comment comment = new Comment();
                comment.BookId = commentEditModel.BookId;
                if (!string.IsNullOrEmpty(commentEditModel.CustomerId))
                {
                    comment.CustomerId = commentEditModel.CustomerId;
                }
                comment.Name = commentEditModel.Name;
                comment.Email = commentEditModel.Email;
                comment.Vote = commentEditModel.Vote;
                comment.Content = commentEditModel.Content;
                comment.Bought = isBought;
                comment.CreatedAt = DateTime.Now;
                comment.UpdatedAt = DateTime.Now;

                myDbContext.Add(comment);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thất bại");
            }
        }

        //Sách bạn đọc thường mua
        public IEnumerable<Book> GetConsideredBooks()
        {
            IEnumerable<Book> consideredBooks = this.GetNotDeletedBooks()
                .Select(b => new 
                {
                    consideredBooks = b,
                    //Lấy số đơn hàng
                    numberOfOrders = b.OrderDetails.Count()
                })
                //Chỉ lấy những sách bán được (số lượng đơn hàng > 0)
                .Where(s => s.numberOfOrders > 0)
                //Sắp xếp theo thứ tự giảm dần của số lượng sách bán được
                .OrderByDescending(s => s.numberOfOrders)
                .AsQueryable()
                .Select(c => c.consideredBooks)
                .Include(b => b.Author)
                .Include(b => b.BookImages)
                .ToList();

            return consideredBooks;
        }

        //Delete
        public MessagesViewModel Delete(string id)
        {
            return RestoreOrDelete(id, "delete", "Xóa vĩnh viễn");
        }

        //Soft Delete
        public MessagesViewModel SoftDelete(string id)
        {
            return RestoreOrDelete(id, "softdelete", "Xóa");
        }

        //Restore
        public MessagesViewModel Restore(string id)
        {
            return RestoreOrDelete(id, "restore", "Khôi phục");
        }

        //Khôi phục hoặc Tạm xóa
        private MessagesViewModel RestoreOrDelete(string id, string action, string message)
        {
            //Kiểm tra Id
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            //Tìm sách theo Id
            Book book = WhereId(id, myDbContext.Books).FirstOrDefault();

            try
            {
                book.UpdatedAt = DateTime.Now;
                //Restore
                switch (action)
                {
                    case "restore":
                        book.DeletedAt = null;
                        myDbContext.Update(book);
                        break;

                    case "delete":
                        myDbContext.Remove(book);
                        break;

                    default:
                        //Soft Delete
                        book.DeletedAt = DateTime.Now;
                        myDbContext.Update(book);
                        break;
                }
                
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, message + " thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, message + " thất bại");
            }

        }

        //Cập nhật/Chỉnh sửa sách
        public MessagesViewModel Edit(BookEditModel editedbook, IFormFile NewPrimaryImage, List<IFormFile> NewOtherImages)
        {
            //Kiểm tra Id
            if (string.IsNullOrEmpty(editedbook.Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }

            //Lấy sách theo id
            Book book = this.WhereId(editedbook.Id, this.GetNotDeletedBooks()).FirstOrDefault();
            //Cập nhật sách
            try
            {
                //Cập nhật thông tin sách
                book = EditModelToBook(editedbook, book);
                //Thêm và lưu vào db
                myDbContext.Update(book);
                myDbContext.SaveChanges();

                //Cập nhật hình ảnh
                //folder path
                var imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "books");

                //Sửa ảnh đại diện
                if (NewPrimaryImage != null)
                {
                    try
                    {
                        //Lấy ảnh đại diện cũ
                        BookImage oldPrimaryImage = myDbContext.BookImages.Where(i => i.Primary == 1 && i.BookId == book.Id)
                                                        .FirstOrDefault();
                        //Xử lý ảnh đại diện mới
                        string newImageName = HandleUploadedImages(NewPrimaryImage, book, imageFolder);
                        //Cập nhật trong db
                        oldPrimaryImage.Image = newImageName;

                        myDbContext.Update(oldPrimaryImage);
                        myDbContext.SaveChanges();
                    }
                    catch (Exception)
                    {
                        return new MessagesViewModel(false, "Cập nhật ảnh đại diện thất bại");
                    }
                }

                //Cập nhật các ảnh khác
                //Xóa hình
                if (editedbook.RemmovedImages != null)
                {
                    try
                    {
                        if (editedbook.RemmovedImages.Count > 0)
                        {
                            foreach (var imageId in editedbook.RemmovedImages)
                            {
                                var removedImage = myDbContext.BookImages.Find(int.Parse(imageId));
                                if (removedImage != null) myDbContext.BookImages.Remove(removedImage);
                                myDbContext.SaveChanges();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return new MessagesViewModel(false, "Không thể xóa ảnh");
                    }
                }
                //Thêm hình mới
                if (NewOtherImages != null && NewOtherImages.Count > 0)
                {
                    try
                    {
                        foreach (var image in NewOtherImages)
                        {
                            StoreBookImage(image, book, imageFolder, 0);
                        }
                    }
                    catch (Exception)
                    {
                        return new MessagesViewModel(false, "Không thể lưu ảnh");
                    }
                    
                }

                return new MessagesViewModel(true, "Cập nhật sách thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Cập nhật sách thất bại");
            }
        }

        //Gán giá trị từ edit model vào book
        private Book EditModelToBook(BookEditModel editedbook, Book book)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            book.Name = tI.ToTitleCase(tI.ToLower(editedbook.Name));
            book.Slug = editedbook.Slug;
            book.Price = editedbook.Price;
            if (editedbook.PublicationMonth != null)
            {
                if (editedbook.PublicationMonth != 0) { 
                    book.PublicationMonth = editedbook.PublicationMonth;
                }
                else
                {
                    book.PublicationMonth = null;
                }
                
            }
            book.PublicationYear = editedbook.PublicationYear;
            book.Description = editedbook.Description;
            if (editedbook.Pages != null)
            {
                book.Pages = editedbook.Pages;
            }
            else
            {
                book.Pages = null;
            }
            book.CategoryId = editedbook.CategoryId;
            book.PublisherId = editedbook.PublisherId;
            book.AuthorId = editedbook.AuthorId;
            if (!string.IsNullOrEmpty(editedbook.TranslatorId))
            {
                book.TranslatorId = editedbook.TranslatorId;
            }
            else
            {
                book.TranslatorId = null;
            }
            book.UpdatedAt = DateTime.Now;
            return book;
        }

        //Gán giá trị của book vào bookedit
        public BookEditModel ToBookEditModel(Book book)
        {
            BookEditModel bookEdit = new BookEditModel();
            if (book != null)
            {
                if (string.IsNullOrEmpty(book.Id))
                {
                    return null;
                }
                bookEdit.Id = book.Id;
                bookEdit.Name = book.Name;
                bookEdit.Slug = book.Slug;
                bookEdit.Price = book.Price;
                if (book.PublicationMonth != null)
                {
                    bookEdit.PublicationMonth = book.PublicationMonth;
                }
                bookEdit.PublicationYear = book.PublicationYear;
                //Chuyển br thành Newline để xuống dòng
                bookEdit.Description = book.Description.Replace("<br>", Environment.NewLine);
                if (book.Pages != null)
                {
                    bookEdit.Pages = book.Pages;
                }
                bookEdit.CategoryId = book.CategoryId;
                bookEdit.PublisherId = book.PublisherId;
                bookEdit.AuthorId = book.AuthorId;
                if (book.TranslatorId != null)
                {
                    bookEdit.TranslatorId = book.TranslatorId;
                }
                bookEdit.CreatedAt = book.CreatedAt;
                bookEdit.PrimaryImage = book.PrimaryImage;
                bookEdit.OtherImages = book.BookImages.Where(bi => bi.Primary != 1).ToList();
                return bookEdit;
            }
            return null;
        }

        //Thêm mới
        public MessagesViewModel Create(BookEditModel book, IFormFile PrimaryImage, List<IFormFile> Images)
        {
            Book newBook = new Book();
            try
            {
                //Thêm thông tin sách
                newBook.Id = this.CreateNewBookId();
                newBook = EditModelToBook(book, newBook);
                newBook.CreatedAt = DateTime.Now;

                myDbContext.Add(newBook);
                myDbContext.SaveChanges();

                var imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "books");

                //Thêm ảnh đại diện
                try
                {
                    if(PrimaryImage != null)
                    {
                        StoreBookImage(PrimaryImage, newBook, imageFolder, 1);
                    }
                }
                catch (Exception)
                {
                    //Xóa sách nếu thêm hình thất bại
                    myDbContext.Remove(newBook);
                    return new MessagesViewModel(false, "Thêm ảnh đại diện thất bại");
                }

                //Thêm ảnh khác
                try
                {
                    if(Images != null)
                    {
                        foreach(var image in Images)
                        {
                            StoreBookImage(image, newBook, imageFolder, 0);
                        }
                    }
                }
                catch (Exception)
                {
                    //Xóa sách nếu thêm hình thất bại
                    myDbContext.Remove(newBook);
                    return new MessagesViewModel(false, "Thêm các ảnh khác thất bại");
                }

                return new MessagesViewModel(true, "Thêm sách thành công");

            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thêm sách thất bại");
            }
        }

        //Xử lý lưu hình ảnh vào bảng BookImage
        private void StoreBookImage(IFormFile PrimaryImage, Book newBook, string imageFolder, int primary)
        {
            string newImageName = HandleUploadedImages(PrimaryImage, newBook, imageFolder);

            //Thêm ảnh vào db
            BookImage bookPrimaryImage = new BookImage();
            bookPrimaryImage.BookId = newBook.Id;
            bookPrimaryImage.Image = newImageName;
            bookPrimaryImage.Primary = primary;
            bookPrimaryImage.CreatedAt = DateTime.Now;

            myDbContext.Add(bookPrimaryImage);
            myDbContext.SaveChanges();
        }

        //Xử lý việc thêm hình ảnh vào folder và tạo tên hình ảnh
        private static string HandleUploadedImages(IFormFile image, Book newBook, string imageFolder)
        {
            //Lấy FileName
            var fileName = Path.GetFileName(image.FileName);
            //Tạo tên mới cho hình ảnh
            string imageName = newBook.Id + "-" + DateTime.Now.ToString("yyyyMMddHHmmssFFF");
            //Lấy file extension
            string imageExtension = Path.GetExtension(fileName);
            //Kết hợp tên và extension tạo thành tên mới cho hình ảnh
            string newImageName = String.Concat(imageName, imageExtension);
            var fullPath = Path.Combine(imageFolder, newImageName);
            using (var file = new FileStream(fullPath, FileMode.Create))
            {
                image.CopyTo(file);
            }

            return newImageName;
        }

        //Filter
        public IQueryable<Book> Filter(string type, string filter, IQueryable<Book> books)
        {
            IQueryable<Book> res = books;
            
            switch (type)
            {
                case "All":
                    res = GetAllBooks();
                    break;

                //Lọc theo tác giả
                case "Author":
                    res = WhereAuthor(filter, res);
                    break;

                //Lọc theo loại sách
                case "Category":
                    res = WhereCategory(filter, res);
                    break;

                //Lọc theo loại sách
                case "Publisher":
                    res = WherePublisher(filter, res);
                    break;

                //Lọc các sách đã tạm xóa
                case "Deleted":
                    res = WhereDeleted(res);
                    break;

                //Lọc các sách chưa tạm xóa
                default:
                    res = res.Where(b => b.DeletedAt == null).OrderBy(a => a.Id).AsQueryable();
                    break;
            }

            if (type != "Deleted" && type != "All")
            {
                //Chỉ lấy sách chưa tạm xóa
                res = res.Where(b => b.DeletedAt == null).AsQueryable();
            }
            res = IncludeProperties(res);
            return res;
        }

        //Truy vấn tất cả các sách, bao gồm đã tạm xóa
        public IQueryable<Book> AllBooks()
        {
            return myDbContext.Books.OrderBy(b => b.Id).AsQueryable();
        }

        //Thêm tất cả đối tượng liên quan
        public IQueryable<Book> IncludeProperties(IQueryable<Book> books)
        {
            return books.Include(b => b.Author)
                        .Include(b => b.Translator)
                        .Include(b => b.Publisher)
                        .Include(b => b.Category)
                        .Include(b => b.BookImages)
                        .Include(b => b.BookViews).AsQueryable();
        }

        //Truy vấn sách đã xóa
        public IQueryable<Book> WhereDeleted(IQueryable<Book> books)
        {
            return books.Where(b => b.DeletedAt != null).OrderBy(b => b.Id).AsQueryable();
        }

        //Truy vấn theo mã nhà xuất bản
        public IQueryable<Book> WherePublisher(string publisherId, IQueryable<Book> books)
        {
            if (publisherId == "")
            {
                return books;
            }
            return books.Where(b => b.PublisherId == publisherId).OrderBy(b => b.Id).AsQueryable();
        }

        //Truy vấn theo mã tác giả
        public IQueryable<Book> WhereAuthor(string authorId, IQueryable<Book> books)
        {
            if (authorId == "")
            {
                return books;
            }
            return books.Where(b => b.AuthorId == authorId).OrderBy(b => b.Id).AsQueryable();
        }

        //Truy vấn theo mã loại sách
        public IQueryable<Book> WhereCategory(string categoryId, IQueryable<Book> books)
        {
            if (categoryId == "")
            {
                return books;
            }
            return books.Where(b => b.CategoryId == categoryId).OrderBy(b => b.Id).AsQueryable();
        }

        public string CreateSlug(string source, string id)
        {
            //Tạo slug
            string slug = GenerateNewSlug(source);
            IQueryable<Book> allBooks = myDbContext.Books;
            //Không đếm slug từ id hiện tại (khi edit sách)
            if(!string.IsNullOrEmpty(id))
            {
                allBooks = allBooks.Where(b => b.Id != id).AsQueryable();
            }
            
            //Đếm slug có tồn tại trong db
            var countSlug = this.WhereSlug(slug, allBooks).Count();
            //Tồn tại slug trong db
            if (countSlug > 0)
            {
                int checkSlug = countSlug;
                string tmp;
                //Kiểm tra và tạo slug mới
                do
                {
                    tmp = slug + "-" + countSlug;
                    checkSlug = this.WhereSlug(tmp, allBooks).Count();
                    countSlug++;
                }
                while (checkSlug > 0);
                slug = tmp;
            }
            return slug;
        }

        //Generate slug by name/title (source)
        public string GenerateNewSlug(string source)
        {
            //Tạo configuration object
            try
            {
                SlugHelperConfiguration config = new SlugHelperConfiguration();
                //Thay thế các dấu "." "_" thành "-"
                config.StringReplacements.Add(".", "-");
                config.StringReplacements.Add("_", "-");
                SlugHelper slugHelper = new SlugHelper(config);
                //Generate slug
                string slug = slugHelper.GenerateSlug(source);
            
            return slug;
            }
            catch (Exception)
            {
                return "";
            }
        }

        //Tạo Id mới
        public string CreateNewBookId()
        {
            //Lấy tất cả các sách hiện có, bao gồm các sách tạm xóa và sắp xếp giảm dần theo Id
            var allBooks = this.GetAllBooks().OrderByDescending(b => b.Id).ToList();
            var lastId = "";
            //Nếu có sách thì lấy ra id cuối cùng
            if (allBooks.Count > 0)
            {
                lastId = allBooks.FirstOrDefault().Id;
            }
            //Tạo Id mới theo từng bảng
            return this.CreateNewId("S", allBooks.Count(), lastId);
        }

        //Lấy tất cả sách, bao gồm các sách đã tạm xóa (chỉ lấy sách),không có các đối tượng liên quan
        private IQueryable<Book> GetAllBooks()
        {
            return myDbContext.Books.OrderBy(b => b.Id).AsQueryable();
        }

        //Tạo Id mới theo từng bảng
        public string CreateNewId(string prefix, int count, string lastId)
        {
            string newId = prefix;
            if (count > 0)  //Bảng đã có dữ liệu
            {
                //Số cũ
                int lastNumber = int.Parse(lastId.Substring(2));
                //Số mới
                var newNumber = lastNumber + 1;
                if (newNumber < 10)
                {
                    return newId + "00" + newNumber;
                }
                else if (newNumber > 10 && newNumber < 99)
                {
                    return newId + "0" + newNumber;
                }
                else
                {
                    return newId + newNumber;
                }
            }
            else    //Bảng chưa có dữ liệu
            {
                return newId + "001";
            }
        }

        //Cập nhật lượt xem cho sách
        public MessagesViewModel UpdateBookViews(string bookId, string sessionId, string customerId)
        {
            if (!string.IsNullOrEmpty(customerId))
            {
                //Kiểm tra khách hàng tồn tại trong db
                var customer = myDbContext.Customers.Where(c => c.Id == customerId).SingleOrDefault();
                if (customer == null)
                {
                    //Khách hàng không tồn tại
                    return new MessagesViewModel(false, "Khách hàng không tồn tại");
                }
            }
            //Sách không tồn tại
            if (string.IsNullOrEmpty(bookId)) {
                return new MessagesViewModel(false, "Sách không được trống");
            }

            //Kiểm tra sách tồn tại trong db
            var book = myDbContext.Books.Where(b => b.Id == bookId).SingleOrDefault();
            if (book == null)
            {
                return new MessagesViewModel(false, "Sách không tồn tại");
            }

            try
            {
                //Add lượt xem mới cho sách 
                BookView bookView = new BookView();
                bookView.BookId = bookId;
                bookView.SessionId = sessionId;
                bookView.CustomerId = customerId;
                bookView.CreatedAt = DateTime.Now;

                myDbContext.Add(bookView);
                myDbContext.SaveChanges();

                return new MessagesViewModel(true, "Cập nhật thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thất bại. Xảy ra lỗi trong quá trình cập nhật view.");
            }
        }

        //Tìm kiếm sách theo tên
        public IEnumerable<Book> SearchBooks(string name)
        {
            IQueryable<Book> books = this.GetNotDeletedBooks();
            //Tìm sách theo tên
            books = this.WhereName(name, books);
            //Load các đối tượng liên quan
            return books.Include(b => b.Author)
                        .Include(b => b.BookImages)
                        .Include(b => b.BookViews);
        }

        //Truy vấn theo tên
        public IQueryable<Book> WhereName(string name, IQueryable<Book> books)
        {
            return books.Where(b => EF.Functions.Like(b.Name, "%" + name + "%"))
                .OrderBy(b => b.Id)
                .AsQueryable();
        }

        //Sắp xếp (tên, giá, lượt xem)
        public IEnumerable<Book> Sort(IEnumerable<Book> books, string type)
        {
            IEnumerable<Book> res;
            switch(type)
            {
                //Sort tên A > Z
                case "nameasc":
                    res = books.OrderBy(b => b.Name);
                    break;

                //Sort tên Z > A
                case "namedesc":
                    res = books.OrderByDescending(b => b.Name);
                    break;

                //Sort giá tăng dần
                case "priceasc":
                    res = books.OrderBy(b => b.Price);
                    break;

                //Sort giá giảm dần
                case "pricedesc":
                    res = books.OrderByDescending(b => b.Price);
                    break;

                //Sort lượt xem trong 7 ngày: tăng dần
                case "viewasc":
                    res = this.TopView(7, "asc", true, books.AsQueryable()).Select(b =>b.Book).ToList();
                    break;

                //Sort lượt xem trong 7 ngày: giảm dần
                case "viewdesc":
                    res = this.TopView(7, "desc", true, books.AsQueryable()).Select(b => b.Book).ToList();
                    break;

                //Mặc định: sort theo Id
                default:
                    res = books.OrderBy(b => b.Id);
                    break;
            }
            return res.ToList();
        }

        //Truy vấn thông tin sách bán chạy nhất
        public IQueryable<BestSellerBooksViewModel> GetBestSeller(int days)
        {
            //Ngày của cách [days] tính từ hiện tại => Ví dụ: days=7, lấy ra ngày cách đây 7 ngày
            var passNDays = DateTime.Now.AddDays(-days);
            IQueryable<BestSellerBooksViewModel> bestseller = this.GetNotDeletedBooks()
                .Select(b => new BestSellerBooksViewModel
                {
                    bestSeller = b,
                    //Lấy số lượng sách đã bán được trong khoảng thời gian
                    numberOfBooks = b.OrderDetails.Where(od => od.CreatedAt >= passNDays).Sum(od => od.Quantity),
                    //Lấy tổng tiền sách đã bán được trong khoảng thời gian
                    //totalSell = b.OrderDetails.Where(o => o.CreatedAt >= passNDays).Select(o => (int)o.Total).Sum()
                })
                //Chỉ lấy những sách bán được (số lượng > 0)
                .Where(s => s.numberOfBooks > 0)
                //Sắp xếp theo thứ tự giảm dần của số lượng sách bán được
                .OrderByDescending(s => s.numberOfBooks).AsQueryable();

            return bestseller;
        }

        //Lấy sách liên quan
        public IEnumerable<Book> GetRelatedBooks([FromServices] ICategoryService _categoryService, Book book, int amountOfBooks)
        {
            string categoryId = book.CategoryId;
            //Gọi method từ CategoryService
            IQueryable<Book> relatedBooks = _categoryService.GetCategory("id", categoryId).Books.Where(b => b.Id != book.Id).AsQueryable();
            return TakeAmountOfBooks(amountOfBooks, relatedBooks);
        }

        //Chỉ lấy các sách bán chạy nhất
        public IEnumerable<Book> GetBestSellerBooks(int days, int amountOfBooks)
        {
            var queryBestSeller = this.GetBestSeller(days);
            //Chỉ lấy phần sách
            IQueryable<Book> books = queryBestSeller.Select(bs => bs.bestSeller)
                        //Load các đối tượng liên quan
                        .Include(bs => bs.Author)
                        .Include(bs => bs.BookImages).AsQueryable();
            //Lấy số lượng sách theo yêu cầu
            return TakeAmountOfBooks(amountOfBooks, books);
        }

        //Truy vấn sách mới xuất bản
        public IEnumerable<Book> GetNewlyPublishedBooks(int amountOfBooks)
        {
            IQueryable<Book> newBooks = this.GetNotDeletedBooks()
                //Sắp xếp giảm dần theo năm xuất bản
                .OrderByDescending(b => b.PublicationYear)
                //Sắp xếp giảm dần theo tháng xuất bản
                .ThenByDescending(b => b.PublicationMonth)
                //Load các đối tượng liên quan
                .Include(b => b.Author)
                .Include(b => b.BookImages).AsQueryable();

            //Lấy số lượng sách theo yêu cầu
            return TakeAmountOfBooks(amountOfBooks, newBooks);
        }

        //Truy vấn sách có lượt xem nhiều nhất trong số ngày yêu cầu
        public IEnumerable<Book> GetTopViewBooks(int days, int amountOfBooks)
        {
            //Lấy ra các sách chưa xóa và so sánh lượt xem giảm dần của chúng trong số ngày yêu cầu
            var books = TopView(days, "desc", false, this.GetNotDeletedBooks()).Select(b => b.Book);
            //Lấy các thông tin liên quan
            IQueryable<Book> topView = books
                                .Include(b => b.Author)
                                .Include(b => b.BookImages).AsQueryable();
            //Lấy số lượng sách theo yêu cầu
            return TakeAmountOfBooks(amountOfBooks, topView); ;
        }

        //Truy vấn, sắp xếp lượt xem
        public IQueryable<TopViewModel> TopView(int days, string sort, bool all, IQueryable<Book> books)
        {
            //Ngày của cách [days] tính từ hiện tại => Ví dụ: days=7, lấy ra ngày cách đây 7 ngày
            var passNDays = DateTime.Now.AddDays(-days);
            //Tính lượt view theo số ngày yêu cầu
            var res = books.Select(b => new TopViewModel
            {
                Book = b,
                Count = b.BookViews.Where(bv => bv.CreatedAt.Date >= passNDays.Date).Count()
            });
            //Kiểm tra có lấy những sách không có lượt xem
            if (!all)
            {
                //Lấy cả những sách không có lượt xem 
                res = res.Where(b => b.Count > 0).AsQueryable();
            }
            //Sắp xếp tăng dần hoặc giảm 
            res = (sort == "desc") ? res.OrderByDescending(b => b.Count) : res.OrderBy(b => b.Count);
            //Chỉ trả về sách
            return res.AsQueryable();
        }

        //Lấy các sách hiện có (chưa xóa) cùng với các đối tượng liên quan
        public IEnumerable<Book> GetAvailableBooks()
        {
            IEnumerable<Book> books = this.GetNotDeletedBooks()
                                        .Include(b => b.Author)
                                        .Include(b => b.Publisher)
                                        .Include(b => b.Category)
                                        .Include(b => b.BookImages)
                                        .Include(b => b.BookViews)
                                        .ToList();
            return books;
        }

        //Truy vấn theo slug
        public IQueryable<Book> WhereSlug(string slug, IQueryable<Book> books)
        {
            return books.Where(b => b.Slug == slug).AsQueryable();
        }
        
        //Truy vấn theo id
        public IQueryable<Book> WhereId(string id, IQueryable<Book> books)
        {
            return books.Where(b => b.Id == id).AsQueryable();
        }

        //Lấy thông tin của sách theo slug hoặc id
        public Book GetBookBySlugOrId(string slugOrId, string type)
        {
            IQueryable<Book> book = this.GetNotDeletedBooks();
            //Kiểm tra lấy sách từ slug hay id
            if (type == "id")
            {
                book = this.WhereId(slugOrId, book);
            }
            else
            {
                book = this.WhereSlug(slugOrId, book);
            }
            //Load các đối tượng liên quan
            return book.Include(b => b.Author)
                        .Include(b => b.Translator)
                        .Include(b => b.Publisher)
                        .Include(b => b.Category)
                        .Include(b => b.BookImages)
                        .Include(b => b.Comments)
                        .FirstOrDefault();
        }

        //Lấy những sách chưa tạm xóa
        public IQueryable<Book> GetNotDeletedBooks()
        {
            return myDbContext.Books
                        //Chỉ lấy sách chưa xóa
                        .Where(b => b.DeletedAt == null)
                        //Sắp xếp tăng dần theo Id
                        .OrderBy(b => b.Id);
        }

        //Lấy số lượng sách theo yêu cầu
        private IEnumerable<Book> TakeAmountOfBooks(int amountOfBooks, IQueryable<Book> books)
        {
            IEnumerable<Book> res;

            //Nếu không yêu cầu số lượng sách thì lấy tất cả sách
            res = (amountOfBooks != 0) ? books.Take(amountOfBooks).ToList() : res = books.ToList();

            return res;
        }
    }
}
