using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_Infrastructure.Configurations
{
    public class UsersTableConfigurations : IEntityTypeConfiguration<UsersTable>
    {
        public void Configure(EntityTypeBuilder<UsersTable> builder)
        {
        }
    }
}
