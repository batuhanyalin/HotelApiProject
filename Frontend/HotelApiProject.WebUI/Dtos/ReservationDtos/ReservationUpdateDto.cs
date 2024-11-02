﻿using System.ComponentModel.DataAnnotations;

namespace HotelApiProject.WebUI.Dtos.ReservationDtos
{
    public class ReservationUpdateDto
    {
        public int ReservationId { get; set; }
        [Required(ErrorMessage = "Ad bilgisi boş geçilemez.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad bilgisi boş geçilemez.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-posta bilgisi boş geçilemez.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon bilgisi boş geçilemez.")]
        public string Phone { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }
        public DateTime ReservationDate { get; set; }
        [Required(ErrorMessage = "Çocuk sayı bilgisi boş geçilemez.")]
        public int ChildCount { get; set; }
        [Required(ErrorMessage = "Yetkişkin sayı bilgisi boş geçilemez.")]
        public int AdultCount { get; set; }
        [Required(ErrorMessage = "Oda sayı bilgisi boş geçilemez.")]
        public int RoomCount { get; set; }
        public string? Request { get; set; }
        public string? Description { get; set; }
        public string ReservationStatus { get; set; }
    }
}
