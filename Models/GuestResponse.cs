using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse {
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$", 
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+$", 
         ErrorMessage = "Characters are not allowed.")]
        public uint Age { get; set; }
        public bool? WillAttend { get; set; }
    }
}