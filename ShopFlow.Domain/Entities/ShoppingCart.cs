namespace ShopFlow.Domain.Entities;

public class ShoppingCart
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = [];
}
