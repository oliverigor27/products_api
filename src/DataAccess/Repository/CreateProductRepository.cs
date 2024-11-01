using Microsoft.Extensions.Configuration;
using Npgsql;
using Products.DataAccess.Interfaces;
using Products.DataAccess.Model;

namespace Products.DataAccess.Repository;

public class CreateProductRepository(IConfiguration configuration) : ICreateProductRepository
{
    private readonly string _connectionString = configuration.GetConnectionString("DefaultConnection")!;

    public async Task<bool> CreateNewProduct(ProductModel product)
    {
        using NpgsqlConnection connection = new(_connectionString);
        await connection.OpenAsync();
        using var command = new NpgsqlCommand(
            "INSERT INTO product (product_name, product_price, product_quantity) VALUES (@Value01, @Value02, @Value03)", 
            connection
        );
        command.Parameters.AddWithValue("@Value01", product.ProductName);
        command.Parameters.AddWithValue("@Value02", product.ProductPrice);
        command.Parameters.AddWithValue("@Value03", product.ProductQtd);

        await command.ExecuteNonQueryAsync();

        return true;
    }
}
