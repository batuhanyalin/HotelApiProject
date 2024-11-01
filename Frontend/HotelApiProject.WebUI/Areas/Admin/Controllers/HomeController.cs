using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
