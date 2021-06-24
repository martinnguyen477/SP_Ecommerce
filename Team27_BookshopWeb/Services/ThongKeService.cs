using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class ThongKeService : IThongKeService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;

        public ThongKeService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            this._booksService = booksService;
        }

        public IQueryable<TopViewModel> TopViewInclude(int day)
        {
            if (day == 0) day = 2;
            IQueryable<Book> books = _booksService.GetNotDeletedBooks().Include(b => b.Author)
                                                    .Include(b => b.Category)
                                                    .Include(b => b.BookImages).AsQueryable();
            IQueryable<TopViewModel> res = _booksService.TopView(day, "desc", true, books)
                                                .AsQueryable();
            return res;
        }

        public IQueryable<BestSellerBooksViewModel> BestSellerStatistic(int day)
        {
            if (day == 0) day = 2;
            IQueryable<BestSellerBooksViewModel> res = GetBestSeller(day, GetBestSellerInclude()).AsQueryable();
            return res;
        }

        public IQueryable<Book> GetBestSellerInclude()
        {
            return _booksService.GetNotDeletedBooks().Include(b => b.Author)
                                                    .Include(b => b.Category)
                                                    .Include(b => b.BookImages).AsQueryable();

        }

        public IQueryable<BestSellerBooksViewModel> GetBestSeller(int days, IQueryable<Book> b)
        {

            //Ngày của cách [days] tính từ hiện tại => Ví dụ: days=7, lấy ra ngày cách đây 7 ngày
            var passNDays = DateTime.Now.AddDays(-days);
            IQueryable<BestSellerBooksViewModel> bestseller = b.Select(b => new BestSellerBooksViewModel
            {
                bestSeller = b,
                //Lấy số lượng sách đã bán được trong khoảng thời gian
                numberOfBooks = b.OrderDetails.Where(od => od.CreatedAt.Date >= passNDays.Date).Sum(od => od.Quantity),
                //Lấy tiền sách đã bán được trong khoảng thời gian đưa vào mảng
                totalSell = b.OrderDetails.Where(o => o.CreatedAt.Date >= passNDays.Date).Select(o => o.Total).ToList()
            })
                //Chỉ lấy những sách bán được (số lượng > 0)
                .Where(s => s.numberOfBooks > 0)
                //Sắp xếp theo thứ tự giảm dần của số lượng sách bán được
                .OrderByDescending(s => s.numberOfBooks).AsQueryable();

            return bestseller;
        }

        public IQueryable<DateTime> GetDayDistinct(int days)
        {
            var passNDays = DateTime.Now.AddDays(-days);
            return myDbContext.Customers.Where(c => c.CreatedAt.Date >= passNDays.Date)
                .Select(k => k.CreatedAt.Date).Distinct()
                .AsQueryable();
        }

        public IQueryable<CustomerStatisticViewModel> ListCustomer(int days)
        {
           var passNDays = DateTime.Now.AddDays(-days);
           var customers = GetDayDistinct(days)
                                .Select(c => new CustomerStatisticViewModel{
                                    DateCustomer = c,
                                    Count = myDbContext.Customers.Where(cus => cus.DeletedAt == null 
                                                                        && cus.CreatedAt.Date == c).Count()
                                }).AsQueryable();
            return customers;
        }
    }
        
}
