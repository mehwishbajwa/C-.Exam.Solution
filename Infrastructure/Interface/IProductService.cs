using Infrastructure.Models;

namespace Infrastructure.Interface;

internal interface IProductService
{
    ProductResult AddProductToList(Product product);
    ProductResult <IEnumerable<Product>> GetAllProducts();
}
