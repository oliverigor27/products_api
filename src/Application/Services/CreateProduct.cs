using Products.DataAccess.Interfaces;
using Products.DataAccess.Model;

namespace Products.Application.Services;

public class CreateProductService(ICreateProductRepository productRepository)
{
    private readonly ICreateProductRepository _productRepository = productRepository;

    public async Task<string> CreateProductAsync(ProductModel product)
    {
        var result = await _productRepository.CreateNewProduct(product);

        if(result) return "Produto criado!";

        return "Não foi possível criar o produto na base de dados!";
    }
}
