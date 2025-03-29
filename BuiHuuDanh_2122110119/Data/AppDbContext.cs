using BuiHuuDanh_2122110119.Model;
using Microsoft.EntityFrameworkCore;

namespace BuiHuuDanh_2122110119.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
