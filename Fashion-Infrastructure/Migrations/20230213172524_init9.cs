using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "bill_ProductUnitList",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "bill_ProductPriceList",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "bill_Code",
                table: "Bills",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dea4d762-a23f-4cba-a038-2259193cc7da", "f983d701-bf69-4f2f-b170-135b7aa6be8f", "RolesTable", false, "ADMIN", "admin" },
                    { "f12299e3-23c0-4d65-b6be-66f0293b3f1b", "cd22a37c-e024-4ae2-b46a-804c0ca1893c", "RolesTable", false, "STAFF", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6018b7d5-9db3-4de7-94ac-e142f1ca862a", 0, "", "42fa9d3b-90c3-4684-af27-1c9318e8e93e", "UsersTable", "admin@gmail.com", true, "FirstName", false, "LastName", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAaFLIphmICD1X/ZfY68x6oYyfI+88H6o/h1BdyLjDmwp7WAM4MkpUNvaruCsYbWXg==", null, false, "edc99be5-d742-4dbf-a466-42f0054fb125", false, "Admin" },
                    { "7742eeba-76d5-41ec-bdc1-c31304862a78", 0, "", "40b73046-51c3-4f27-8299-de1c22c6df03", "UsersTable", "staff@gmail.com", true, "FirstName", false, "LastName", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEP9j1yE6I4yhq3pDni0Inl1udl+zez87W+sZQlEnz5V9pxoREX7fjDoaArHbFL28Mg==", null, false, "b36b60a6-6d6d-4dfd-b2d3-29cfa96da326", false, "Staft" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Name", "categpry_Description" },
                values: new object[] { "1d78bcfe-137b-42b8-8fc6-8dcddbaa1904", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "category_Name", "category_Description" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f12299e3-23c0-4d65-b6be-66f0293b3f1b", "6018b7d5-9db3-4de7-94ac-e142f1ca862a" },
                    { "dea4d762-a23f-4cba-a038-2259193cc7da", "7742eeba-76d5-41ec-bdc1-c31304862a78" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "58f23a31-a072-4b4b-9eec-c09a5ee99cc3", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "7742eeba-76d5-41ec-bdc1-c31304862a78" },
                    { "6f50bca8-dea2-463c-af13-f678bf6ce1e6", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "7742eeba-76d5-41ec-bdc1-c31304862a78" },
                    { "d00c9360-fb82-4554-a6ae-3d0c32a9ea1f", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "6018b7d5-9db3-4de7-94ac-e142f1ca862a" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "046b7f5d-883c-45c6-a1ab-d5ac3afc06e6", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "1d78bcfe-137b-42b8-8fc6-8dcddbaa1904", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f12299e3-23c0-4d65-b6be-66f0293b3f1b", "6018b7d5-9db3-4de7-94ac-e142f1ca862a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dea4d762-a23f-4cba-a038-2259193cc7da", "7742eeba-76d5-41ec-bdc1-c31304862a78" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "58f23a31-a072-4b4b-9eec-c09a5ee99cc3");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "6f50bca8-dea2-463c-af13-f678bf6ce1e6");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "d00c9360-fb82-4554-a6ae-3d0c32a9ea1f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "046b7f5d-883c-45c6-a1ab-d5ac3afc06e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea4d762-a23f-4cba-a038-2259193cc7da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f12299e3-23c0-4d65-b6be-66f0293b3f1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6018b7d5-9db3-4de7-94ac-e142f1ca862a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7742eeba-76d5-41ec-bdc1-c31304862a78");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "1d78bcfe-137b-42b8-8fc6-8dcddbaa1904");

            migrationBuilder.AlterColumn<int>(
                name: "bill_ProductUnitList",
                table: "Bills",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "bill_ProductPriceList",
                table: "Bills",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "bill_Code",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
