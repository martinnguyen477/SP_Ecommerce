using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Services
{
    public class DashboadService : IDashboardService
    {
        private readonly MyDbContext myDbContext;

        private readonly ICustomerService _customerService;

        public DashboadService(MyDbContext myDbContext, ICustomerService customerService)
        {
            this.myDbContext = myDbContext;
            this._customerService = customerService;
        }

        public int TKTongKH()
        {
            return _customerService.GetCustomersNotDelete().Count();
        }

        public int TKSachBan()
        {
            //thống kê số sách bán được trong 1 tuần
            DateTime day = DateTime.Now.AddDays(-7); // ngày sau 1 tuần
            return myDbContext.OrderItems.Where(p => p.CreatedAt.Date >= day.Date)
                                        .Sum(o => o.Quantity);
        }

        public float DTTrongTuan()
        {
            //thống kê doanh thu trong 1 tuần
            var toDate = DateTime.Today.AddDays(-7); // ngày trước 1 tuần
            var res = myDbContext.Orders.Where(p => p.CreatedAt >= toDate);
            return DoanhThu(res);
        }

        public float DoanhThu(IQueryable<Order> orders)
        {
            return (float) orders.Sum(o => o.Total);
        }

        public float DTTrongNam()
        {
           int year = DateTime.Now.Year;
            //thống kê doanh thu trong 1 năm
            var res = myDbContext.Orders.Where(p => p.CreatedAt.Year == year);
            return DoanhThu(res);
        }

        public IEnumerable<Order> GetNewOrder()
        {
            return myDbContext.Orders.OrderByDescending(o => o.CreatedAt);
        }

        //dh dang xl 1, dh thành cong 4 , huy 5 
        public IQueryable<OrderTypeViewModel> GetOrderType(int time)
        {
            var passNDays = DateTime.Now;
            if (time == 0 || time == 1)
            {
                passNDays = passNDays;
            }
            else
            {
                passNDays = DateTime.Now.AddDays(-30);
            }
            IQueryable<OrderTypeViewModel> orderType = myDbContext.OrderStatuses.Include(o => o.Orders).Select(o => new OrderTypeViewModel
            {
                
                OrderTypeName = o.Name,
                //Lấy số lượng đơn hàng theo từng trạng thái
                Count = o.Orders.Where(dh => dh.CreatedAt.Date >= passNDays.Date).Count()
            })
                .AsQueryable();

            return orderType;
        }
    }
}
