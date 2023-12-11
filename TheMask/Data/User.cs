using System;
using Microsoft.AspNetCore.Identity;
namespace TheMask.Data
{
    public class User : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public string? UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

    }
}
