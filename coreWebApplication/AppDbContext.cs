using coreWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace coreWebApplication
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionStrings.builder.ConnectionString);
        }

        public DbSet<User> UserRegistration { get; set; }
    }
}
