namespace ShopFlow.Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    
    public decimal Price { get; set; }
    public int StockQty { get; set; }
}
