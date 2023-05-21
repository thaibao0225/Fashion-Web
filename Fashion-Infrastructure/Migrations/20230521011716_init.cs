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
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { "98693005-95d6-46e9-86f2-3b6bcf2dade4", "858dffce-8e2d-43b4-91d9-e6b6811a7a8c", "RolesTable", false, "Staff", "staff" },
                    { "fafb28e0-acaa-48ee-9406-d2b57d82fe53", "19560049-53e5-435b-b46e-be50376e712a", "RolesTable", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_City", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "7e009de6-4369-4592-b3d3-3416eb3fddfa", 0, "", "c7183acb-133b-452b-9d12-2707e2004bfe", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEHUD47KaL0T9VjZ/QbSVcXGc2GA7QlJwDHkG+yiP/DuGXgUk2wWyGrVIJr+vyM1oLA==", null, false, "ce41fcaf-de74-47e3-bfcc-c31a355d276e", false, "Staff", "", "", "", "" },
                    { "8783bc54-da00-4f68-be7d-8f9b58d9098d", 0, "", "5b14c723-00ea-47ae-bc2d-70e58647b66c", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEFeZsG+2UJaBP4AAgqonOoyJhtGVawuWLo8QW5rKFm26MGkSOfe9m6ohk+OgvE5BZw==", null, false, "49482af3-c3e2-47da-91e8-d5a778ddd179", false, "Staff2", "", "", "", "" },
                    { "cc9cbd95-c450-4be3-8520-7192231dda7c", 0, "", "db7917de-196b-40d8-8b6e-c34d6c858a29", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDQtAOK/17+4tsfq6OwaKYciXcMy6Z2iegW7iyXK5eE7ERhOxQ8IKFTbyBFoFPHeOw==", null, false, "05d7019f-31b7-45f9-a016-c4910a72d3d6", false, "Admin", "", "", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", null, null, false, null, null, "", "Air Force 1" },
                    { "51f78701-e664-40d0-a227-9889f1332edf", null, null, false, null, null, "", "NMD" },
                    { "56746880-1573-4d4e-be1c-615c6d09e7da", null, null, false, null, null, "", "For Her" },
                    { "aa11e5b5-8039-4a35-ae35-b14cebda006f", null, null, false, null, null, "", "Yeezy" },
                    { "e13432b8-02d8-498c-872f-8532aba1bad5", null, null, false, null, null, "", "Air Jordan 1" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", false, "Green" },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", false, "Yellow" },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", false, "Red" },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", false, "Black" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "0f78289c-250e-4c83-8664-a622a5deb4c0", "test@gmail.com", false },
                    { "1ea13671-6d16-460f-9fa1-c89aa531af34", "test@gmail.com", false },
                    { "94197e0f-ba6e-4052-936c-a787cecbade0", "test@gmail.com", false },
                    { "f897a31c-2f04-4f4e-8d1f-e36fce900452", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", false, 35 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", false, 36 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", false, 39 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", false, 35 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", false, 38 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", false, 37 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fafb28e0-acaa-48ee-9406-d2b57d82fe53", "7e009de6-4369-4592-b3d3-3416eb3fddfa" },
                    { "fafb28e0-acaa-48ee-9406-d2b57d82fe53", "8783bc54-da00-4f68-be7d-8f9b58d9098d" },
                    { "98693005-95d6-46e9-86f2-3b6bcf2dade4", "cc9cbd95-c450-4be3-8520-7192231dda7c" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "2d847706-4627-421e-86d2-a3a1bca88849", "", new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, "", new DateTime(2023, 5, 21, 8, 17, 15, 724, DateTimeKind.Local).AddTicks(7164), 1, new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2|f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80|6d811828-9a47-4de6-ac92-0b01fb477114|127369d9-df6b-4a4e-b5fe-e54ccc71fa14|", "cc9cbd95-c450-4be3-8520-7192231dda7c" },
                    { "3a8a27a5-4741-4adb-ad90-32e4b28fbce8", "", new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, "", new DateTime(2023, 5, 21, 8, 17, 15, 724, DateTimeKind.Local).AddTicks(7164), 1, new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "d3b1d614-31e9-4ca4-bc7c-831adef315ef|19166038-67b7-4ce1-a3fe-39cc45ae7894|7169fec9-90cc-4444-8459-3c8c75b9116f|13ede3f9-6c8c-41b0-848d-09ca8b503e7d|", "8783bc54-da00-4f68-be7d-8f9b58d9098d" },
                    { "a595f3d4-f955-4da8-a74c-7dd2ef6ac724", "", new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, "", new DateTime(2023, 5, 21, 8, 17, 15, 724, DateTimeKind.Local).AddTicks(7164), 1, new DateTime(2023, 5, 21, 8, 17, 15, 723, DateTimeKind.Local).AddTicks(5608), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "e8ae3441-7a31-458e-a9ed-04643395dcb3|e930ef61-f142-4fb1-842e-d865344fd059|59fe4f3a-4cc8-4568-9274-9d29f34b88f2|6e9d607b-c1f3-4f18-940d-797abd020639|", "7e009de6-4369-4592-b3d3-3416eb3fddfa" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "6c396e32-7b94-421a-a397-f5df4479373d", null, null, false, null, null, "f897a31c-2f04-4f4e-8d1f-e36fce900452", false, "Message", "Name", "Subject" },
                    { "734b5327-9f78-4ca2-b12b-8938baad6b73", null, null, false, null, null, "94197e0f-ba6e-4052-936c-a787cecbade0", false, "Message", "Name", "Subject" },
                    { "d3db0683-0c31-4ebf-b37b-014fe23fd0a0", null, null, false, null, null, "0f78289c-250e-4c83-8664-a622a5deb4c0", false, "Message", "Name", "Subject" },
                    { "fbc17ce1-f6bb-45b8-a410-13fe758ff965", null, null, false, null, null, "1ea13671-6d16-460f-9fa1-c89aa531af34", true, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "00b4d222-d8b1-4e9d-8b0c-846f76c3f170", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "07072229-0f6b-49fd-a278-a8c26b6ee39f", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "0882671a-8a36-4796-989b-af623b756d19", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "19166038-67b7-4ce1-a3fe-39cc45ae7894", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "348827a4-cda1-4ce7-b714-0e1c623c4720", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "353e5b9e-bab6-4f46-9b07-91963eb3d8ea", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "4db46d82-a747-415a-8546-f501ddf6802e", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "56c2e70b-a52d-4844-8727-9df16971bd26", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "6d811828-9a47-4de6-ac92-0b01fb477114", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "6e9d607b-c1f3-4f18-940d-797abd020639", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "7169fec9-90cc-4444-8459-3c8c75b9116f", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "732f0a73-8f42-4d49-9436-05344a5cec8a", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "7ebfe6cd-ff1f-43f0-8f46-bd0810dec56b", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "87d660c3-65fa-45fa-b1e5-b36184b35293", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "8e666905-f699-4600-968a-c492a270f49f", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "a241bf0f-0e2a-498f-b509-674c0b71e43a", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "ac3b865f-03e7-48d5-b7ee-fa897b707441", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "ca74e3ad-45b8-4b34-8cba-daba0fe4c902", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "d3b1d614-31e9-4ca4-bc7c-831adef315ef", null, null, false, null, null, "14c0a13c-63a8-4b4b-9085-9c7df0d90c1e", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "d61358a0-8e56-4a73-b36c-c46c015a8a87", null, null, false, null, null, "56746880-1573-4d4e-be1c-615c6d09e7da", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "de2251bc-fce0-4969-93cc-69538fc4239e", null, null, false, null, null, "51f78701-e664-40d0-a227-9889f1332edf", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "e8ae3441-7a31-458e-a9ed-04643395dcb3", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "e930ef61-f142-4fb1-842e-d865344fd059", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", null, null, false, null, null, "e13432b8-02d8-498c-872f-8532aba1bad5", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", null, null, false, null, null, "aa11e5b5-8039-4a35-ae35-b14cebda006f", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "00b4d222-d8b1-4e9d-8b0c-846f76c3f170", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "07072229-0f6b-49fd-a278-a8c26b6ee39f", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "0882671a-8a36-4796-989b-af623b756d19", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "348827a4-cda1-4ce7-b714-0e1c623c4720", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "353e5b9e-bab6-4f46-9b07-91963eb3d8ea", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "56c2e70b-a52d-4844-8727-9df16971bd26", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "7ebfe6cd-ff1f-43f0-8f46-bd0810dec56b", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "8e666905-f699-4600-968a-c492a270f49f", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "a241bf0f-0e2a-498f-b509-674c0b71e43a", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "ca74e3ad-45b8-4b34-8cba-daba0fe4c902", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "d61358a0-8e56-4a73-b36c-c46c015a8a87", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "de2251bc-fce0-4969-93cc-69538fc4239e", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "2c8512d6-c6e1-4526-b2f7-9f58584b1212", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "00b4d222-d8b1-4e9d-8b0c-846f76c3f170", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "07072229-0f6b-49fd-a278-a8c26b6ee39f", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "0882671a-8a36-4796-989b-af623b756d19", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "348827a4-cda1-4ce7-b714-0e1c623c4720", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "353e5b9e-bab6-4f46-9b07-91963eb3d8ea", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "56c2e70b-a52d-4844-8727-9df16971bd26", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "7ebfe6cd-ff1f-43f0-8f46-bd0810dec56b", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "8e666905-f699-4600-968a-c492a270f49f", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "a241bf0f-0e2a-498f-b509-674c0b71e43a", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "ca74e3ad-45b8-4b34-8cba-daba0fe4c902", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "d61358a0-8e56-4a73-b36c-c46c015a8a87", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "de2251bc-fce0-4969-93cc-69538fc4239e", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "343ed8f2-c2fa-438c-baad-c69749342cc9", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "00b4d222-d8b1-4e9d-8b0c-846f76c3f170", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "07072229-0f6b-49fd-a278-a8c26b6ee39f", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "0882671a-8a36-4796-989b-af623b756d19", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "348827a4-cda1-4ce7-b714-0e1c623c4720", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "353e5b9e-bab6-4f46-9b07-91963eb3d8ea", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "56c2e70b-a52d-4844-8727-9df16971bd26", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "7ebfe6cd-ff1f-43f0-8f46-bd0810dec56b", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "8e666905-f699-4600-968a-c492a270f49f", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "a241bf0f-0e2a-498f-b509-674c0b71e43a", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "ca74e3ad-45b8-4b34-8cba-daba0fe4c902", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "d61358a0-8e56-4a73-b36c-c46c015a8a87", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "de2251bc-fce0-4969-93cc-69538fc4239e", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "630b439d-55c9-449f-980a-61b5df3dc363", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "00b4d222-d8b1-4e9d-8b0c-846f76c3f170", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "07072229-0f6b-49fd-a278-a8c26b6ee39f", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "0882671a-8a36-4796-989b-af623b756d19", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "348827a4-cda1-4ce7-b714-0e1c623c4720", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "353e5b9e-bab6-4f46-9b07-91963eb3d8ea", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "56c2e70b-a52d-4844-8727-9df16971bd26", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "7ebfe6cd-ff1f-43f0-8f46-bd0810dec56b", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "8e666905-f699-4600-968a-c492a270f49f", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "a241bf0f-0e2a-498f-b509-674c0b71e43a", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "ca74e3ad-45b8-4b34-8cba-daba0fe4c902", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "d61358a0-8e56-4a73-b36c-c46c015a8a87", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "de2251bc-fce0-4969-93cc-69538fc4239e", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "6f538033-4b0c-40ad-b009-ed532834dfb5", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Rating", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "8d64b71b-faf7-4c6d-8f3a-cb53f20e8292", null, null, false, null, null, "e8ae3441-7a31-458e-a9ed-04643395dcb3", 0, "Test comment", "cc9cbd95-c450-4be3-8520-7192231dda7c" },
                    { "a61e7c26-ed32-4eec-a348-555c86e3daf0", null, null, false, null, null, "e8ae3441-7a31-458e-a9ed-04643395dcb3", 0, "Test comment", "8783bc54-da00-4f68-be7d-8f9b58d9098d" },
                    { "b1736f83-a165-495c-a2a1-d8ebe7bc576b", null, null, false, null, null, "e8ae3441-7a31-458e-a9ed-04643395dcb3", 0, "Test comment", "7e009de6-4369-4592-b3d3-3416eb3fddfa" },
                    { "d15af4ec-aec0-441e-939d-3c08afe46c91", null, null, false, null, null, "e930ef61-f142-4fb1-842e-d865344fd059", 0, "Test comment", "7e009de6-4369-4592-b3d3-3416eb3fddfa" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "28d651bf-17bc-479a-9c3b-94b6d5310bf6", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "477b6b80-a1c8-43cb-abc4-629d2e3e6965", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "57bced4a-b6d4-46c9-8ed9-6377c4f9ad67", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "675f33ad-ebb3-476e-b2e5-028bccec0720", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "8b840731-e7cd-4a76-9c12-e21b0c1832ae", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "0dcbc94d-9f21-4c90-b9e7-ed5922c577a2", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "127369d9-df6b-4a4e-b5fe-e54ccc71fa14", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "13ede3f9-6c8c-41b0-848d-09ca8b503e7d", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "19166038-67b7-4ce1-a3fe-39cc45ae7894", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "4db46d82-a747-415a-8546-f501ddf6802e", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "59fe4f3a-4cc8-4568-9274-9d29f34b88f2", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "6d811828-9a47-4de6-ac92-0b01fb477114", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "6e9d607b-c1f3-4f18-940d-797abd020639", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "7169fec9-90cc-4444-8459-3c8c75b9116f", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "732f0a73-8f42-4d49-9436-05344a5cec8a", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "77eaf285-e6cc-4e38-b90e-d6ee97b4d865", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "87d660c3-65fa-45fa-b1e5-b36184b35293", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "ac3b865f-03e7-48d5-b7ee-fa897b707441", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "d3b1d614-31e9-4ca4-bc7c-831adef315ef", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "e8ae3441-7a31-458e-a9ed-04643395dcb3", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "e930ef61-f142-4fb1-842e-d865344fd059", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "f370cd8d-5eaa-4d2b-9f5e-4fddbbf92e80", false, 10 },
                    { "e66bd69b-7738-4b95-8b09-aff8f3a092ff", "ffe3f5a6-27bf-441c-8ee8-0e9b1c2ae8aa", false, 10 }
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
