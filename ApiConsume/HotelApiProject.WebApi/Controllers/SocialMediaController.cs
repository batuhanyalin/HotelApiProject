using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListSocialMedia()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSocialMedia()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSocialMedia()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia()
        {
            return Ok();
        }
    }
}
