using System.ComponentModel.DataAnnotations;

namespace KhangnaseApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "You must specify your password between 5 and 12 characters")]

        public string Password { get; set; }
    }
}