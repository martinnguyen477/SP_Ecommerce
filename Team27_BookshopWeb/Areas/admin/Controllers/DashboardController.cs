using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class DashboardController : Controller
    {
       
        private readonly MyDbContext _context;
        private readonly IDashboardService _dashboardService;
                
        public DashboardController(MyDbContext context, IDashboardService dashboardService)
        {
            _context = context;
            _dashboardService = dashboardService;
        }

        public IActionResult Index(int time)
        {
            DashboardViewModel dashboardView = new DashboardViewModel();
            
            dashboardView.SoLuongKH = _dashboardService.TKTongKH();
            dashboardView.SoSachDaBan = _dashboardService.TKSachBan();
            dashboardView.DTTrong1Tuan = _dashboardService.DTTrongTuan();
            dashboardView.DT1Nam = _dashboardService.DTTrongNam();

            dashboardView.time = time;
            dashboardView.listNewOrder = _dashboardService.GetNewOrder();
            
            return View(dashboardView);
        }

        [Produces("application/json")]
        public async Task<IActionResult> OrderTypeChart(int time)
        {

            try
            {
                IEnumerable<OrderTypeViewModel> order = _dashboardService.GetOrderType(time).ToList();
                return Ok(order);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}