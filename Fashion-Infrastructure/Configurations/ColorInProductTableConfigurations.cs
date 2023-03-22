using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class ColorInProductTableConfigurations : IEntityTypeConfiguration<ColorInProductTable>
    {
        public void Configure(EntityTypeBuilder<ColorInProductTable> builder)
        {
            builder.ToTable("ColorInProduct");
            builder.HasKey(t => new { t.cip_ColorId, t.cip_ProductId });


            builder.HasOne(t => t.cip_Color).WithMany(ur => ur.color_InProductsList)
            .HasForeignKey(pc => pc.cip_ColorId);
            builder.HasOne(t => t.cip_Product).WithMany(ur => ur.product_colorInProductTablesList)
            .HasForeignKey(pc => pc.cip_ProductId);
        }
    }
}
