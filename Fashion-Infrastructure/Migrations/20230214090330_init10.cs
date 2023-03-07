using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19e97f82-bfc2-4b8d-b498-8c074b89a90d", "08c9d1c7-0045-4843-8da0-1edea64e3bd3", "RolesTable", false, "STAFF", "staff" },
                    { "e0bce046-dbaa-4693-a0fe-0d4f134f6470", "fef2a43f-9a74-42e0-8e6f-8572d02bac28", "RolesTable", false, "ADMIN", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29", 0, "", "06be6e50-73bf-4431-bccb-4f7de944f131", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAELQPBYn4imeEpkcQV1Y8Oq46P5NUIJ9IYO7HQ/jjFf2lkraIRLYXGoIJHgY/R/PM/w==", null, false, "acd080f3-4d19-4710-9844-272fd235cef1", false, "Staft" },
                    { "ec647bb9-2988-4ff3-9242-00872eeb0241", 0, "", "909dcd2a-af54-4502-86fe-771b3b82214e", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC31LTTjlJykAEW59t5V5HjhclKf4cUuJ1BhcaqQ/53rryhg2tMHkz674AoJ/C0hVQ==", null, false, "0dbe25bf-6e41-4894-8e79-9d7f100993b2", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Name", "categpry_Description" },
                values: new object[] { "e21a4c32-261c-4bca-b7da-c9c24281e523", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "category_Name", "category_Description" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e0bce046-dbaa-4693-a0fe-0d4f134f6470", "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29" },
                    { "19e97f82-bfc2-4b8d-b498-8c074b89a90d", "ec647bb9-2988-4ff3-9242-00872eeb0241" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "09129eb4-63e3-4512-b74b-5ed0b0b2d9df", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29" },
                    { "4fdea10c-54e8-4f0a-8140-adc09c122c64", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29" },
                    { "5dec2539-4a78-4273-8248-c0788d91f2bf", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", 1, 0.0, "", "", "", "", "", "ec647bb9-2988-4ff3-9242-00872eeb0241" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "434c970d-79a2-4d97-b458-b7cc685c1cba", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "e21a4c32-261c-4bca-b7da-c9c24281e523", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0bce046-dbaa-4693-a0fe-0d4f134f6470", "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19e97f82-bfc2-4b8d-b498-8c074b89a90d", "ec647bb9-2988-4ff3-9242-00872eeb0241" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "09129eb4-63e3-4512-b74b-5ed0b0b2d9df");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "4fdea10c-54e8-4f0a-8140-adc09c122c64");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "5dec2539-4a78-4273-8248-c0788d91f2bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "434c970d-79a2-4d97-b458-b7cc685c1cba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e97f82-bfc2-4b8d-b498-8c074b89a90d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0bce046-dbaa-4693-a0fe-0d4f134f6470");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3e849c6-8b5e-49fc-9410-ed8c7fd58c29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec647bb9-2988-4ff3-9242-00872eeb0241");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "e21a4c32-261c-4bca-b7da-c9c24281e523");

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
    }
}
