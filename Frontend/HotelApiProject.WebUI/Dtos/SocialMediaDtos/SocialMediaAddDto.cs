﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelApiProject.WebUI.Dtos.SocialMediaDtos
{
    public class SocialMediaAddDto
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string LinkUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
