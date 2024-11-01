namespace Products.DataAccess.Model;

public class ProductModel
{
    public string ProductName { get; set; } = null!;
    public decimal ProductPrice { get; set; }
    public int ProductQtd { get; set; }
}
