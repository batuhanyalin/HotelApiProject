﻿using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
