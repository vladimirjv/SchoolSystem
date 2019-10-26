namespace SchoolSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password_hash	 { get; set; }

        public string Role { get; set; }
        public string Token { get; set; }
    }
}