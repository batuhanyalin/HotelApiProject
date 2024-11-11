using HotelApiProject.WebUI.Dtos.DashboardDtos.SocialMedia;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelApiProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardSocialMediaTwitterComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=jeandpardaillan"),
                Headers =
    {
        { "x-rapidapi-key", "87ebda1640msh1f0710fdc6ebb78p11788djsnc07507e0fe79" },
        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                TwitterFollowersDto followersDto = JsonConvert.DeserializeObject<TwitterFollowersDto>(body);
                return View(followersDto);
            }
        }
    }
}
