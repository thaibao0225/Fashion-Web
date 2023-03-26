namespace Fashion_Infrastructure.Entities
{
    public class CommentTable : BaseTable
    {
        public string comment_Id { get; set; }
        public string comment_Text { get; set; }
        public int comment_Rating { get; set; }
        public string comment_ProductId { get; set; } //
        public ProductsTable comment_ProductsTable { get; set; } //
        public string comment_UserId { get; set; } //
        public UsersTable comment_UsersTable { get; set; } //
    }
}
