using System.ComponentModel.DataAnnotations;

namespace Infass_Vequiso.Models
{
    public class User
    {
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 150, ErrorMessage = "Age must be between 1 and 150.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
