using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_Infrastructure.Configurations
{
    public class BillsTableConfigurations : IEntityTypeConfiguration<BillsTable>
    {
        public void Configure(EntityTypeBuilder<BillsTable> builder)
        {
            builder.ToTable("Bills");
            builder.HasKey(t => new { t.bill_Id });

            builder.HasOne(t => t.userTable_UserId).WithMany(ur => ur.billsTablesList)
            .HasForeignKey(pc => pc.bill_UserId);

            

        }
    }
}
