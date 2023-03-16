using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "comment_UserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_comment_UserId",
                table: "Comment",
                column: "comment_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_comment_UserId",
                table: "Comment",
                column: "comment_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_comment_UserId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_comment_UserId",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "comment_UserId",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
