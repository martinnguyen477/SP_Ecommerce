using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Services
{
    public interface IDashboardService
    {
        int TKTongKH();

        int TKSachBan();

        float DTTrongTuan();

        float DTTrongNam();

        float DoanhThu(IQueryable<Order> orders);

        IQueryable<OrderTypeViewModel> GetOrderType(int time);

        IEnumerable<Order> GetNewOrder();
    }
}
