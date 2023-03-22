using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class ContactTableConfigurations: IEntityTypeConfiguration<ContactTable>
    {
        public void Configure(EntityTypeBuilder<ContactTable> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(t => new { t.contact_Id });

            builder.HasOne(t => t.contact_EmailCustomerTable).WithMany(ur => ur.emailC_ContactTableList)
            .HasForeignKey(pc => pc.contact_EmailId);
        }
    }


}
