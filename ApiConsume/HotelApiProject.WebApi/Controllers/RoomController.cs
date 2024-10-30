﻿using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _RoomService;

        public RoomController(IRoomService RoomService)
        {
            _RoomService = RoomService;
        }

        [HttpGet]
        public IActionResult ListRoom()
        {
            var value = _RoomService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _RoomService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _RoomService.TInsert(Room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            _RoomService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _RoomService.TUpdate(Room);
            return Ok();
        }

    }
}