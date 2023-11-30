using System.ComponentModel.DataAnnotations;

namespace TheMask.Models
{
    public class SignUp
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string UserName { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        [Display(Name = "Username")]

        [EmailAddress(ErrorMessage = "Input The Correct Email Format")]
        public string Email { get; set; }
        [Display(Name = "Email")]

        [Required(ErrorMessage = "Password must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters")]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name = "Phone")]
        [RegularExpression("[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "Follow the " +
           "Format 00-000-0000")]
        public string? Phone { get; set; }



    }
}
