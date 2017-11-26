using System.ComponentModel.DataAnnotations;

namespace netcore_mvc.Models
{
    public class LoginModel {
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
        [Required]
        public bool Remember { get; set; }
    }
}