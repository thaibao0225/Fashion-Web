using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class SizeInProductTableConfigurations : IEntityTypeConfiguration<SizeInProductTable>
    {
        public void Configure(EntityTypeBuilder<SizeInProductTable> builder)
        {
            builder.ToTable("SizeInProduct");
            builder.HasKey(t => new { t.sip_Id, t.sip_ProductId });

            builder.HasOne(t => t.sip_Size).WithMany(ur => ur.size_sizeInProductTablesList)
            .HasForeignKey(pc => pc.sip_Id);
            builder.HasOne(t => t.sip_Product).WithMany(ur => ur.product_sizeInProductTablesList)
            .HasForeignKey(pc => pc.sip_ProductId);

        }
    }
}
