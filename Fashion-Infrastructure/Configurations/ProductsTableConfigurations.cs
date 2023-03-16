using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_Infrastructure.Configurations
{
    public class ProductsTableConfigurations : IEntityTypeConfiguration<ProductsTable>
    {
        public void Configure(EntityTypeBuilder<ProductsTable> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(t => new { t.product_Id });

            //builder.HasOne(t => t.productCategoryId).WithMany(ur => ur.Products)
            //.HasForeignKey(pc => pc.product_CategoryId);
        }
    }
}
