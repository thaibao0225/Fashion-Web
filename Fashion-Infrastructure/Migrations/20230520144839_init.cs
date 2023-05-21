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
                    category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    size_Name = table.Column<int>(type: "int", nullable: false),
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
                    bill_Price = table.Column<double>(type: "float", nullable: false),
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
                    contact_Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_IsCheck = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Cart",
                columns: table => new
                {
                    cart_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_SizeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_ColorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => new { x.cart_ProductId, x.cart_SizeId, x.cart_ColorId, x.cart_UserId });
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_cart_UserId",
                        column: x => x.cart_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Color_cart_ColorId",
                        column: x => x.cart_ColorId,
                        principalTable: "Color",
                        principalColumn: "color_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Products_cart_ProductId",
                        column: x => x.cart_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Size_cart_SizeId",
                        column: x => x.cart_SizeId,
                        principalTable: "Size",
                        principalColumn: "size_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorInProduct",
                columns: table => new
                {
                    cip_ColorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cip_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cip_QuantityExisting = table.Column<int>(type: "int", nullable: false),
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
                    comment_Rating = table.Column<int>(type: "int", nullable: false),
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
                    sip_QuantityExisting = table.Column<int>(type: "int", nullable: false),
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
                    { "23ef6958-1dd0-455a-af82-0c785c518ca0", "f3d357c0-2a41-4244-acbb-8d0a48e50619", "RolesTable", false, "Admin", "admin" },
                    { "2743ed89-9ed5-4116-b273-25809423253e", "d288540d-35e2-4e7e-8b54-1027c8889775", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2de0a5e9-7b52-47a7-9514-e0416a287319", 0, "", "215b0df6-4f72-4e65-b438-c0119857f486", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEEuB2NUxpCTwIo0tzHqD/f7YcWcXB0C67doONOgeJizme8A4CTJTUsB5f7SIBFogVw==", null, false, "63bff0f5-fdc5-45a8-9577-09b29a90203a", false, "Staff" },
                    { "4ca7175d-be33-436b-a9a1-2355d1d1a6ca", 0, "", "04cf6b5b-4e8b-473d-acdf-ae546946087f", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPRmZEUDIrMDn/d6wbrnliISRjKBPUimR9DMbt3uByDw5Kj5sRkXbkgq/Myc/uL4IA==", null, false, "a9a12b51-944b-4afd-80e1-a635d0c21815", false, "Admin" },
                    { "f6d06a0f-8a3e-4153-a808-436390921b2c", 0, "", "cc5d0c1e-17bd-45f9-be97-af222de2f6bd", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAENL+mXhnz0jK5eXJONgCAoULx7kSso7Gu5M+sScRX0ZvA3CcSF2X7NuEwzjP1vxfQQ==", null, false, "40541526-8ac3-4ffc-ac5d-429260d7e581", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "06a7cca4-d12e-4d76-80f4-520c0e9bff54", null, null, false, null, null, "", "For Her" },
                    { "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", null, null, false, null, null, "", "Air Jordan 1" },
                    { "2285c3e6-2683-460c-9835-9ee8a92a2ec6", null, null, false, null, null, "", "NMD" },
                    { "49038d20-c676-41ea-8b75-8d3e04e80dd5", null, null, false, null, null, "", "Air Force 1" },
                    { "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", null, null, false, null, null, "", "Yeezy" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "0efc3fed-8426-4164-953b-407781d269ea", false, "Yellow" },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", false, "Black" },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", false, "Red" },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", false, "Green" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "10e1f121-bd85-415a-9494-aa646d41ed22", "test@gmail.com", false },
                    { "743d8a4a-929f-4f1b-8849-17380d0186a9", "test@gmail.com", false },
                    { "79eea8bd-d0a2-43b4-a6b4-8e160c9ced7c", "test@gmail.com", false },
                    { "ea09da26-a9dd-46a1-8c5f-527b16389106", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", false, 36 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", false, 35 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", false, 39 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", false, 35 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", false, 37 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", false, 38 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23ef6958-1dd0-455a-af82-0c785c518ca0", "2de0a5e9-7b52-47a7-9514-e0416a287319" },
                    { "2743ed89-9ed5-4116-b273-25809423253e", "4ca7175d-be33-436b-a9a1-2355d1d1a6ca" },
                    { "23ef6958-1dd0-455a-af82-0c785c518ca0", "f6d06a0f-8a3e-4153-a808-436390921b2c" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "70a62612-753d-40d3-a489-0db5c815ea2a", "", new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, "", new DateTime(2023, 5, 20, 21, 48, 38, 878, DateTimeKind.Local).AddTicks(3360), 1, new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9|a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f|e56060a7-e767-4c02-9be9-57e418adbfa9|1187d075-4509-477c-b581-0b390b94ee1e|", "4ca7175d-be33-436b-a9a1-2355d1d1a6ca" },
                    { "80a0ebf9-669c-4a1f-9699-a944b514d25d", "", new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, "", new DateTime(2023, 5, 20, 21, 48, 38, 878, DateTimeKind.Local).AddTicks(3360), 1, new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865|8206c978-f5b3-47d9-99dc-8ccd3743c223|bf99d534-6c07-4237-98f5-e227fc588c02|77c56164-a84c-4bf6-84eb-80aa6ec73dbd|", "f6d06a0f-8a3e-4153-a808-436390921b2c" },
                    { "e195fa79-0a6a-4757-9760-eca39c5fc7c6", "", new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, "", new DateTime(2023, 5, 20, 21, 48, 38, 878, DateTimeKind.Local).AddTicks(3360), 1, new DateTime(2023, 5, 20, 21, 48, 38, 876, DateTimeKind.Local).AddTicks(7039), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "43e21008-2880-4b92-8b6b-b1d52da30822|bd06818d-fe96-424b-bf54-bcb77818db0a|521e061d-e3bd-4a62-8bf2-60e402568b64|44a1f469-cd44-4fe8-93f5-de408cebe98d|", "2de0a5e9-7b52-47a7-9514-e0416a287319" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "01460246-5f65-451f-8cb5-636fe37613bd", null, null, false, null, null, "743d8a4a-929f-4f1b-8849-17380d0186a9", true, "Message", "Name", "Subject" },
                    { "57d70dec-9a9c-43e9-8dad-51d6de9fc986", null, null, false, null, null, "ea09da26-a9dd-46a1-8c5f-527b16389106", false, "Message", "Name", "Subject" },
                    { "7c943869-699e-471c-acc6-937c60a42eae", null, null, false, null, null, "79eea8bd-d0a2-43b4-a6b4-8e160c9ced7c", false, "Message", "Name", "Subject" },
                    { "8b5d454a-f0d9-4e37-b532-b34bb9550e41", null, null, false, null, null, "10e1f121-bd85-415a-9494-aa646d41ed22", false, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "065ffba3-afa4-4887-8435-b750075ada82", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "0f819265-61ea-4ff1-a36c-243efe411e11", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "1187d075-4509-477c-b581-0b390b94ee1e", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "43e21008-2880-4b92-8b6b-b1d52da30822", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "44a1f469-cd44-4fe8-93f5-de408cebe98d", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "521e061d-e3bd-4a62-8bf2-60e402568b64", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "55d4a585-1f6f-499d-91e9-9b5c66bcc020", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "80648e0d-8d0e-43cc-b59b-33393c6ddc81", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "8206c978-f5b3-47d9-99dc-8ccd3743c223", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "8469035e-df7f-4e9e-aa05-39dee2a4f59f", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "910cce67-3780-4b6a-9687-41c13c87db35", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "9286ba6d-f90b-4a07-890a-3257fc62b3c2", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "9aedacf4-f543-4a3b-8f2b-2a5fac2f645e", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "9d6cfd8d-c09e-450a-9875-3d29b5eb503a", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "b3f5776d-4ea6-426a-89e6-1087386aec0a", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "bd06818d-fe96-424b-bf54-bcb77818db0a", null, null, false, null, null, "0c1b2987-c9b4-4922-bb8e-3b02f3edb606", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "bf99d534-6c07-4237-98f5-e227fc588c02", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "c86e0c28-7c6e-4364-863a-336c0e2777d3", null, null, false, null, null, "2285c3e6-2683-460c-9835-9ee8a92a2ec6", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "e531fa67-a091-4eef-af46-82513dc81f6a", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "e56060a7-e767-4c02-9be9-57e418adbfa9", null, null, false, null, null, "49038d20-c676-41ea-8b75-8d3e04e80dd5", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "ebf20011-a781-4a02-a386-739dd47944a5", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "f40056d1-a362-4ef5-af90-c67db83389da", null, null, false, null, null, "f05870cd-25bc-4762-ac2c-d76d98bc3a5d", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "f707d577-b145-4757-9534-dfa75c82be22", null, null, false, null, null, "06a7cca4-d12e-4d76-80f4-520c0e9bff54", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "0efc3fed-8426-4164-953b-407781d269ea", "065ffba3-afa4-4887-8435-b750075ada82", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "0f819265-61ea-4ff1-a36c-243efe411e11", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "55d4a585-1f6f-499d-91e9-9b5c66bcc020", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "8469035e-df7f-4e9e-aa05-39dee2a4f59f", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "910cce67-3780-4b6a-9687-41c13c87db35", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "9286ba6d-f90b-4a07-890a-3257fc62b3c2", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "9aedacf4-f543-4a3b-8f2b-2a5fac2f645e", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "9d6cfd8d-c09e-450a-9875-3d29b5eb503a", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "b3f5776d-4ea6-426a-89e6-1087386aec0a", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "c86e0c28-7c6e-4364-863a-336c0e2777d3", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "ebf20011-a781-4a02-a386-739dd47944a5", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "0efc3fed-8426-4164-953b-407781d269ea", "f707d577-b145-4757-9534-dfa75c82be22", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "065ffba3-afa4-4887-8435-b750075ada82", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "0f819265-61ea-4ff1-a36c-243efe411e11", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "55d4a585-1f6f-499d-91e9-9b5c66bcc020", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "8469035e-df7f-4e9e-aa05-39dee2a4f59f", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "910cce67-3780-4b6a-9687-41c13c87db35", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "9286ba6d-f90b-4a07-890a-3257fc62b3c2", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "9aedacf4-f543-4a3b-8f2b-2a5fac2f645e", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "9d6cfd8d-c09e-450a-9875-3d29b5eb503a", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "b3f5776d-4ea6-426a-89e6-1087386aec0a", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "c86e0c28-7c6e-4364-863a-336c0e2777d3", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "ebf20011-a781-4a02-a386-739dd47944a5", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "45ec5d71-eb90-413c-8b89-580fbdf7cb0e", "f707d577-b145-4757-9534-dfa75c82be22", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "065ffba3-afa4-4887-8435-b750075ada82", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "0f819265-61ea-4ff1-a36c-243efe411e11", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "55d4a585-1f6f-499d-91e9-9b5c66bcc020", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "8469035e-df7f-4e9e-aa05-39dee2a4f59f", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "910cce67-3780-4b6a-9687-41c13c87db35", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "9286ba6d-f90b-4a07-890a-3257fc62b3c2", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "9aedacf4-f543-4a3b-8f2b-2a5fac2f645e", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "9d6cfd8d-c09e-450a-9875-3d29b5eb503a", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "b3f5776d-4ea6-426a-89e6-1087386aec0a", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "c86e0c28-7c6e-4364-863a-336c0e2777d3", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "ebf20011-a781-4a02-a386-739dd47944a5", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "84ddbcbf-eee1-4fae-8461-d52626bef9be", "f707d577-b145-4757-9534-dfa75c82be22", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "065ffba3-afa4-4887-8435-b750075ada82", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "0f819265-61ea-4ff1-a36c-243efe411e11", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "55d4a585-1f6f-499d-91e9-9b5c66bcc020", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "8469035e-df7f-4e9e-aa05-39dee2a4f59f", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "910cce67-3780-4b6a-9687-41c13c87db35", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "9286ba6d-f90b-4a07-890a-3257fc62b3c2", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "9aedacf4-f543-4a3b-8f2b-2a5fac2f645e", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "9d6cfd8d-c09e-450a-9875-3d29b5eb503a", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "b3f5776d-4ea6-426a-89e6-1087386aec0a", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "c86e0c28-7c6e-4364-863a-336c0e2777d3", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "ebf20011-a781-4a02-a386-739dd47944a5", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "d4c88363-eb0e-4eda-bc23-3faf9f233efa", "f707d577-b145-4757-9534-dfa75c82be22", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Rating", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "553cf197-54cb-40b2-a947-2025c73d03b9", null, null, false, null, null, "bd06818d-fe96-424b-bf54-bcb77818db0a", 0, "Test comment", "2de0a5e9-7b52-47a7-9514-e0416a287319" },
                    { "66162a92-2cce-4e83-86b6-4a38fc1cfe0c", null, null, false, null, null, "43e21008-2880-4b92-8b6b-b1d52da30822", 0, "Test comment", "2de0a5e9-7b52-47a7-9514-e0416a287319" },
                    { "8c30a2ab-471c-41f5-b833-2e66984d1275", null, null, false, null, null, "43e21008-2880-4b92-8b6b-b1d52da30822", 0, "Test comment", "f6d06a0f-8a3e-4153-a808-436390921b2c" },
                    { "b9f71b07-5bda-4206-8b8f-6489409b5c1c", null, null, false, null, null, "43e21008-2880-4b92-8b6b-b1d52da30822", 0, "Test comment", "4ca7175d-be33-436b-a9a1-2355d1d1a6ca" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "1b08dc53-2244-4fb4-a379-4f780d4ffeb1", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "2daf683a-6817-4aeb-be2f-605d707d905f", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "3b5d50c6-f0d5-42c7-aad1-2b02eb60bd1b", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "93cbe2e9-3105-4d66-a3bc-c8b8a407db96", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "a4aa4ea5-01a5-42f4-8b2b-aec1444155d2", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "1187d075-4509-477c-b581-0b390b94ee1e", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "394fc5f9-c1bc-4168-9a4a-ac86cd704c12", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "3f45fffd-9aa4-4d3c-a87b-fab31144d5fe", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "43e21008-2880-4b92-8b6b-b1d52da30822", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "44a1f469-cd44-4fe8-93f5-de408cebe98d", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "521e061d-e3bd-4a62-8bf2-60e402568b64", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "77c56164-a84c-4bf6-84eb-80aa6ec73dbd", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "80648e0d-8d0e-43cc-b59b-33393c6ddc81", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "8206c978-f5b3-47d9-99dc-8ccd3743c223", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "82dd8a9b-95c2-4011-936c-b4b73ba07fe9", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "a5f4895e-ff3e-4b6c-911f-6ff1e73b9b3f", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "baeae34f-ab64-4347-bc6c-16e2ce7c47f3", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "bd06818d-fe96-424b-bf54-bcb77818db0a", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "bf99d534-6c07-4237-98f5-e227fc588c02", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "d4bcbee0-c9fe-4c51-a115-46f5eaa25865", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "e531fa67-a091-4eef-af46-82513dc81f6a", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "e56060a7-e767-4c02-9be9-57e418adbfa9", false, 10 },
                    { "d1def05f-e4f6-4a6e-ad20-7afdb2820170", "f40056d1-a362-4ef5-af90-c67db83389da", false, 10 }
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
                name: "IX_Cart_cart_ColorId",
                table: "Cart",
                column: "cart_ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_cart_SizeId",
                table: "Cart",
                column: "cart_SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_cart_UserId",
                table: "Cart",
                column: "cart_UserId");

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
                name: "Cart");

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
