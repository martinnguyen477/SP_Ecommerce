using Microsoft.AspNetCore.Mvc;

namespace Team27_BookshopWeb.Controllers
{
    public class ContactController : Controller
    {
        [Route("/lien-he")]
        public IActionResult Index()
        {
            return View();
        }
    }
}