using SchoolSystem.Models;

namespace SchoolSystem.Models
{
    public class SchoolUser
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public string Role { get; set; }
        
    }
}