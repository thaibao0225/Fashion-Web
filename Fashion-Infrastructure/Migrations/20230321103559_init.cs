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
                    { "25320209-a63e-4b28-a0b4-61751e38e969", "72f5641f-8386-42f4-b75b-8258c80d0a6e", "RolesTable", false, "Admin", "admin" },
                    { "e2ddf888-aa93-49b9-bffe-54f7d3c59c95", "8c550b65-0ae2-4eba-9275-aae6adaade82", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18770765-21c2-4e59-b7c2-508926eaa93a", 0, "", "7eaf727c-8583-4132-af78-5a5022cd99d1", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAED/ZytyCJARx/fSzcDkNmdWyzoK6zAuNIVHeIrjVmBkn8/fr9Dv8oufKPTYJaO9v2Q==", null, false, "4984e899-2d05-4ff3-b625-3eac97691147", false, "Admin" },
                    { "f934a11a-2568-48d0-9176-a24a0c469a72", 0, "", "7f564853-825c-47c2-8d24-0a9fff42f88d", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEInoHIaBHlYtAi7KMfAb3GrFqEOIdpM9OOP0E/p13AfbQQA38ky11i62YXv+nNCx2Q==", null, false, "f8319720-436c-4532-972d-3af948f1c2db", false, "Staft" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "5e1736b4-f4fc-4305-bda1-073db92993f2", null, null, false, null, null, "", false, "NMD" },
                    { "64f4b71a-b320-4837-8744-deaeeea70a84", null, null, false, null, null, "", false, "Air Jordan 1" },
                    { "a76876df-a4d1-440e-b092-0c2f7e1d69ef", null, null, false, null, null, "", false, "Air Force 1" },
                    { "d2e76e3d-7903-4daa-bdfa-486202f89b99", null, null, false, null, null, "", false, "Yeezy" },
                    { "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", null, null, false, null, null, "", false, "For Her" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e2ddf888-aa93-49b9-bffe-54f7d3c59c95", "18770765-21c2-4e59-b7c2-508926eaa93a" },
                    { "25320209-a63e-4b28-a0b4-61751e38e969", "f934a11a-2568-48d0-9176-a24a0c469a72" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "0b891a91-2c84-4eb9-9e75-1a81515a9c5b", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "img/p-14/product-1.png", "img/p-14/product-2.png", "img/p-14/product-3.png", "img/p-14/product-4.png", "img/p-14/product-5.png", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "15ea7dd2-c0b5-4fb4-b6e2-b07c69824432", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "img/p-2/product-1.png", "img/p-2/product-2.png", "img/p-2/product-3.png", "img/p-2/product-4.png", "img/p-2/product-5.png", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "163ac239-bb2c-42a6-9883-7d4d49415b28", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "img/p-10/product-1.png", "img/p-10/product-2.png", "img/p-10/product-3.png", "img/p-10/product-4.png", "img/p-10/product-5.png", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "17d38673-f471-42fe-98eb-b0d1d116c2b6", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "img/p-23/product-1.png", "img/p-23/product-2.png", "img/p-23/product-3.png", "img/p-23/product-4.png", "img/p-23/product-5.png", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "1d8b9963-d9ec-4af4-9ca1-b4372674a9b9", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "img/p-5/product-1.png", "img/p-5/product-2.png", "img/p-5/product-3.png", "img/p-5/product-4.png", "img/p-5/product-5.png", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "1e3d5e70-c075-48b0-ab30-651046e77136", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "img/p-29/product-1.png", "img/p-29/product-2.png", "img/p-29/product-3.png", "img/p-29/product-4.png", "img/p-29/product-5.png", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "36e51a96-4387-4ac6-b30f-2a389191b01e", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "img/p-11/product-1.png", "img/p-11/product-2.png", "img/p-11/product-3.png", "img/p-11/product-4.png", "img/p-11/product-5.png", "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "3efbdac8-0e33-4035-ad16-2022b0400249", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "img/p-8/product-1.png", "img/p-8/product-2.png", "img/p-8/product-3.png", "img/p-8/product-4.png", "img/p-8/product-5.png", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "4d3ec33d-ff08-4ace-8f7e-f5c1aef7741d", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "img/p-1/product-1.png", "img/p-1/product-2.png", "img/p-1/product-3.png", "img/p-1/product-4.png", "img/p-1/product-5.png", " Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "5594f33d-e3d4-40af-88ce-c65f1eb4a4e5", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "img/p-17/product-1.png", "img/p-17/product-2.png", "img/p-17/product-3.png", "img/p-17/product-4.png", "img/p-17/product-5.png", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "65970b0d-8209-4db2-bc7a-c8db084d47b9", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "img/p-19/product-1.png", "img/p-19/product-2.png", "img/p-19/product-3.png", "img/p-19/product-4.png", "img/p-19/product-5.png", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "65d194ae-e655-4912-8b72-b2a43ea2251f", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "img/p-18/product-1.png", "img/p-18/product-2.png", "img/p-18/product-3.png", "img/p-18/product-4.png", "img/p-18/product-5.png", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "7303bd16-631b-44fa-bfd9-4119106d7901", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "img/p-9/product-1.png", "img/p-9/product-2.png", "img/p-9/product-3.png", "img/p-9/product-4.png", "img/p-9/product-5.png", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "7a2a140c-0f9b-46a2-9203-737e2d27e3a3", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Adidas NMD R1 Pixar ‘Black’ GX0997", "img/p-22/product-1.png", "img/p-22/product-2.png", "img/p-22/product-3.png", "img/p-22/product-4.png", "img/p-22/product-5.png", "Adidas NMD R1 Pixar ‘Black’ GX0997", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "7cae7415-7e28-4dcf-973e-f5b277e0d262", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "img/p-13/product-1.png", "img/p-13/product-2.png", "img/p-13/product-3.png", "img/p-13/product-4.png", "img/p-13/product-5.png", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "8dc09800-40d1-4b82-a4c6-69946cb3bddf", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "img/p-28/product-1.png", "img/p-28/product-2.png", "img/p-28/product-3.png", "img/p-28/product-4.png", "img/p-28/product-5.png", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "9bb18b73-a8c8-4c27-ac0d-209a3e30ab59", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "img/p-4/product-1.png", "img/p-4/product-2.png", "img/p-4/product-3.png", "img/p-4/product-4.png", "img/p-4/product-5.png", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "b55a7c79-0be7-4583-be33-9fee99b7dc24", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "img/p-12/product-1.png", "img/p-12/product-2.png", "img/p-12/product-3.png", "img/p-12/product-4.png", "img/p-12/product-5.png", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "b637bf4a-0e4f-4427-bb71-aeaa12f810b4", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "img/p-26/product-1.png", "img/p-26/product-2.png", "img/p-26/product-3.png", "img/p-26/product-4.png", "img/p-26/product-5.png", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "ca9576d5-003d-44f1-8e8e-9a2a53ca25b9", null, null, false, null, null, "a76876df-a4d1-440e-b092-0c2f7e1d69ef", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "img/p-7/product-1.png", "img/p-7/product-2.png", "img/p-7/product-3.png", "img/p-7/product-4.png", "img/p-7/product-5.png", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "d08c9183-3dd0-4503-9c0d-e4c46d43e56a", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "img/p-27/product-1.png", "img/p-27/product-2.png", "img/p-27/product-3.png", "img/p-27/product-4.png", "img/p-27/product-5.png", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "d0ea0f5c-029f-4c47-aa47-0825c46c5c31", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Adidas EQ19 Run H00933", "img/p-24/product-1.png", "img/p-24/product-2.png", "img/p-24/product-3.png", "img/p-24/product-4.png", "img/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "d3210244-cd2e-4393-824e-e061f664eae1", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "img/p-30/product-1.png", "img/p-30/product-2.png", "img/p-30/product-3.png", "img/p-30/product-4.png", "img/p-30/product-5.png", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "d73a580e-fdff-4f4b-a335-e30e27d0825a", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "img/p-6/product-1.png", "img/p-6/product-2.png", "img/p-6/product-3.png", "img/p-6/product-4.png", "img/p-6/product-5.png", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "d87a2aa7-c2d6-4615-ac12-eba8c6ef9d4d", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "img/p-16/product-1.png", "img/p-16/product-2.png", "img/p-16/product-3.png", "img/p-16/product-4.png", "img/p-16/product-5.png", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "dfe1f4c6-d870-4355-9342-adc329e791aa", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "img/p-20/product-1.png", "img/p-20/product-2.png", "img/p-20/product-3.png", "img/p-20/product-4.png", "img/p-20/product-5.png", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "eb2438de-4d1f-43fa-96e8-010957ace19f", null, null, false, null, null, "d2e76e3d-7903-4daa-bdfa-486202f89b99", "Adidas Yeezy Boost 350 V2 Sesame F99710", "img/p-15/product-1.png", "img/p-15/product-2.png", "img/p-15/product-3.png", "img/p-15/product-4.png", "img/p-15/product-5.png", "Adidas Yeezy Boost 350 V2 Sesame F99710", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "ecab1e75-beb2-45e9-bb29-ce132bfaa9e3", null, null, false, null, null, "5e1736b4-f4fc-4305-bda1-073db92993f2", "Adidas NMD R1 ‘Off White Sand’ FV1793", "img/p-21/product-1.png", "img/p-21/product-2.png", "img/p-21/product-3.png", "img/p-21/product-4.png", "img/p-21/product-5.png", "Adidas NMD R1 ‘Off White Sand’ FV1793", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "edcbc21a-8af4-4fe5-ba0f-753b0dde7964", null, null, false, null, null, "64f4b71a-b320-4837-8744-deaeeea70a84", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "img/p-3/product-1.png", "img/p-3/product-2.png", "img/p-3/product-3.png", "img/p-3/product-4.png", "img/p-3/product-5.png", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "eeb70329-5966-43cb-8cea-15ebd039fd7f", null, null, false, null, null, "eb10eeeb-9656-4ceb-8a43-cb243a2fbd0c", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "img/p-25/product-1.png", "img/p-25/product-2.png", "img/p-25/product-3.png", "img/p-25/product-4.png", "img/p-25/product-5.png", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 }
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
