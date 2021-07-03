using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class BookController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly IBooksService _booksService;
        private readonly ICategoryService _categoryService;
        private readonly IPublishersService _publishersService;
        private readonly IAuthorTranslatorService _authorTranslatorService;

        public BookController(MyDbContext myDbContext, IBooksService booksService, 
                                ICategoryService categoryService,
                                IPublishersService publishersService,
                                IAuthorTranslatorService authorTranslatorService)
        {
            _myDbContext = myDbContext;
            _booksService = booksService;
            _categoryService = categoryService;
            _publishersService = publishersService;
            _authorTranslatorService = authorTranslatorService;
        }

        [HttpGet]
        public IActionResult Index(string search, string filtertype, string filter, int page=1)
        {
            BookViewModel mdl = new BookViewModel();
            IQueryable<Book> res;
            //Search
            if (search != "")
            {
                res = _booksService.WhereName(search, _myDbContext.Books);
            }
            else
            {
                //Không có search thì lấy tất cả sách, bao gồm đã tạm xóa
                res = _booksService.Filter("All", "", _myDbContext.Books);
            }
            if (filter == "0") filter = "";
            //Filter
            res = _booksService.Filter(filtertype, filter, res);
            mdl.Books = res.ToList();
            mdl = PaginationInfo(mdl, page);
            mdl.Books = Paging(mdl.Books, page);
            mdl.search = search;
            mdl.filtertype = filtertype;
            mdl.filter = filter;
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }

        public IActionResult GetFilter(string filterType, string filter)
        {
            if (filterType != "Default" && filterType != "Deleted")
            {
                ViewBag.filter = filter;
                return PartialView("_Filter", SelectFilter(filterType));
            }
            return null;
        }

        //Hiển thị filter
        public IEnumerable<Object> SelectFilter(string filterType)
        {
            switch (filterType)
            {
                case "Author":
                    return _authorTranslatorService.GetAuthorTranslatorWithoutBooks();
                case "Category":
                    return _categoryService.GetCategoriesWithoutBooks();
                default:
                    return _publishersService.GetPublishersWithoutBooks();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            BookEditModel mdl = new BookEditModel();
            //Điền đầy các select
            mdl.Categories = _categoryService.GetCategoriesWithoutBooks();
            mdl.Publishers = _publishersService.GetPublishersWithoutBooks();
            mdl.Authors = _authorTranslatorService.GetAuthorsNotDeleted();
            mdl.Translators = _authorTranslatorService.GetTranslatorsNotDeleted();
            //Nhận thông báo 
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }

        [HttpPost]
        public IActionResult Create(BookEditModel book, IFormFile PrimaryImage, List<IFormFile> Images)
        {
            if (ModelState.IsValid && PrimaryImage != null)
            {
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _booksService.Create(book, PrimaryImage, Images);
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                if (mdl.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Create");
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            BookEditModel mdl = new BookEditModel();
            Book book = _booksService.GetBookBySlugOrId(id, "id");
            if(book == null)
            {
                //Gửi thông báo lỗi nếu sách không tồn tại
                TempData.Put("MessagesView", new MessagesViewModel(false, "Sách yêu cầu không tồn tại"));
                return RedirectToAction("Index");
            }

            mdl = _booksService.ToBookEditModel(book);
            //Điền đầy các select
            mdl.Categories = _categoryService.GetCategoriesWithoutBooks();
            mdl.Publishers = _publishersService.GetPublishersWithoutBooks();
            mdl.Authors = _authorTranslatorService.GetAuthorsNotDeleted();
            mdl.Translators = _authorTranslatorService.GetTranslatorsNotDeleted();
            //Nhận thông báo lỗi
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }

        [HttpPost]
        public IActionResult Edit (BookEditModel bookEdit, IFormFile NewPrimaryImage, List<IFormFile> Images)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _booksService.Edit(bookEdit, NewPrimaryImage, Images);
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                return RedirectToAction("Edit");
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Edit");
        }

        [HttpGet]
        public JsonResult Restore (string id)
        {
            return Json(_booksService.Restore(id));
        }

        [HttpGet]
        public JsonResult SoftDelete (string id)
        {
            return Json(_booksService.SoftDelete(id));
        }

        [HttpGet]
        public JsonResult Delete (string id)
        {
            return Json(_booksService.Delete(id));
        }

        public string CheckSlug(string source, string id)
        {
            return _booksService.CreateSlug(source, id);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Book> Paging(IEnumerable<Book> books, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            books = books.Skip(skipN).Take(PAGE_SIZE);
            return books;
        }

        public BookViewModel PaginationInfo(BookViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.Books.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}