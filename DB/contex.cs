using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.DB
{
  public class SchoolSystemContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<School> Schools { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SchoolUser>()
        .HasKey(su => new{ su.SchoolId, su.UserId });

      modelBuilder.Entity<SchoolUser>()
        .HasOne(su => su.School)
        .WithMany(s => s.Users)
        .HasForeignKey(su => su.SchoolId);

      modelBuilder.Entity<SchoolUser>()
        .HasOne(su => su.User)
        .WithMany(u => u.Schools)
        .HasForeignKey(su => su.UserId);
    }
    public SchoolSystemContext(DbContextOptions<SchoolSystemContext> options) : base(options)
    {
    }
  }
}