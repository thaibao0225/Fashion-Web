using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_SizeInProduct_Size_sip_Id",
                table: "SizeInProduct",
                column: "sip_Id",
                principalTable: "Size",
                principalColumn: "size_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeInProduct_Size_sip_Id",
                table: "SizeInProduct");
        }
    }
}
