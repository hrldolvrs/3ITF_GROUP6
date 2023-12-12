using System.ComponentModel.DataAnnotations;

namespace TheMask.Models
{
    public class CustomerUser
    {
        public int CustomerId { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerUserName { get; set; }

        public string CustomerEmail { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        public string CustomerPassword { get; set; }



    }
}
