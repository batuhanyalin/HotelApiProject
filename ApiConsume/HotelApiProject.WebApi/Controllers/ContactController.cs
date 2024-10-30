﻿using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public IActionResult ListContact()
        {
            var value = _ContactService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _ContactService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddContact(Contact Contact)
        {
            _ContactService.TInsert(Contact);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            _ContactService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            _ContactService.TUpdate(Contact);
            return Ok();
        }
    }
}
