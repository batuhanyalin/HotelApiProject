using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
