using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeInProduct",
                table: "SizeInProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorInProduct",
                table: "ColorInProduct");

            migrationBuilder.AlterColumn<string>(
                name: "sip_ProductId",
                table: "SizeInProduct",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeInProduct",
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorInProduct",
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeInProduct",
                table: "SizeInProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorInProduct",
                table: "ColorInProduct");

            migrationBuilder.AlterColumn<string>(
                name: "sip_ProductId",
                table: "SizeInProduct",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeInProduct",
                table: "SizeInProduct",
                column: "sip_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorInProduct",
                table: "ColorInProduct",
                column: "cip_ColorId");
        }
    }
}
