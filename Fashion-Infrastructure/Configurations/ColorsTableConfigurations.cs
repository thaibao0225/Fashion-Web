using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class ColorsTableConfigurations : IEntityTypeConfiguration<ColorsTable>
    {
        public void Configure(EntityTypeBuilder<ColorsTable> builder)
        {
            builder.ToTable("Color");
            builder.HasKey(t => new { t.color_Id });

        }
    }

}
