using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Team27_BookshopWeb.Controllers
{
    public class ShopController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly IBooksService _booksService;

        public ShopController(MyDbContext myDbContext, IBooksService booksService)
        {
            _myDbContext = myDbContext;
            _booksService = booksService;
        }

        // GET: /<controller>/
        
        public IActionResult Index(string sort, int page = 1)
        {
            ShopViewModel mdl = new ShopViewModel();
            mdl.Type = "cua-hang";
            mdl.Books = _booksService.GetAvailableBooks();
            mdl.Books = _booksService.Sort(mdl.Books, sort);
            mdl = PaginationInfo(mdl, page);
            mdl.Books = Paging(mdl.Books, page);
            mdl.DisplayBreadcrumb = "Tất cả sách";
            mdl.Description = "Tất cả sách";
            mdl.DisplayPath = "cua-hang";
            return View(mdl);
        }

        [HttpGet]
        public IActionResult Filter(string filterType, string slugOrId, string sort,
                                    [FromServices] ICategoryService categoryService,
                                    [FromServices] IPublishersService publishersService,
                                    [FromServices] IAuthorTranslatorService authorTranslatorService, int page = 1)
        {
            ShopViewModel mdl = new ShopViewModel();
            mdl.Type = filterType;
            mdl.sort = sort;
            //Hiển thị sách theo loại/nhà xuất bản/tác giả/ dịch giả
            switch (filterType)
            {
                case "loai-sach":
                    var category = categoryService.GetCategory("slug", slugOrId);
                    mdl.Books = category.Books;
                    //Phần mô tả kết quả tìm kiếm
                    mdl.Description = category.DisplayName;
                    //Phần breadcrum
                    mdl.DisplayBreadcrumb = category.DisplayName;
                    mdl.DisplayPath = category.Slug;
                    break;

                case "nha-xuat-ban":
                    var publisher = publishersService.GetPublisher("slug", slugOrId);
                    mdl.Books = publisher.Books;

                    //Phần mô tả kết quả tìm kiếm
                    mdl.Description = publisher.DisplayName;
                    //Phần breadcrum
                    mdl.DisplayBreadcrumb = publisher.DisplayName;
                    mdl.DisplayPath = publisher.Slug;
                    break;

                case "tac-gia":
                    var author = authorTranslatorService.GetAuTrans("slug", true, slugOrId);
                    mdl.Books = author.AuthorBooks;
                    mdl.Description = "Sách của tác giả " + author.DisplayName;
                    mdl.DisplayBreadcrumb = author.DisplayName;
                    mdl.DisplayPath = author.Slug;
                    break;

                default:
                    var translator = authorTranslatorService.GetAuTrans("slug", false, slugOrId);
                    mdl.Books = translator.TranslatorBooks;
                    mdl.Description = "Sách dịch bởi " + translator.DisplayName;
                    mdl.DisplayBreadcrumb = translator.DisplayName;
                    mdl.DisplayPath = translator.Slug;
                    break;
            }
            //Sắp xếp
            mdl.Books = _booksService.Sort(mdl.Books, sort);
            mdl = PaginationInfo(mdl, page);
            mdl.Books = Paging(mdl.Books, page);
            return View("Index", mdl);
        }

        [HttpGet]
        public IActionResult Search(string name, string sort, int page=1)
        {
            ShopViewModel mdl = new ShopViewModel();
            mdl.Type = "tim-kiem";
            //Chuỗi tìm kiếm
            mdl.search = name;
            mdl.Books = _booksService.SearchBooks(name);
            //Sort
            mdl.Books = _booksService.Sort(mdl.Books, sort);
            mdl = PaginationInfo(mdl, page);
            mdl.Books = Paging(mdl.Books, page);
            mdl.DisplayBreadcrumb = "Tìm kiếm";
            mdl.Description = "Kết quả tìm kiếm cho `" + name + '`';
            mdl.DisplayPath = "#";
            return View("Index", mdl);
        }

        const int PAGE_SIZE = 9;
        public IEnumerable<Book> Paging(IEnumerable<Book> books, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            books = books.Skip(skipN).Take(PAGE_SIZE);
            return books;
        }

        public ShopViewModel PaginationInfo(ShopViewModel mdl, int page)
        {
            mdl.Count = mdl.Books.Count();
            mdl.AllPages = (int)Math.Ceiling((double)mdl.Books.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}
