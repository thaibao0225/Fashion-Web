using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_Infrastructure.Configurations
{
    public class CategoriesTableConfigurations : IEntityTypeConfiguration<CategoriesTable>
    {
        public void Configure(EntityTypeBuilder<CategoriesTable> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(t => new { t.category_Id });

        }
    }
}
