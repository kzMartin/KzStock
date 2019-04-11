using KzStock.Models;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Persistance
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
        }
    }
}