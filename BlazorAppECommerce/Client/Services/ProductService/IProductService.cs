using System.Collections.Generic;
using BlazorAppECommerce.Shared;

namespace BlazorAppECommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}
