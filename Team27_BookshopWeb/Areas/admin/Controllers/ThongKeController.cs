using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class ThongKeController : Controller
    {

        private readonly MyDbContext _context;
        private readonly ITKDoanhThuService _doanhthuService;
        private readonly IBooksService _bookService;
        private readonly IThongKeService _thongKeService;

        public ThongKeController(MyDbContext context, ITKDoanhThuService doanhthuService, IThongKeService thongKeService, IBooksService booksService)
        {
            _context = context;
            _doanhthuService = doanhthuService;
            _thongKeService = thongKeService;
            _bookService = booksService;
        }


        public IActionResult DTTheoKhoangTG()
        {

            return View();
        }

        public IActionResult DoanhThuTG(int day)
        {
            TKDoanhThuViewModel dt = new TKDoanhThuViewModel();
            dt.day = day;
            switch (day)
            {
                case 180:
                    dt.title = "6 Tháng Trước";
                    break;
                case 30:
                    dt.title = "1 Tháng Trước";
                    break;
                default:
                    dt.title = "24H qua";
                    break;
            }
            dt.listDoanhThu = _doanhthuService.ListRevenue(day);
            return View("DTTheoKhoangTG", dt);
        }

        [Produces("application/json")]
        public async Task<IActionResult> RevenueChart(int day)
        {

            try
            {
                IEnumerable<DoanhThuViewModel> dt = _doanhthuService.ListRevenue(day).ToList();
                return Ok(dt);
            }
            catch
            {
                return BadRequest();
            }
        }

        public IActionResult SachViewNhieu(int day)
        {
            TKSachViewNhieuViewModel bookView = new TKSachViewNhieuViewModel();
            bookView.day = day;
            switch (day)
            {
                case 7:
                    bookView.tittle = "1 Tuần";
                    break;
                case 30:
                    bookView.tittle = "1 Tháng";
                    break;
                default:
                    bookView.tittle = "24H Qua";
                    break;
            }
            IQueryable<TopViewModel> topview = _thongKeService.TopViewInclude(day);
            bookView.listBookBestViewed = topview.ToList();

            return View(bookView);

        }

        [Produces("application/json")]
        public async Task<IActionResult> TopViewChart(int day)
        {

            try
            {
                IEnumerable<TopViewModel> book = _thongKeService.TopViewInclude(day).Take(10).ToList();
                return Ok(book);
            }
            catch
            {
                return BadRequest();
            }
        }

        public IActionResult SachBanChay(int day)
        {
            TKSachBanChayViewModel bookSell = new TKSachBanChayViewModel();
            bookSell.day = day;
            switch (day)
            {
                case 7:
                    bookSell.tittle = "7 Ngày Trước";
                    break;
                case 30:
                    bookSell.tittle = "30 Ngày Trước";
                    break;
                default:
                    bookSell.tittle = "24H Qua";
                    break;
            }
            var topsell = _thongKeService.BestSellerStatistic(day);
            //Chỉ lấy phần sách
            IQueryable<BestSellerBooksViewModel> res = topsell.AsQueryable();
            bookSell.listBookBestSell = res.ToList();

            return View(bookSell);

        }

        [Produces("application/json")]
        public async Task<IActionResult> BestSellerChart(int day)
        {

            try
            {
                IEnumerable<BestSellerBooksViewModel> book = _thongKeService.BestSellerStatistic(day).Take(10).ToList();
                return Ok(book);
            }
            catch
            {
                return BadRequest();
            }
        }

        public IActionResult CustomerStatistic(int day)
        {
            TKKhachHangViewModel kh = new TKKhachHangViewModel();
            kh.day = day;
            switch (day)
            {
                case 180:
                    kh.title = "6 Tháng Trước";
                    break;
                case 30:
                    kh.title = "1 Tháng Trước";
                    break;
                default:
                    kh.title = "24H qua";
                    break;
            }
            kh.listCustomer = _thongKeService.ListCustomer(day).ToList();
            return View(kh);
        }

        [Produces("application/json")]
        public async Task<IActionResult> CustomerChart(int day)
        {

            try
            {
                IEnumerable<CustomerStatisticViewModel> kh = _thongKeService.ListCustomer(day).ToList();
                return Ok(kh);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}







