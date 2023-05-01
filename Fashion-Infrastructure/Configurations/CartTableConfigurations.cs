using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class CartTableConfigurations : IEntityTypeConfiguration<CartTable>
    {
        public void Configure(EntityTypeBuilder<CartTable> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(t => new { t.cart_ProductId, t.cart_SizeId, t.cart_ColorId, t.cart_UserId });

            builder.HasOne(t => t.cart_Product).WithMany(ur => ur.product_CartTableList)
            .HasForeignKey(pc => pc.cart_ProductId);

            builder.HasOne(t => t.cart_Size).WithMany(ur => ur.size_CartTableList)
            .HasForeignKey(pc => pc.cart_SizeId);

            builder.HasOne(t => t.cart_Color).WithMany(ur => ur.color_CartTableList)
            .HasForeignKey(pc => pc.cart_ColorId);

            builder.HasOne(t => t.cart_User).WithMany(ur => ur.cartTableList)
            .HasForeignKey(pc => pc.cart_UserId);



        }
    }
}
