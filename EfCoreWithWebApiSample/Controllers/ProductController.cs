using EfCoreWithWebApiSample.Model;
using EfCoreWithWebApiSample.Service;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreWithWebApiSample.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<GetAllProductResponse> GetAll()
    {
        var response = _productService.GetAllProducts();
        return Ok(response);
    }

    [HttpPost]
    public ActionResult Post([FromBody] AddProductRequest reqModel)
    {
        _productService.AddProduct(reqModel);
        return Ok();
    }
}
}
