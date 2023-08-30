using System.ComponentModel.DataAnnotations;

namespace CMPG323_Project2_API.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

    }
}
