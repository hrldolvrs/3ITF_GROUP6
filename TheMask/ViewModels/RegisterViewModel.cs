

using System.ComponentModel.DataAnnotations;

namespace TheMask.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string? CustomerFirstName { get; set; }


        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string? CustomerLastName { get; set; }


        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please Enter your Username")]
        public string? CustomerUserName { get; set; }


        [Required(ErrorMessage = "Please enter Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string? CustomerEmail { get; set; }


        [Display(Name = "Phone")]
        [RegularExpression("[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "Follow the " +
        "Format 00-000-0000")]
        public string? CustomerPhoneNumber { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter your Password")]
        public string? CustomerPassword { get; set; }

        [Compare(nameof(CustomerPassword), ErrorMessage = "Password and confirmation password did not match")]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Must Confirm Password")]
        public string? ConfirmPassword { get; set; }

    }
}
