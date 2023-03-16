namespace Fashion_Infrastructure.Entities
{
    public class CommentTable : BaseTable
    {
        public string comment_Id { get; set; }
        public string comment_Text { get; set; }
        public string comment_ProductId { get; set; } //
        public string comment_UserId { get; set; } //
    }
}
