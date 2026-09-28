using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopFlow.Domain.Entities;

namespace ShopFlow.Infrastructure.Persistence.Configurations;

public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
{
    public void Configure(EntityTypeBuilder<ShoppingCart> builder)
    {
        builder.HasKey(sc => sc.Id);

        builder.HasMany(sc => sc.ShoppingCartItems)
            .WithOne(sci => sci.ShoppingCart)
            .HasForeignKey(sci => sci.ShoppingCartId);
    }
}
