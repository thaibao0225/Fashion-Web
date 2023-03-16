using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cip_ProductId",
                table: "ColorInProduct",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ColorInProduct_cip_ProductId",
                table: "ColorInProduct",
                column: "cip_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorInProduct_Products_cip_ProductId",
                table: "ColorInProduct",
                column: "cip_ProductId",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorInProduct_Products_cip_ProductId",
                table: "ColorInProduct");

            migrationBuilder.DropIndex(
                name: "IX_ColorInProduct_cip_ProductId",
                table: "ColorInProduct");

            migrationBuilder.AlterColumn<string>(
                name: "cip_ProductId",
                table: "ColorInProduct",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
