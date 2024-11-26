using LittleFashion.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleFashion.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}