using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class SizeTableConfigurations : IEntityTypeConfiguration<SizeTable>
    {
        public void Configure(EntityTypeBuilder<SizeTable> builder)
        {
            builder.ToTable("Size");
            builder.HasKey(t => new { t.size_Id });

        }
    }
}
