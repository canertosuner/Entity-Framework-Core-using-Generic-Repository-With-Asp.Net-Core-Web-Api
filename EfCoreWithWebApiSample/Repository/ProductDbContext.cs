using EfCoreWithWebApiSample.Entity;
using Microsoft.EntityFrameworkCore;

namespace EfCoreWithWebApiSample.Repository
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
