﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.EntityLayer.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Text { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int ClientCount { get; set; }
    }
}
