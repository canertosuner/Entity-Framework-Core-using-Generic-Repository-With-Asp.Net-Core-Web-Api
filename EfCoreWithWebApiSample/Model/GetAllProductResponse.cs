using System.Collections.Generic;

namespace EfCoreWithWebApiSample.Model
{
    public class GetAllProductResponse
    {
        public List<ProductDto> ProductList { get; set; }
    }
}
