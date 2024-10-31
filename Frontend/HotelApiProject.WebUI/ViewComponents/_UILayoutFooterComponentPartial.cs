using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
