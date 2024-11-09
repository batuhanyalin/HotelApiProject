using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardStatisticCardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
