namespace Products.DataAccess.Model;

public class ProductResponseModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public double ProductPrice { get; set; }
    public int ProductQtd { get; set; }
}
