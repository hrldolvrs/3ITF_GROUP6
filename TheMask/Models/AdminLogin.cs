using System.ComponentModel.DataAnnotations;

namespace TheMask.Models
{
    public class AdminLogin
    {
        [Key]
        [Display(Name = "Id")]
        public int AdminId { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
