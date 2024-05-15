using Products.Interfaces;
using Products.Model;
using Npgsql;
using Products.Dto;

namespace Products.Service;

public class ProductService : IProductService
{
    private readonly string _connectionString;
    public ProductService(IConfiguration configuration)
    {   
        _connectionString = configuration.GetConnectionString("ContextString");
    }

    public async Task<object> CreateNewProduct(ProductsDto product)
    {
        using(NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using(var command = new NpgsqlCommand("INSERT INTO product (product_name, product_price, product_quantity) VALUES (@Value01, @Value02, @Value03)", connection))
            {
                command.Parameters.AddWithValue("@Value01", product.ProductName);
                command.Parameters.AddWithValue("@Value02", product.ProductPrice);
                command.Parameters.AddWithValue("@Value03", product.ProductQtd);
            
                await command.ExecuteNonQueryAsync();
            }
        }

        return "Product was created!";
    }

    public async Task<int> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductsModel>> GetAllProducts()
    {
        List<ProductsModel> products = [];

        using (NpgsqlConnection connection = new(_connectionString))
        {
            await connection.OpenAsync();

            using (var command = new NpgsqlCommand("SELECT * FROM product", connection))
            using (var reader = command.ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    products.Add(new ProductsModel
                    {
                        ProductId = (int)reader["product_id"],
                        ProductName = reader["product_name"].ToString(),
                        ProductPrice = (double)reader["product_price"],
                        ProductQtd = (int)reader["product_quantity"]
                    });
                }
            }
        };

        return products;
    }

    public async Task<int> UpdateProduct(int id, ProductsModel product)
    {
        throw new NotImplementedException();
    }
}