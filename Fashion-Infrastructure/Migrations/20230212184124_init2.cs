using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillsTablebill_Id",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BillsTablebill_Id",
                table: "Products",
                column: "BillsTablebill_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Bills_BillsTablebill_Id",
                table: "Products",
                column: "BillsTablebill_Id",
                principalTable: "Bills",
                principalColumn: "bill_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Bills_BillsTablebill_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BillsTablebill_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BillsTablebill_Id",
                table: "Products");
        }
    }
}
