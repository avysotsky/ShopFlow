namespace ShopFlow.Domain.Entities;

public class ShoppingCartItem
{
    public Guid Id { get; set; }

    public int Qty { get; set; }

    public Guid ShoppingCartId { get; set; }
    public ShoppingCart ShoppingCart { get; set; } = null!;
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;    
}
