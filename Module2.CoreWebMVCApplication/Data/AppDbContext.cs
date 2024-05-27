using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module2.CoreWebMVCApplication.Models;

namespace Module2.CoreWebMVCApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Module2.CoreWebMVCApplication.Models.User> User { get; set; } = default!;
    }
}
