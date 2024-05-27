using Microsoft.EntityFrameworkCore;

namespace Module2.EntityFrameworkCodeFirstApproach.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=MYOTHETPC\\MSSQLSERVER2012;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true"
            );
        }
    }
}
