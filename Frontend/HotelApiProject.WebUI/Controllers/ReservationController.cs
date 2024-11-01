using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
