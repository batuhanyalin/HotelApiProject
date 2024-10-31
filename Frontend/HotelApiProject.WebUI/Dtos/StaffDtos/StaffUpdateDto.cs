﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.WebUI.Dtos.StaffDtos
{
    public class StaffUpdateDto
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public bool IsApproved { get; set; }
        public IFormFile Image { get; set; }
    }
}
