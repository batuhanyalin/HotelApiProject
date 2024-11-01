﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.WebUI.Dtos.TestimonialDtos
{
    public class TestimonialAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}