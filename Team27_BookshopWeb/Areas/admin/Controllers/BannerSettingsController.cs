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