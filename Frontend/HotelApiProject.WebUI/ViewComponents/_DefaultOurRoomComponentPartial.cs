using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _DefaultOurRoomComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
