using System.Collections.Generic;

namespace SchoolSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Role { get; set; }
        public string Token { get; set; }

        // public List<SchoolUser> SchoolUsers { get; set; }
        public List<SchoolUser> Schools { get; set; }
    }
}