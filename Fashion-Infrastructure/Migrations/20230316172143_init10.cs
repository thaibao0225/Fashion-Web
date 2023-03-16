using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "product_CategoryId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "bill_UserId",
                table: "Bills",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_CategoryId",
                table: "Products",
                column: "product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AspNetUsers_bill_UserId",
                table: "Bills",
                column: "bill_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_product_CategoryId",
                table: "Products",
                column: "product_CategoryId",
                principalTable: "Categories",
                principalColumn: "category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_bill_UserId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_product_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_product_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills");

            migrationBuilder.AlterColumn<string>(
                name: "product_CategoryId",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "bill_UserId",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
