using System.ComponentModel.DataAnnotations;

namespace HotelApiProject.WebUI.Dtos.ContactDtos
{
    public class ContactAddDto
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage ="Ad bilgisi boş bırakılamaz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad bilgisi boş bırakılamaz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Telefon bilgisi boş bırakılamaz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "E-posta bilgisi boş bırakılamaz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Konu bilgisi boş bırakılamaz.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Metin bilgisi boş bırakılamaz.")]
        public string Text { get; set; }
        public DateTime SendingDate { get; set; }
        public bool IsApproved { get; set; }
    }
}
