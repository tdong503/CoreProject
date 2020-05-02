using Microsoft.EntityFrameworkCore;

namespace CoreProject.Models
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql("Host=localhost;Username=postgres;Password=random;Database=User");
        }

        public DbSet<User> Users { get; set; }
    }
}