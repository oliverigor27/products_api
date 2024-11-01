using Microsoft.Extensions.Configuration;
using Npgsql;
using Products.DataAccess.Interfaces;
using Products.DataAccess.Model;

namespace Products.DataAccess.Repository;

public class GetAllProductsRepository(IConfiguration configuration) : IGetAllProductsRepository
{
    private readonly string _connectionString = configuration.GetConnectionString("DefaultConnection")!;

    public async Task<List<ProductResponseModel>> GetAllProducts()
    {
        List<ProductResponseModel> products = [];

        using (NpgsqlConnection connection = new(_connectionString))
        {
            await connection.OpenAsync();

            using var command = new NpgsqlCommand("SELECT * FROM product", connection);
            using var reader = command.ExecuteReader();
            while (await reader.ReadAsync())
            {
                products.Add(new ProductResponseModel
                {
                    ProductId = (int)reader["product_id"],
                    ProductName = reader["product_name"].ToString()!,
                    ProductPrice = (double)reader["product_price"],
                    ProductQtd = (int)reader["product_quantity"]
                });
            }
        };

        return products;
    }
}
