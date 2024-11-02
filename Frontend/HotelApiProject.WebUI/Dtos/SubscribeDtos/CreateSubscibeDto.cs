using System.ComponentModel.DataAnnotations;

namespace HotelApiProject.WebUI.Dtos.SubscribeDtos
{
    public class CreateSubscibeDto
    {
        [Required(ErrorMessage ="E-posta bilgisi boş geçilemez.")]
        public string Email { get; set; }
    }
}
