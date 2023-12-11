using System.ComponentModel.DataAnnotations;

namespace TheMask.ViewModels
{
    public class UserLoginModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

    }
}



