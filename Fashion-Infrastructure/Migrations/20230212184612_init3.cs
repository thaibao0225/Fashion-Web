using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bill_ProductColorList",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "bill_ProductPriceList",
                table: "Bills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "bill_ProductSizeList",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "bill_ProductUnitList",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "bill_ProductsIdList",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bill_ProductColorList",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_ProductPriceList",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_ProductSizeList",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_ProductUnitList",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_ProductsIdList",
                table: "Bills");
        }
    }
}
