using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class BannerSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryBanners()
        {
            return View();
        }
    }
}