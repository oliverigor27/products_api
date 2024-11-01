using Products.DataAccess.Model;

namespace Products.DataAccess.Interfaces;

public interface ICreateProductRepository
{
    public Task<bool> CreateNewProduct(ProductModel product);
}
