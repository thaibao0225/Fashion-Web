using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_Infrastructure.Configurations
{
    public class RolesTableConfigurations : IEntityTypeConfiguration<RolesTable>
    {
        public void Configure(EntityTypeBuilder<RolesTable> builder)
        {
        }
    }
}
