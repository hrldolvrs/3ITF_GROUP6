

using System.ComponentModel.DataAnnotations;

namespace TheMask.ViewModels
{
    public class AdminRegisterModel
    {

        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }


        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; }


        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please Enter your Username")]
        public string? UserName { get; set; }


        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Please Enter your Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must confirm the provided Password.")]
        public string? ConfirmPassword { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "Input The Correct Email Format")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please provide the Scholar's Contact Number.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0]{1}[9]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "Please follow this format: 09XX-XXX-XXXX")]
        public string? Phone { get; set; }
    }
}
