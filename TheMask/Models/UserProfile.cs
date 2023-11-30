namespace TheMask.Models
{
    public class UserProfile
    {
        public int UId { get; set; }
        public string UName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }   

        public string Email { get; set; }

        public string Password { get; set; }

        public string Number { get; set; } 
        public Boolean UserType { get; set; }
        
        
    }
}
