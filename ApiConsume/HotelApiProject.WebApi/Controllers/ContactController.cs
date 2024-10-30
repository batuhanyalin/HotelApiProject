using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListContact()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetContact()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddContact()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact()
        {
            return Ok();
        }
    }
}
