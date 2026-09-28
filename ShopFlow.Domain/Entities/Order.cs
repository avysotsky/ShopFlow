namespace ShopFlow.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }

    public long OrderNumber { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    
    public ICollection<OrderItem> OrderItems { get; set; } = [];
}
