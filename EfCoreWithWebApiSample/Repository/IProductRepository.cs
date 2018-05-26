using EfCoreWithWebApiSample.Entity;
using EfCoreWithWebApiSample.Repository.Infrastructure;

namespace EfCoreWithWebApiSample.Repository
{
public interface IProductRepository : IGenericRepository<Product>
{
}
}
