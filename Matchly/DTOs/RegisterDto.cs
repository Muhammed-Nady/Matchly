using System.ComponentModel.DataAnnotations;

namespace Matchly.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Username must be entered")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password must be entered")]
        public string Password { get; set; }
    }
}
