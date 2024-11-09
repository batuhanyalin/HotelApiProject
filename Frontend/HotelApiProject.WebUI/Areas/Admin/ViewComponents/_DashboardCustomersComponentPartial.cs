using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardCustomersComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
