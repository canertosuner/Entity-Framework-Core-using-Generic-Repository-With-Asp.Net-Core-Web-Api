using EfCoreWithWebApiSample.Entity;
using EfCoreWithWebApiSample.Repository.Infrastructure;

namespace EfCoreWithWebApiSample.Repository
{
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ProductDbContext dbContext) : base(dbContext)
    {
    }
}
}
