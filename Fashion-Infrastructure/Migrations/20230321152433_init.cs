using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    color_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    color_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color_IdDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.color_Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailCustomer",
                columns: table => new
                {
                    emailC_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    emailC_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailC_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailCustomer", x => x.emailC_Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    size_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    size_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    size_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.size_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_Code = table.Column<int>(type: "int", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_Price = table.Column<int>(type: "int", nullable: false),
                    bill_ProductsIdList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductPriceList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductUnitList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductColorList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductSizeList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_IsConfirm = table.Column<bool>(type: "bit", nullable: false),
                    bill_IsPayment = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Img5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Price = table.Column<double>(type: "float", nullable: false),
                    product_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Sold = table.Column<int>(type: "int", nullable: true),
                    product_Rate = table.Column<int>(type: "int", nullable: true),
                    product_ViewNumber = table.Column<int>(type: "int", nullable: true),
                    product_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_product_CategoryId",
                        column: x => x.product_CategoryId,
                        principalTable: "Categories",
                        principalColumn: "category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    contact_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_EmailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    emailC_Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailC_Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailC_IsCheck = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.contact_Id);
                    table.ForeignKey(
                        name: "FK_Contact_EmailCustomer_contact_EmailId",
                        column: x => x.contact_EmailId,
                        principalTable: "EmailCustomer",
                        principalColumn: "emailC_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorInProduct",
                columns: table => new
                {
                    cip_ColorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cip_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cip_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorInProduct", x => new { x.cip_ColorId, x.cip_ProductId });
                    table.ForeignKey(
                        name: "FK_ColorInProduct_Color_cip_ColorId",
                        column: x => x.cip_ColorId,
                        principalTable: "Color",
                        principalColumn: "color_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorInProduct_Products_cip_ProductId",
                        column: x => x.cip_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    comment_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    comment_Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comment_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    comment_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.comment_Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_comment_UserId",
                        column: x => x.comment_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Products_comment_ProductId",
                        column: x => x.comment_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SizeInProduct",
                columns: table => new
                {
                    sip_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sip_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sip_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeInProduct", x => new { x.sip_Id, x.sip_ProductId });
                    table.ForeignKey(
                        name: "FK_SizeInProduct_Products_sip_ProductId",
                        column: x => x.sip_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeInProduct_Size_sip_Id",
                        column: x => x.sip_Id,
                        principalTable: "Size",
                        principalColumn: "size_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31bd0872-e289-4a8f-96fb-a0b7fc5bfb80", "990266ce-ea2b-494d-aebb-10ceeca3a9b1", "RolesTable", false, "Admin", "admin" },
                    { "ecc2b10f-36a9-465b-90d6-e7a3ab3d4522", "91f829b8-fe4c-499f-a51a-5a45f50e3eb9", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69420e08-6de1-4ffe-a733-f32ff388847b", 0, "", "adf341b5-b4a0-4a0d-b42a-16fa8dd78fce", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN7SA5jDKOz+2qsHCSmHdi0r2KmcV4H8Rzj7SDWk31buIjPpvVxZEFW+AItLetw3/g==", null, false, "cb0471fa-a6bc-4770-a420-633586d9c3ca", false, "Admin" },
                    { "d5f3b54e-c721-4b91-8135-01a2e7191a92", 0, "", "5a675c82-b4d4-460d-bb71-6752e1ea8c7b", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAECwG5tJVGQoRItGfzBgoJHZy7DmvLncF1FpiZD4F28SvjQ2C9ss2l/lP4EMPSrBVyQ==", null, false, "cb7c7843-9549-41ed-8cae-b406509975ea", false, "Staft" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", null, null, false, null, null, "", false, "NMD" },
                    { "70384946-c313-4edf-b98a-66ed223b2168", null, null, false, null, null, "", false, "For Her" },
                    { "a0d4702b-d615-40b1-ac8e-3709755fec96", null, null, false, null, null, "", false, "Air Force 1" },
                    { "a871d64f-fb05-4a24-b60d-225c07575f0a", null, null, false, null, null, "", false, "Yeezy" },
                    { "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", null, null, false, null, null, "", false, "Air Jordan 1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ecc2b10f-36a9-465b-90d6-e7a3ab3d4522", "69420e08-6de1-4ffe-a733-f32ff388847b" },
                    { "31bd0872-e289-4a8f-96fb-a0b7fc5bfb80", "d5f3b54e-c721-4b91-8135-01a2e7191a92" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "088a0124-3569-4c1f-a896-2dde6aab9e75", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "0e847f0e-2c7c-41ca-a704-78536b5f8ef8", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "0fa1c2ff-d765-468a-8fd5-419b4dbbdc1b", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "13e053e3-da04-4fc0-84ad-3ebfbd42e11f", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "216dc317-0b19-4a65-bd0e-4e1a5fe95932", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "2fdff5bb-64a9-49b0-86a9-dddaa7c0aa1a", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "3690f375-a3f0-42cc-9b53-9e29ae4f3bb1", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "38ba1e10-fb63-4a19-984b-061b5b3e3f8b", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "406c5592-c009-460c-8901-5819ff1347ab", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "41dc43f6-b300-4c15-bda8-14fd283bb534", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "423b7b9f-07a5-4d46-80a2-c095b1c6cc5f", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "44dc4584-2a09-4c38-a125-355be34ae44c", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "4e07c925-1793-4c60-9a06-92cd484870d7", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "53aa7691-ef7c-4e29-9b57-360035eee347", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "54f2ba97-25e9-45fd-87ab-a736318718ce", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "574b85d2-195c-4f49-a0ce-04e6de1e3beb", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "74756599-e683-4987-87dd-cb003d09dd31", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "7acc888a-116d-4773-ae5f-430aa8a8354a", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "8b49901b-f441-4373-b525-57b24923b65a", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "8dc1e2a3-4d9f-4810-beee-a7432cb4050b", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "9f92f5b4-9005-4a27-9fbe-631c9a111c89", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "c436989b-45fd-4b29-bbfe-1c2865f2af1a", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "c5cc27f3-5092-49f4-8047-bd2aad9627d9", null, null, false, null, null, "3f8c8a3b-0ab2-4e19-87b7-c3d89cd24e2d", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "ccdbd6e4-a134-4cdf-a2fb-c320735cc534", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "dec0fff8-0e8c-4b43-8594-4bf86a49393c", null, null, false, null, null, "a0d4702b-d615-40b1-ac8e-3709755fec96", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "dec7576d-36ef-4bde-b98f-9283e1d96881", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "e3bcee6d-1992-45af-b02b-4cb0fbab41a4", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "e4fe45ce-1f9e-4e32-b769-b15cb828bcfc", null, null, false, null, null, "a871d64f-fb05-4a24-b60d-225c07575f0a", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "f3908318-4fae-4d84-b79f-7b63753de07b", null, null, false, null, null, "bc01668e-651a-4ce5-8d3f-cce35ea7e2b2", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "fcab161d-73e6-4617-b60d-190a002d50c3", null, null, false, null, null, "70384946-c313-4edf-b98a-66ed223b2168", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorInProduct_cip_ProductId",
                table: "ColorInProduct",
                column: "cip_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_comment_ProductId",
                table: "Comment",
                column: "comment_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_comment_UserId",
                table: "Comment",
                column: "comment_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_contact_EmailId",
                table: "Contact",
                column: "contact_EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_CategoryId",
                table: "Products",
                column: "product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeInProduct_sip_ProductId",
                table: "SizeInProduct",
                column: "sip_ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ColorInProduct");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "SizeInProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EmailCustomer");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
