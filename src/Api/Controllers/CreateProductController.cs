using Microsoft.AspNetCore.Mvc;
using Products.Application.Services;
using Products.DataAccess.Model;

namespace Products.Api.Controllers;

[ApiController]
[Route("api/product")]
public class ProductsController(CreateProductService createProduct) : ControllerBase
{
    private readonly CreateProductService _createProduct = createProduct;

    [HttpPost("create")]
    public async Task<ActionResult<string>> CreateNewProduct(ProductModel product)
    {
        var result = await _createProduct.CreateProductAsync(product);

        return Ok(result);
    }
}
