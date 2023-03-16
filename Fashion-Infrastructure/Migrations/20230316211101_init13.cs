using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a59dda07-5e20-4c51-a73b-fb2956aad1cc", "02dc8bc9-3dcc-4626-873c-f4fb6d8a818c", "RolesTable", false, "Staff", "staff" },
                    { "b4cbc620-ce27-4a6e-a5ba-e0bb50fae60e", "e10a76d2-21c4-4307-90ef-f274caff536d", "RolesTable", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "849d3d63-d2b3-4850-b3e8-b307f99bf9b9", 0, "", "954ae93d-3d4c-4c68-b4bb-ce864ca0f727", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFTE/GECieB3ChgMBBnmm3u720OUNYPg5ORC4Mr9KekKnpZYY8ahljmSTBSOqkd5Iw==", null, false, "6412787d-76cb-40b1-b108-43ae856b3139", false, "Admin" },
                    { "9fe4b0e8-9381-4859-aecf-15f25277dace", 0, "", "d77e734a-c5c7-4bc1-88a6-860e99914091", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEN+oslmtxZMoPPc1ngHa5QOSzp0c2KYDJB4jof9ppmffL1KKtDnAxx+qlY1OPK6xcA==", null, false, "beda6ae2-11ab-4193-b128-266c200840ce", false, "Staft" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "5e4d375b-9bd6-484c-9591-015e751704b1", null, null, false, null, null, "", false, "category_Name2" },
                    { "70bc00d9-b541-4e48-a066-2aea81a18c04", null, null, false, null, null, "", false, "category_Name1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a59dda07-5e20-4c51-a73b-fb2956aad1cc", "849d3d63-d2b3-4850-b3e8-b307f99bf9b9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b4cbc620-ce27-4a6e-a5ba-e0bb50fae60e", "9fe4b0e8-9381-4859-aecf-15f25277dace" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "b2536e58-654a-4154-9681-c6784a7c294f", "", new DateTime(2023, 3, 17, 4, 11, 0, 626, DateTimeKind.Local).AddTicks(5560), false, "", new DateTime(2023, 3, 17, 4, 11, 0, 627, DateTimeKind.Local).AddTicks(5855), "70bc00d9-b541-4e48-a066-2aea81a18c04", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a59dda07-5e20-4c51-a73b-fb2956aad1cc", "849d3d63-d2b3-4850-b3e8-b307f99bf9b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4cbc620-ce27-4a6e-a5ba-e0bb50fae60e", "9fe4b0e8-9381-4859-aecf-15f25277dace" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "5e4d375b-9bd6-484c-9591-015e751704b1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "b2536e58-654a-4154-9681-c6784a7c294f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a59dda07-5e20-4c51-a73b-fb2956aad1cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4cbc620-ce27-4a6e-a5ba-e0bb50fae60e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "849d3d63-d2b3-4850-b3e8-b307f99bf9b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fe4b0e8-9381-4859-aecf-15f25277dace");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "70bc00d9-b541-4e48-a066-2aea81a18c04");
        }
    }
}
