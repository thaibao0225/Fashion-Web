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

        }
    }

}
