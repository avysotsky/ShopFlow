using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopFlow.Domain.Entities;

namespace ShopFlow.Infrastructure.Persistence.Configurations;

public class ShoppingCartItemConfiguration 
    : IEntityTypeConfiguration<ShoppingCartItem>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
    {
        builder.HasKey(sci => sci.Id);

        builder.Property(sci => sci.Qty)
            .IsRequired();

        builder.HasOne(sci => sci.Product)
            .WithMany()
            .HasForeignKey(sci => sci.ProductId);

        builder.HasIndex(sci => new
        {
            sci.ShoppingCartId,
            sci.ProductId
        }).IsUnique();        
    }
}
