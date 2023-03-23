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
                    { "c35786e4-f2f7-44fa-86cb-adc43871efba", "02c4c658-e227-46dd-ac65-079d5792f50b", "RolesTable", false, "Admin", "admin" },
                    { "d6f62e2d-e57d-46aa-a2cd-f440cc51b17b", "c5f1cf44-c84f-4be1-8f9e-29556b33b4b9", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e0a34e3-f9eb-47cf-a76e-6c7cbd91e380", 0, "", "11917b2d-f5b2-4cd1-aff5-82262bc1bef3", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJXVfcFSmbT+whz8V5zUzrFEcVEDV6V4DyrBi2/8vGPNj3iL2hTtQDj75GnOYwmcMg==", null, false, "067369f0-bb29-4b95-b861-9b85edf0ed83", false, "Staff" },
                    { "582b4216-166b-40fa-b874-34b3f2bcd7c0", 0, "", "987fcf42-e401-4cbb-b98d-bb7c8d185d67", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEIc5l5URgmXFL9tlMViDkHdOjaQ++/wWZchL7Ogtm9T3Mhg+dDf0zpLWGy7WGTDu3g==", null, false, "1924bb0a-7e25-43db-86f3-1a7394a0ddd1", false, "Staff2" },
                    { "6536be7e-c11f-41d5-b08c-d59a408bece4", 0, "", "f368fa7c-af05-4707-9cf0-c667373f7813", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGtkBU06DcYKanVIkBZK4iRF1lh0U+FdxsS6czFEdwZH5/CElTY1HlzQBdd6+4q7+A==", null, false, "f78b475d-de19-4b63-a3e2-84683a78f8c0", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "00a25c69-6461-4e13-8e19-d211e724080f", null, null, false, null, null, "", false, "NMD" },
                    { "78b6cc3a-3a8f-4928-9282-e8116d75ff89", null, null, false, null, null, "", false, "Air Jordan 1" },
                    { "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", null, null, false, null, null, "", false, "Air Force 1" },
                    { "b252ca58-9c19-47b0-9ce4-a34144950f24", null, null, false, null, null, "", false, "Yeezy" },
                    { "d0b27484-4852-43bc-af12-20a553a76b6d", null, null, false, null, null, "", false, "For Her" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "74d3ba79-4505-4796-b516-f945163de297", false, "Green" },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", false, "Yellow" },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", false, "Red" },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", false, "Black" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", false, 37 },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", false, 36 },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", false, 35 },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", false, 39 },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", false, 38 },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", false, 35 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c35786e4-f2f7-44fa-86cb-adc43871efba", "0e0a34e3-f9eb-47cf-a76e-6c7cbd91e380" },
                    { "c35786e4-f2f7-44fa-86cb-adc43871efba", "582b4216-166b-40fa-b874-34b3f2bcd7c0" },
                    { "d6f62e2d-e57d-46aa-a2cd-f440cc51b17b", "6536be7e-c11f-41d5-b08c-d59a408bece4" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "a74014f5-0b9e-49cc-b2db-eaa8f52503e4", "", new DateTime(2023, 3, 23, 16, 6, 7, 366, DateTimeKind.Local).AddTicks(3615), false, "", new DateTime(2023, 3, 23, 16, 6, 7, 367, DateTimeKind.Local).AddTicks(6357), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "58fecb22-9bdd-498e-a433-5290d82496ac|1e8e7c1b-d305-403c-8303-5fa9a972e18e|9f47f4ef-c735-4ef8-aea9-707367881e04|0f6622e1-24da-4079-b177-2c942777f17a|", "6536be7e-c11f-41d5-b08c-d59a408bece4" },
                    { "b619de45-c5a7-4520-a4e5-b6ea79cbed18", "", new DateTime(2023, 3, 23, 16, 6, 7, 366, DateTimeKind.Local).AddTicks(3615), false, "", new DateTime(2023, 3, 23, 16, 6, 7, 367, DateTimeKind.Local).AddTicks(6357), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab|309b4387-87d2-4545-bb36-03754da157b6|27ba8db0-3681-4407-a665-40571d20dbbf|acb432eb-a131-4936-af92-746c8084ddfa|", "582b4216-166b-40fa-b874-34b3f2bcd7c0" },
                    { "df8c29bd-6fcf-4730-a3d3-9249d77e5f51", "", new DateTime(2023, 3, 23, 16, 6, 7, 366, DateTimeKind.Local).AddTicks(3615), false, "", new DateTime(2023, 3, 23, 16, 6, 7, 367, DateTimeKind.Local).AddTicks(6357), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436|9339aa4e-7423-4f6f-8fd7-089cbbb8eef1|8f00ae43-e1ff-4994-b89b-a43f80f5c268|cf83bbfa-631e-440d-bb2b-7601f4cd7f20|", "0e0a34e3-f9eb-47cf-a76e-6c7cbd91e380" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "0f6622e1-24da-4079-b177-2c942777f17a", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "1e8e7c1b-d305-403c-8303-5fa9a972e18e", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "1ea51443-52e8-4ae4-ade3-1da381717372", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "25118bb2-7eab-4108-a336-f0d1190cb4f3", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "27ba8db0-3681-4407-a665-40571d20dbbf", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "29da04b6-5d0a-42dc-9b96-db322bb32154", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "309b4387-87d2-4545-bb36-03754da157b6", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "3603dc35-94ed-4d06-9dfb-de5d5259d16d", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "3f337f0c-1f64-42b6-a81d-48cef5540972", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "4516f8a3-d2ad-46f7-86b0-c2845692cb75", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "58fecb22-9bdd-498e-a433-5290d82496ac", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "7d2f2684-2cf8-4806-b8d2-8fb7027a11af", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "86b30d19-b6ba-402a-825a-178f220fc6a7", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "8f00ae43-e1ff-4994-b89b-a43f80f5c268", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "8fef77d9-6592-4b16-a14f-8922ba2103e2", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "912a8dd5-ae98-4d28-a629-440646d40f8b", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "9177de3a-b09e-4327-84a7-e833160f6a7b", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "9f47f4ef-c735-4ef8-aea9-707367881e04", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "a6d018aa-f944-435e-b893-02ea7d69bffd", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "a9972d74-b0bb-423e-9b4e-b7509576fc17", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "acb432eb-a131-4936-af92-746c8084ddfa", null, null, false, null, null, "ac8bf093-7082-4768-97f2-85cbb3ac4cfb", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "ad7e8134-c659-4044-aba9-012069937afd", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "cc2daec7-8933-4119-ab48-f7e415ee5c6f", null, null, false, null, null, "b252ca58-9c19-47b0-9ce4-a34144950f24", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", null, null, false, null, null, "78b6cc3a-3a8f-4928-9282-e8116d75ff89", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "f31c9df7-33c6-4a6c-b230-98b21f16c240", null, null, false, null, null, "d0b27484-4852-43bc-af12-20a553a76b6d", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "fd8b6b1d-3812-4d03-8cd7-8c2d68976d58", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "ff8d32ad-6391-41b6-96c3-5e1786d671d4", null, null, false, null, null, "00a25c69-6461-4e13-8e19-d211e724080f", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "74d3ba79-4505-4796-b516-f945163de297", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "1ea51443-52e8-4ae4-ade3-1da381717372", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "25118bb2-7eab-4108-a336-f0d1190cb4f3", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "27ba8db0-3681-4407-a665-40571d20dbbf", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "29da04b6-5d0a-42dc-9b96-db322bb32154", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "3603dc35-94ed-4d06-9dfb-de5d5259d16d", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "3f337f0c-1f64-42b6-a81d-48cef5540972", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "4516f8a3-d2ad-46f7-86b0-c2845692cb75", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "7d2f2684-2cf8-4806-b8d2-8fb7027a11af", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "86b30d19-b6ba-402a-825a-178f220fc6a7", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "8fef77d9-6592-4b16-a14f-8922ba2103e2", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "912a8dd5-ae98-4d28-a629-440646d40f8b", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "9177de3a-b09e-4327-84a7-e833160f6a7b", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "a6d018aa-f944-435e-b893-02ea7d69bffd", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "a9972d74-b0bb-423e-9b4e-b7509576fc17", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "acb432eb-a131-4936-af92-746c8084ddfa", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "ad7e8134-c659-4044-aba9-012069937afd", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "cc2daec7-8933-4119-ab48-f7e415ee5c6f", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "f31c9df7-33c6-4a6c-b230-98b21f16c240", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "fd8b6b1d-3812-4d03-8cd7-8c2d68976d58", false },
                    { "74d3ba79-4505-4796-b516-f945163de297", "ff8d32ad-6391-41b6-96c3-5e1786d671d4", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "1ea51443-52e8-4ae4-ade3-1da381717372", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "25118bb2-7eab-4108-a336-f0d1190cb4f3", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "27ba8db0-3681-4407-a665-40571d20dbbf", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "29da04b6-5d0a-42dc-9b96-db322bb32154", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "3603dc35-94ed-4d06-9dfb-de5d5259d16d", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "3f337f0c-1f64-42b6-a81d-48cef5540972", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "4516f8a3-d2ad-46f7-86b0-c2845692cb75", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "7d2f2684-2cf8-4806-b8d2-8fb7027a11af", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "86b30d19-b6ba-402a-825a-178f220fc6a7", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "8fef77d9-6592-4b16-a14f-8922ba2103e2", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "912a8dd5-ae98-4d28-a629-440646d40f8b", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "9177de3a-b09e-4327-84a7-e833160f6a7b", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "a6d018aa-f944-435e-b893-02ea7d69bffd", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "a9972d74-b0bb-423e-9b4e-b7509576fc17", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "acb432eb-a131-4936-af92-746c8084ddfa", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "ad7e8134-c659-4044-aba9-012069937afd", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "cc2daec7-8933-4119-ab48-f7e415ee5c6f", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "f31c9df7-33c6-4a6c-b230-98b21f16c240", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "fd8b6b1d-3812-4d03-8cd7-8c2d68976d58", false },
                    { "9cf349bd-f8e1-4aec-a06a-9a85a5be8899", "ff8d32ad-6391-41b6-96c3-5e1786d671d4", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "1ea51443-52e8-4ae4-ade3-1da381717372", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "25118bb2-7eab-4108-a336-f0d1190cb4f3", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "27ba8db0-3681-4407-a665-40571d20dbbf", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "29da04b6-5d0a-42dc-9b96-db322bb32154", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "3603dc35-94ed-4d06-9dfb-de5d5259d16d", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "3f337f0c-1f64-42b6-a81d-48cef5540972", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "4516f8a3-d2ad-46f7-86b0-c2845692cb75", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "7d2f2684-2cf8-4806-b8d2-8fb7027a11af", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "86b30d19-b6ba-402a-825a-178f220fc6a7", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "8fef77d9-6592-4b16-a14f-8922ba2103e2", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "912a8dd5-ae98-4d28-a629-440646d40f8b", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "9177de3a-b09e-4327-84a7-e833160f6a7b", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "a6d018aa-f944-435e-b893-02ea7d69bffd", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "a9972d74-b0bb-423e-9b4e-b7509576fc17", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "acb432eb-a131-4936-af92-746c8084ddfa", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "ad7e8134-c659-4044-aba9-012069937afd", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "cc2daec7-8933-4119-ab48-f7e415ee5c6f", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "f31c9df7-33c6-4a6c-b230-98b21f16c240", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "fd8b6b1d-3812-4d03-8cd7-8c2d68976d58", false },
                    { "f73e9b9e-f433-484d-95fb-60964d8b5533", "ff8d32ad-6391-41b6-96c3-5e1786d671d4", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "1ea51443-52e8-4ae4-ade3-1da381717372", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "25118bb2-7eab-4108-a336-f0d1190cb4f3", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "27ba8db0-3681-4407-a665-40571d20dbbf", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "29da04b6-5d0a-42dc-9b96-db322bb32154", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "3603dc35-94ed-4d06-9dfb-de5d5259d16d", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "3f337f0c-1f64-42b6-a81d-48cef5540972", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "4516f8a3-d2ad-46f7-86b0-c2845692cb75", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "7d2f2684-2cf8-4806-b8d2-8fb7027a11af", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "86b30d19-b6ba-402a-825a-178f220fc6a7", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "8fef77d9-6592-4b16-a14f-8922ba2103e2", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "912a8dd5-ae98-4d28-a629-440646d40f8b", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "9177de3a-b09e-4327-84a7-e833160f6a7b", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "a6d018aa-f944-435e-b893-02ea7d69bffd", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "a9972d74-b0bb-423e-9b4e-b7509576fc17", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "acb432eb-a131-4936-af92-746c8084ddfa", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "ad7e8134-c659-4044-aba9-012069937afd", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "cc2daec7-8933-4119-ab48-f7e415ee5c6f", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "f31c9df7-33c6-4a6c-b230-98b21f16c240", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "fd8b6b1d-3812-4d03-8cd7-8c2d68976d58", false },
                    { "fc5d89ae-af06-4856-952a-0e469758d636", "ff8d32ad-6391-41b6-96c3-5e1786d671d4", false }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "af86280b-990d-4703-92bf-449dab4101a3", null, null, false, null, null, "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", "Red", "0e0a34e3-f9eb-47cf-a76e-6c7cbd91e380" },
                    { "bfc460c6-a828-41ff-83e7-93632fdbf4ce", null, null, false, null, null, "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", "Red", "0e0a34e3-f9eb-47cf-a76e-6c7cbd91e380" },
                    { "d3325ca2-a40c-4858-bcf3-91bde48c890e", null, null, false, null, null, "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", "Red", "6536be7e-c11f-41d5-b08c-d59a408bece4" },
                    { "d993acd4-123e-46f8-9998-f84da6c6d83a", null, null, false, null, null, "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", "Red", "582b4216-166b-40fa-b874-34b3f2bcd7c0" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "0e09117b-d214-4eb7-9b48-7efaceb4b76b", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "2866e1e4-0794-4a5e-8194-f7bae3d214e8", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "38595ca9-92e7-488e-976d-b2f047c3f7e1", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "3b2eea5a-133a-4efa-9984-5c20d8bc5070", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "58fecb22-9bdd-498e-a433-5290d82496ac", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "85cfad89-8c28-485f-a630-fc2bfa38ce7f", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "0f6622e1-24da-4079-b177-2c942777f17a", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "1e8e7c1b-d305-403c-8303-5fa9a972e18e", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "309b4387-87d2-4545-bb36-03754da157b6", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "58fecb22-9bdd-498e-a433-5290d82496ac", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "5dcff6d5-6d2f-40f3-95e0-c3b6c6659436", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "8f00ae43-e1ff-4994-b89b-a43f80f5c268", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "9339aa4e-7423-4f6f-8fd7-089cbbb8eef1", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "9d3d3946-9697-43a6-bb2b-ff6dc78498ab", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "9f47f4ef-c735-4ef8-aea9-707367881e04", false },
                    { "f1f161cf-2559-4eda-9fba-45c18c35d7a9", "cf83bbfa-631e-440d-bb2b-7601f4cd7f20", false }
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
