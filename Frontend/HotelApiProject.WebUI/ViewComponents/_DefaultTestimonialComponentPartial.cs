using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
