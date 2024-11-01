﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.WebUI.Dtos.ServiceDtos
{
    public class ServiceAddDto
    {

        [Required(ErrorMessage ="İkon bilgisi boş geçilemez.")]
        public string ServiceIconUrl { get; set; }
        [Required(ErrorMessage = "Başlık bilgisi boş geçilemez.")]
        [StringLength(100,ErrorMessage ="Başlık bilgisi en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklama bilgisi boş geçilemez.")]
        public string Description { get; set; }
    }
}