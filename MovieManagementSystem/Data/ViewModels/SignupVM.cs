using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Data.ViewModels
{
    public class SignupVM
    {
        [Required(ErrorMessage = "FullName is required!")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email Address is required!")]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage =("Passwords do not match"))]
        public string? ConfirmPassword { get; set; }
    }
}
