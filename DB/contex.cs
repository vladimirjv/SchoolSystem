using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.DB
{
    public class SchoolSystemContext: DbContext
    {
      public DbSet<User> Users {get; set;}
        public SchoolSystemContext(DbContextOptions<SchoolSystemContext> options) : base(options)
        {
        }
    }
}