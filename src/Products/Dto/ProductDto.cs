namespace Products.Dto;

public record ProductsDto
{
    public string ProductName { get; set; } = string.Empty;
    public double ProductPrice { get; set; }
    public int ProductQtd { get; set; }
}