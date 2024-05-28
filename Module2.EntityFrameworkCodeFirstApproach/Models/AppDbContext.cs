using Microsoft.EntityFrameworkCore;

namespace Module2.EFCoreCodeFirstApproach.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=MYOTHETPC\\MSSQLEXPRESS2016;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true"
            );
        }
    }
}
