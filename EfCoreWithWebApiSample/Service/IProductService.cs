using EfCoreWithWebApiSample.Model;

namespace EfCoreWithWebApiSample.Service
{
public interface IProductService
{
    GetAllProductResponse GetAllProducts();
    void AddProduct(AddProductRequest reqModel);
}
}
