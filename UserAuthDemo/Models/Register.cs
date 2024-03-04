using System.ComponentModel.DataAnnotations;

namespace UserAuthDemo.Models
{
    public class Register
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Cpassword { get; set; }

    }
}
