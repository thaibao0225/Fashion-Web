using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class EmailCustomerTableConfigurations : IEntityTypeConfiguration<EmailCustomerTable>
    {
        public void Configure(EntityTypeBuilder<EmailCustomerTable> builder)
        {
            builder.ToTable("EmailCustomer");
            builder.HasKey(t => new { t.emailC_Id });

        }
    }
}
