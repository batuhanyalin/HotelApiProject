using HotelApiProject.WebUI.Dtos.ReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelApiProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardCustomersComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardCustomersComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5173/api/Reservation/GetReservationLast6");
            var jsonData= await responseMessage.Content.ReadAsStringAsync();
            var value= JsonConvert.DeserializeObject<List<ReservationListDto>>(jsonData);
            return View(value);
        }
    }
}
