using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "comment_ProductId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_comment_ProductId",
                table: "Comment",
                column: "comment_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Products_comment_ProductId",
                table: "Comment",
                column: "comment_ProductId",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Products_comment_ProductId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_comment_ProductId",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "comment_ProductId",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
