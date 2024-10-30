using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListService()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddService()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService()
        {
            return Ok();
        }
    }
}
