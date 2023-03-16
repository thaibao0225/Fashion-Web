using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Configurations
{
    public class CommentTableConfigurations : IEntityTypeConfiguration<CommentTable>
    {
        public void Configure(EntityTypeBuilder<CommentTable> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(t => new { t.comment_Id });

            builder.HasOne(t => t.comment_ProductsTable).WithMany(ur => ur.product_CommentTableList)
            .HasForeignKey(pc => pc.comment_ProductId);
            builder.HasOne(t => t.comment_UsersTable).WithMany(ur => ur.CommentTableList)
            .HasForeignKey(pc => pc.comment_UserId);
        }
    }

}
