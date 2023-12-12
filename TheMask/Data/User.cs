using System;
using Microsoft.AspNetCore.Identity;
namespace TheMask.Data
{
    public class User : IdentityUser
    {
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }

        public string? CustomerUserName { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        public string? CustomerEmail { get; set; }

        public string? CustomerPassword { get; set; }

        public string? ConfirmPassword { get; set; }

    }
}
