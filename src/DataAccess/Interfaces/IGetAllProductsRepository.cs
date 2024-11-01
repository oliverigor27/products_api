using Products.DataAccess.Model;

namespace Products.DataAccess.Interfaces;

public interface IGetAllProductsRepository
{
    public Task<List<ProductResponseModel>> GetAllProducts();
}
