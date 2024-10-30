using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListAbout()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAbout()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout()
        {
            return Ok();
        }
    }
}
