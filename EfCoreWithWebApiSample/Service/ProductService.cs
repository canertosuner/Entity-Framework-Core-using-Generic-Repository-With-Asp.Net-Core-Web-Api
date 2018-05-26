using System.Collections.Generic;
using EfCoreWithWebApiSample.Entity;
using EfCoreWithWebApiSample.Model;
using EfCoreWithWebApiSample.Repository;

namespace EfCoreWithWebApiSample.Service
{
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public GetAllProductResponse GetAllProducts()
    {
        var result = _productRepository.All();
        var mappedList = new List<ProductDto>();

        foreach (var item in result)
        {
            mappedList.Add(new ProductDto { Id = item.Id, Name = item.Name });
        }

        return new GetAllProductResponse
        {
            ProductList = mappedList
        };
    }

    public void AddProduct(AddProductRequest reqModel)
    {
        _productRepository.Save(new Product { Name = reqModel.Name });
    }
}
}
