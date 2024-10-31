using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _UILayoutSubscribeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
