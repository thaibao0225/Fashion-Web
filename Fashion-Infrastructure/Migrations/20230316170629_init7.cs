using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "contact_EmailId",
                table: "Contact",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_contact_EmailId",
                table: "Contact",
                column: "contact_EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_EmailCustomer_contact_EmailId",
                table: "Contact",
                column: "contact_EmailId",
                principalTable: "EmailCustomer",
                principalColumn: "emailC_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_EmailCustomer_contact_EmailId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_contact_EmailId",
                table: "Contact");

            migrationBuilder.AlterColumn<string>(
                name: "contact_EmailId",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
