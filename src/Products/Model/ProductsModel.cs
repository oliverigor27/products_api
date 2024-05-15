namespace Products.Model;

public class ProductsModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public double ProductPrice { get; set; }
    public int ProductQtd { get; set; }
}