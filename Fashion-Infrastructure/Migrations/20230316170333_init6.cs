using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SizeInProduct_sip_ProductId",
                table: "SizeInProduct",
                column: "sip_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeInProduct_Products_sip_ProductId",
                table: "SizeInProduct",
                column: "sip_ProductId",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeInProduct_Products_sip_ProductId",
                table: "SizeInProduct");

            migrationBuilder.DropIndex(
                name: "IX_SizeInProduct_sip_ProductId",
                table: "SizeInProduct");
        }
    }
}
