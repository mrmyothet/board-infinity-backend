using Microsoft.EntityFrameworkCore;

namespace Module3.coreWebAPI.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }
}
