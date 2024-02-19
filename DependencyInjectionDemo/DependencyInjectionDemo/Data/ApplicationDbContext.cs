using DependencyInjectionDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
