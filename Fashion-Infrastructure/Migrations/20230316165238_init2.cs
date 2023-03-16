using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_ColorInProduct_Color_cip_ColorId",
                table: "ColorInProduct",
                column: "cip_ColorId",
                principalTable: "Color",
                principalColumn: "color_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorInProduct_Color_cip_ColorId",
                table: "ColorInProduct");
        }
    }
}
