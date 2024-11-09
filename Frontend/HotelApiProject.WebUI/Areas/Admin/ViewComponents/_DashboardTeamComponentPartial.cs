using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardTeamComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
