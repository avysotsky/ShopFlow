namespace ShopFlow.Domain.Entities;

public class OrderItem
{
    public Guid Id { get; set; }

    public decimal UnitPrice { get; set; }
    public int Qty { get; set; }

    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;    
}