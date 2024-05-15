using Products.Interfaces;
using Products.Model;

namespace Products.Service;

public class ProductService : IProductService
{
    public async Task<object> CreateNewProduct(ProductsModel product)
    {
        throw new NotImplementedException();
    }

    public async Task<int> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductsModel>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateProduct(int id, ProductsModel product)
    {
        throw new NotImplementedException();
    }
}