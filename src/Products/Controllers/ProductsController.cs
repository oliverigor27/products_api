using Microsoft.AspNetCore.Mvc;
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

    [HttpGet]
    public async Task<ActionResult<List<ProductsModel>>> GetAllProducts()
    {
        var result = _productService.GetAllProducts();

        return Ok(result);
    }
}