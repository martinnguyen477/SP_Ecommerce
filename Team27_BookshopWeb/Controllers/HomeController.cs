using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;
using Team27_BookshopWeb.Extensions;

namespace Team27_BookshopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _myDbContext;
        private readonly ICategoryService _categoryService;
        private readonly IBooksService _booksService;

        public HomeController(MyDbContext myDbContext, ILogger<HomeController> logger, ICategoryService categoryService, IBooksService booksService)
        {
            _myDbContext = myDbContext;
            _logger = logger;
            _categoryService = categoryService;
            _booksService = booksService;
        }


        public IActionResult Index()
        {
            IndexViewModel mdl = new IndexViewModel();
            mdl.categories = _categoryService.GetAvailableCategories(0).Shuffle();

            //Truy vấn sách 12 sách bán chạy nhất trong 365 ngày từ hiện tại
            mdl.bestSellerBooks = _booksService.GetBestSellerBooks(365, 12);

            //Truy vấn 12 sách mới xuất bản
            mdl.newlyPublishedBooks = _booksService.GetNewlyPublishedBooks(12);

            //Truy vấn 12 sách có lượt xem nhiều nhất trong 7 ngày
            mdl.topViewBooks = _booksService.GetTopViewBooks(7, 12);

            return View(mdl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
