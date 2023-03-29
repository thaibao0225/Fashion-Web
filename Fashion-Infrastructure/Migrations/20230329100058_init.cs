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
                    { "281541f6-5c67-4ca7-8b8a-f3b8a5b0fc79", "ec70160d-0cd9-4d65-9224-956d2ca1e1f2", "RolesTable", false, "Staff", "staff" },
                    { "281709c7-1b0b-43f3-85f3-fba989b7e2bd", "b9ee0057-ffd0-4b1d-8d45-c8b96ff19be2", "RolesTable", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45bc84d8-fe71-45d8-9e2d-84eee532e791", 0, "", "2067c09a-4010-4806-a36d-6fba8d453eb7", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJjYs1g/BbCN09T47tzzimxyeklv3tHhsUg/EL4VjCrM7/rJVHV+h3kDuoFo7n8l+Q==", null, false, "2d258533-5e47-46fc-8d15-39bb83103589", false, "Admin" },
                    { "4ad40118-fa17-49ea-b4c0-adcf6057571e", 0, "", "ff2ce9c7-d663-4b3f-aa38-4791910fb0fc", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEK0yV1143gHWteepMUBzyE2qlfpMnv8mU8sPIESeQ4w7djejbomLiUA3ISojamVPBw==", null, false, "68fd8f56-95fa-4c6d-b7ad-d8dfe475dd76", false, "Staff2" },
                    { "f0042ebc-caaf-425c-9a75-e125db2c059c", 0, "", "ee6a2060-cdf3-4e92-9d2d-2b2289d8a872", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEKwEc8apgpUOkjnVXBI5kfQF+DniBcd5m1LuHOifZj1w3v5YwZtk3uJyBBoGD0K4Hg==", null, false, "05ae039a-c5e3-47b2-871a-2e4095b8e830", false, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "1410229e-b6a0-496b-9798-3ddc0ab695e5", null, null, false, null, null, "", "Yeezy" },
                    { "16e774c0-57fb-4d6f-baac-1c643f09febc", null, null, false, null, null, "", "NMD" },
                    { "87c300c3-fcbb-4230-837b-79c293e65ada", null, null, false, null, null, "", "Air Force 1" },
                    { "e7c51cbf-5975-46db-a74b-6ae62950cb00", null, null, false, null, null, "", "For Her" },
                    { "f1e5aafe-3b95-4522-830a-e12942ebbe32", null, null, false, null, null, "", "Air Jordan 1" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", false, "Black" },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", false, "Green" },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", false, "Yellow" },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", false, "Red" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "05ea8939-920c-408a-ac4f-5ca1fa46ba97", "test@gmail.com", false },
                    { "d4ea95e4-4075-46f0-89af-5847f12cacd6", "test@gmail.com", false },
                    { "e2793a48-cb8c-4822-9ddb-a4c2ad08eac2", "test@gmail.com", false },
                    { "ea6808cf-c400-4407-bfa6-d99264880aa9", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "0b905936-31a0-440d-b037-1a8e11992188", false, 36 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", false, 39 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", false, 35 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", false, 35 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", false, 38 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", false, 37 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "281541f6-5c67-4ca7-8b8a-f3b8a5b0fc79", "45bc84d8-fe71-45d8-9e2d-84eee532e791" },
                    { "281709c7-1b0b-43f3-85f3-fba989b7e2bd", "4ad40118-fa17-49ea-b4c0-adcf6057571e" },
                    { "281709c7-1b0b-43f3-85f3-fba989b7e2bd", "f0042ebc-caaf-425c-9a75-e125db2c059c" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "5731a50b-a33d-4ac6-b9df-574dfe6b2b37", "", new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, "", new DateTime(2023, 3, 29, 17, 0, 57, 228, DateTimeKind.Local).AddTicks(1508), 1, new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "6edc16a8-6954-462c-9e1d-950047308a36|af1b209d-6a3d-4f03-a907-3e88943e97ef|c921cd21-79ac-43f0-807e-3f8683750655|c2967914-0723-425e-936e-6ff27a8fd302|", "f0042ebc-caaf-425c-9a75-e125db2c059c" },
                    { "97c70976-344f-4a64-8779-068dbcc29985", "", new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, "", new DateTime(2023, 3, 29, 17, 0, 57, 228, DateTimeKind.Local).AddTicks(1508), 1, new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "782ff169-6f9a-439f-82d5-819d8d38e861|d648667c-502b-460e-a2c7-9feb5047ac9a|aa51c572-302f-4a46-8a11-0d70e0b170f1|7820b224-3b43-4f3c-a9c0-1876dd7fbe61|", "4ad40118-fa17-49ea-b4c0-adcf6057571e" },
                    { "efa94222-9bb6-48e7-b54b-595eaa068692", "", new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, "", new DateTime(2023, 3, 29, 17, 0, 57, 228, DateTimeKind.Local).AddTicks(1508), 1, new DateTime(2023, 3, 29, 17, 0, 57, 227, DateTimeKind.Local).AddTicks(897), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "b53d723b-8914-42a0-93c9-fe52a689739b|c47589e4-bf07-4623-b1ce-6687b05b19d9|cec7fa23-0568-4086-8db9-606166dd2260|8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a|", "45bc84d8-fe71-45d8-9e2d-84eee532e791" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "4af28988-27c8-44b7-9297-4634a9644d8a", null, null, false, null, null, "d4ea95e4-4075-46f0-89af-5847f12cacd6", false, "Message", "Name", "Subject" },
                    { "5b5e15a8-637c-4dda-a6a2-571a2af04900", null, null, false, null, null, "05ea8939-920c-408a-ac4f-5ca1fa46ba97", false, "Message", "Name", "Subject" },
                    { "78258afc-b652-4810-9056-6da531f3a0e1", null, null, false, null, null, "e2793a48-cb8c-4822-9ddb-a4c2ad08eac2", false, "Message", "Name", "Subject" },
                    { "ea384a41-3316-497c-81a2-fbc433371dae", null, null, false, null, null, "ea6808cf-c400-4407-bfa6-d99264880aa9", true, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "05a534d9-8970-4dad-ae20-3cf2cf091868", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "0d1ed249-c6ff-47e2-97f3-67f8aa422123", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "343738af-a055-46f1-9705-2f2f4f60b30b", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "391474f0-2766-44d7-ab6b-b9a8754fe83a", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "47664ac1-9745-4ced-a36a-49ee0a6adc7f", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "4babe670-7b39-4a96-bd5a-5d150c7d0486", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "6de4dff6-6698-41a4-891e-49e5dc3dfb82", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "6edc16a8-6954-462c-9e1d-950047308a36", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "6ee644fe-af1d-47e3-8475-7367e6f8ec8b", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "782ff169-6f9a-439f-82d5-819d8d38e861", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "a9380334-122a-49e9-934a-3499728a3684", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "aa51c572-302f-4a46-8a11-0d70e0b170f1", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "af1b209d-6a3d-4f03-a907-3e88943e97ef", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "b53d723b-8914-42a0-93c9-fe52a689739b", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "baed8a10-c0ad-4a07-a26d-492f91bae32a", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "bd500a3b-5a05-435c-8bb6-a863559a1a72", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "c2967914-0723-425e-936e-6ff27a8fd302", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "c47589e4-bf07-4623-b1ce-6687b05b19d9", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "c533647a-55ca-43c0-9c99-c01f394cedf9", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "c921cd21-79ac-43f0-807e-3f8683750655", null, null, false, null, null, "f1e5aafe-3b95-4522-830a-e12942ebbe32", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "cec7fa23-0568-4086-8db9-606166dd2260", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "cfe4bc8c-5873-48ca-8f68-d543f24ada8a", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "d648667c-502b-460e-a2c7-9feb5047ac9a", null, null, false, null, null, "87c300c3-fcbb-4230-837b-79c293e65ada", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "f1c94280-20e6-4036-9606-2b522b7870aa", null, null, false, null, null, "16e774c0-57fb-4d6f-baac-1c643f09febc", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "f55dbd34-1865-417d-8737-da3b7ef9dd34", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", null, null, false, null, null, "1410229e-b6a0-496b-9798-3ddc0ab695e5", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "fe840b92-6593-4b00-ae7e-7d7900c48cc4", null, null, false, null, null, "e7c51cbf-5975-46db-a74b-6ae62950cb00", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "0d1ed249-c6ff-47e2-97f3-67f8aa422123", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "391474f0-2766-44d7-ab6b-b9a8754fe83a", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "47664ac1-9745-4ced-a36a-49ee0a6adc7f", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "6de4dff6-6698-41a4-891e-49e5dc3dfb82", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "6ee644fe-af1d-47e3-8475-7367e6f8ec8b", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "a9380334-122a-49e9-934a-3499728a3684", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "baed8a10-c0ad-4a07-a26d-492f91bae32a", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "bd500a3b-5a05-435c-8bb6-a863559a1a72", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "c533647a-55ca-43c0-9c99-c01f394cedf9", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "cfe4bc8c-5873-48ca-8f68-d543f24ada8a", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "f1c94280-20e6-4036-9606-2b522b7870aa", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "9b2cd1b1-94f1-43c4-aeb4-3fc1b2c31842", "fe840b92-6593-4b00-ae7e-7d7900c48cc4", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "0d1ed249-c6ff-47e2-97f3-67f8aa422123", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "391474f0-2766-44d7-ab6b-b9a8754fe83a", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "47664ac1-9745-4ced-a36a-49ee0a6adc7f", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "6de4dff6-6698-41a4-891e-49e5dc3dfb82", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "6ee644fe-af1d-47e3-8475-7367e6f8ec8b", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "a9380334-122a-49e9-934a-3499728a3684", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "baed8a10-c0ad-4a07-a26d-492f91bae32a", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "bd500a3b-5a05-435c-8bb6-a863559a1a72", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "c533647a-55ca-43c0-9c99-c01f394cedf9", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "cfe4bc8c-5873-48ca-8f68-d543f24ada8a", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "f1c94280-20e6-4036-9606-2b522b7870aa", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "ee8ee9f7-11ea-42dd-9c84-5bc790b972e5", "fe840b92-6593-4b00-ae7e-7d7900c48cc4", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "0d1ed249-c6ff-47e2-97f3-67f8aa422123", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "391474f0-2766-44d7-ab6b-b9a8754fe83a", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "47664ac1-9745-4ced-a36a-49ee0a6adc7f", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "6de4dff6-6698-41a4-891e-49e5dc3dfb82", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "6ee644fe-af1d-47e3-8475-7367e6f8ec8b", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "a9380334-122a-49e9-934a-3499728a3684", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "baed8a10-c0ad-4a07-a26d-492f91bae32a", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "bd500a3b-5a05-435c-8bb6-a863559a1a72", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "c533647a-55ca-43c0-9c99-c01f394cedf9", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "cfe4bc8c-5873-48ca-8f68-d543f24ada8a", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "f1c94280-20e6-4036-9606-2b522b7870aa", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "efc47e37-6057-447e-8bc8-b1ab8baf2461", "fe840b92-6593-4b00-ae7e-7d7900c48cc4", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "0d1ed249-c6ff-47e2-97f3-67f8aa422123", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "391474f0-2766-44d7-ab6b-b9a8754fe83a", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "47664ac1-9745-4ced-a36a-49ee0a6adc7f", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "6de4dff6-6698-41a4-891e-49e5dc3dfb82", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "6ee644fe-af1d-47e3-8475-7367e6f8ec8b", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "a9380334-122a-49e9-934a-3499728a3684", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "baed8a10-c0ad-4a07-a26d-492f91bae32a", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "bd500a3b-5a05-435c-8bb6-a863559a1a72", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "c533647a-55ca-43c0-9c99-c01f394cedf9", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "cfe4bc8c-5873-48ca-8f68-d543f24ada8a", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "f1c94280-20e6-4036-9606-2b522b7870aa", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "fdcaeec7-03c9-459b-9725-60a88c82b2e5", "fe840b92-6593-4b00-ae7e-7d7900c48cc4", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Rating", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "25c95331-1d29-46cc-a6f2-077e5eacbf4b", null, null, false, null, null, "6edc16a8-6954-462c-9e1d-950047308a36", 0, "Test comment", "4ad40118-fa17-49ea-b4c0-adcf6057571e" },
                    { "50c72bf4-4eb4-4b32-b114-d2388e713588", null, null, false, null, null, "6edc16a8-6954-462c-9e1d-950047308a36", 0, "Test comment", "f0042ebc-caaf-425c-9a75-e125db2c059c" },
                    { "6e5cf949-cf5e-4c5e-a9a2-d26e7e49b8ad", null, null, false, null, null, "af1b209d-6a3d-4f03-a907-3e88943e97ef", 0, "Test comment", "f0042ebc-caaf-425c-9a75-e125db2c059c" },
                    { "e66d1231-3045-44a4-b704-fdc0906236db", null, null, false, null, null, "6edc16a8-6954-462c-9e1d-950047308a36", 0, "Test comment", "45bc84d8-fe71-45d8-9e2d-84eee532e791" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "0b905936-31a0-440d-b037-1a8e11992188", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "0b905936-31a0-440d-b037-1a8e11992188", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "0b905936-31a0-440d-b037-1a8e11992188", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "58db09e0-0471-4de3-8b66-9203f53ef32d", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "7346cf38-f833-4a6f-96cd-8304befd95a5", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "8ca4cb44-98c7-4d74-8943-9ab3793dc698", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "9539812c-e1d2-48ba-91e3-ea27a637b2c1", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "05a534d9-8970-4dad-ae20-3cf2cf091868", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "343738af-a055-46f1-9705-2f2f4f60b30b", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "4babe670-7b39-4a96-bd5a-5d150c7d0486", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "6d1e4ee2-aea8-4e13-9a92-e93bdde3d81d", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "6edc16a8-6954-462c-9e1d-950047308a36", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "7820b224-3b43-4f3c-a9c0-1876dd7fbe61", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "782ff169-6f9a-439f-82d5-819d8d38e861", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "8b6aed0f-f52d-4f77-82cd-c30b53dc5c9a", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "aa51c572-302f-4a46-8a11-0d70e0b170f1", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "af1b209d-6a3d-4f03-a907-3e88943e97ef", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "b53d723b-8914-42a0-93c9-fe52a689739b", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "c2967914-0723-425e-936e-6ff27a8fd302", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "c47589e4-bf07-4623-b1ce-6687b05b19d9", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "c921cd21-79ac-43f0-807e-3f8683750655", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "cec7fa23-0568-4086-8db9-606166dd2260", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "d648667c-502b-460e-a2c7-9feb5047ac9a", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "f55dbd34-1865-417d-8737-da3b7ef9dd34", false, 10 },
                    { "e7fe07e5-0a75-4f7f-9d09-2544701f069c", "f56ad3fd-b1c8-426e-bfed-077bf8fdd0a4", false, 10 }
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
