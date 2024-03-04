using System.ComponentModel.DataAnnotations;

namespace UserAuthDemo.Models
{
    public class Login
    {
        [EmailAddress,Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
