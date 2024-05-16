using Microsoft.AspNetCore.Mvc;
using Products.Dto;
using Products.Interfaces;
using Products.Model;

namespace Products.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("list")]
    public async Task<ActionResult<List<ProductsModel>>> GetAllProducts()
    {
        var result = await _productService.GetAllProducts();

        return Ok(result);
    }

    [HttpPost("new-product")]
    public async Task<ActionResult<object>> CreateNewProduct(ProductsDto products)
    {
        object result = await _productService.CreateNewProduct(products);

        return Ok(result);
    }
}