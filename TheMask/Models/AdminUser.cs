using System.ComponentModel.DataAnnotations;

namespace TheMask.Models
{
    public class AdminUser
    {
        [Key]

        public int AdminId { get; set; }

        public string AdminFirstName { get; set; }


        public string AdminLastName { get; set; }

        public string AdminUserName { get; set; }

        public string AdminEmail { get; set; }

        public string? Phone { get; set; }

        public string AdminPassword { get; set; }


    }
}
