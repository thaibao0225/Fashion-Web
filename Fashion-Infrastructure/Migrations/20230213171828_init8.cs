using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "c37e82f0-30fc-445e-9c6b-4fed5c1f5da2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "87b4a46f-1fb2-406f-b7c0-f771771a6ea6");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "AspNetRoles",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f41e410-e79c-4895-91ce-3357c8163238", "156e415d-422b-407c-8291-1ac9c0d5ae74", "RolesTable", false, "STAFF", "staff" },
                    { "7d7e2c2a-a873-4f43-89bc-a04de9f96dd1", "8765d586-7ceb-47e6-a6e7-b815f1ac9500", "RolesTable", false, "ADMIN", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "538944f7-233a-432f-8407-92f720cc615d", 0, "", "65ebfa2e-fc42-42ce-a32a-52e3f7c47554", "UsersTable", "staff@gmail.com", true, "FirstName", false, "LastName", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEMhxq9pJYcXT5qs5WepFOy8kKlUQLUw2jHFTYluLfmbaa3QmRT8GtJwgDKoTdaYu7Q==", null, false, "80fbee80-2ed0-46ab-9246-f26b598a466f", false, "Staft" },
                    { "7b1e666b-fba5-4694-a1d4-6989eb355c3e", 0, "", "b9cccb1c-63fb-44e3-b846-e682e137d6ce", "UsersTable", "admin@gmail.com", true, "FirstName", false, "LastName", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGx+jzYVkjl3KIWbJBIeYeJekxQukddJ/tCTzyXa7jbv9p++/TdtGGot6gOoo6XXEQ==", null, false, "f20b0be0-2718-4e81-83e8-921258945cbe", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Name", "categpry_Description" },
                values: new object[] { "801ea538-7923-4119-b023-a76d0f85ab82", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "category_Name", "category_Description" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7d7e2c2a-a873-4f43-89bc-a04de9f96dd1", "538944f7-233a-432f-8407-92f720cc615d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f41e410-e79c-4895-91ce-3357c8163238", "7b1e666b-fba5-4694-a1d4-6989eb355c3e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "44a16b4d-6ab0-4971-92d0-cd3bf4e76c24", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "801ea538-7923-4119-b023-a76d0f85ab82", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d7e2c2a-a873-4f43-89bc-a04de9f96dd1", "538944f7-233a-432f-8407-92f720cc615d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f41e410-e79c-4895-91ce-3357c8163238", "7b1e666b-fba5-4694-a1d4-6989eb355c3e" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "44a16b4d-6ab0-4971-92d0-cd3bf4e76c24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f41e410-e79c-4895-91ce-3357c8163238");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7e2c2a-a873-4f43-89bc-a04de9f96dd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538944f7-233a-432f-8407-92f720cc615d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b1e666b-fba5-4694-a1d4-6989eb355c3e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "801ea538-7923-4119-b023-a76d0f85ab82");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "AspNetRoles");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Name", "categpry_Description" },
                values: new object[] { "87b4a46f-1fb2-406f-b7c0-f771771a6ea6", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "category_Name", "category_Description" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "c37e82f0-30fc-445e-9c6b-4fed5c1f5da2", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "87b4a46f-1fb2-406f-b7c0-f771771a6ea6", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }
    }
}
