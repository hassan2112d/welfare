using System.ComponentModel.DataAnnotations;

namespace welfare.Models
{
    public class RegisterModel
    {
        [Key]

        public int Id { get; set; }

        [Required (ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Strong Password")]
        public string Password { get; set; }
    }
}
