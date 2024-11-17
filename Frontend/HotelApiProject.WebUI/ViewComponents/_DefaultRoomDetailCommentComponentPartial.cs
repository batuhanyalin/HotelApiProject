using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _DefaultRoomDetailCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
