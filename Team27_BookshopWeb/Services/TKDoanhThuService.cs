using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Services
{
    public class TKDoanhThuService : ITKDoanhThuService
    {
        private readonly MyDbContext myDbContext;
        private readonly IDashboardService _dashboardService;

        public TKDoanhThuService(MyDbContext myDbContext, IDashboardService dashboardService)
        {
            this.myDbContext = myDbContext;
            this._dashboardService = dashboardService;
        }

        public IQueryable<DateTime> GetDayDistinct(int days)
        {
            var passNDays = DateTime.Now.AddDays(-days);
            return myDbContext.Orders.Where(c => c.CreatedAt.Date >= passNDays.Date)
                .Select(k => k.CreatedAt.Date).Distinct()
                .AsQueryable();
        }

        public IQueryable<DoanhThuViewModel> ListRevenue(int days)
        {
            
            var passNDays = DateTime.Now.AddDays(-days);
            var doanhthu = GetDayDistinct(days)
                                 .Select(c => new DoanhThuViewModel
                                 {
                                     DateDoanhThu = c,
                                     Total = myDbContext.Orders.Where(d => d.CreatedAt.Date == c && d.PaymentStatus==0).Sum(o => o.Total)
                                 }).AsQueryable();
            return doanhthu;
        }
    }
}
