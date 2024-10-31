using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _DefaultAboutUsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
