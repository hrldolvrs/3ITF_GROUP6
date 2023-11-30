using System.ComponentModel.DataAnnotations;

namespace TheMask.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter your full name.")]
        public string FullName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ContactDate { get; set; }

        [Display(Name = "Message")]
        public string ContactMessage { get; set; }
    }
}
