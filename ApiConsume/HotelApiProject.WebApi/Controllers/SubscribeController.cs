using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListSubscribe()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSubscribe()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe()
        {
            return Ok();
        }
    }
}
