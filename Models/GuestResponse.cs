using System.ComponentModel.DataAnnotations;

namespace PartyInvites2.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter valid e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Do you want to attend?")]
        public bool? WillAttend { get; set; }
    }
}
