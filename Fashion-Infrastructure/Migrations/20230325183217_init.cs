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
                    { "5730ea65-5339-4663-b229-817d6a906ba0", "09462cd9-efca-425e-8022-8a3c2e99712c", "RolesTable", false, "Staff", "staff" },
                    { "d718c589-422d-4777-8843-b62f88977942", "36695e9b-4b1b-475d-b79e-8198254e2302", "RolesTable", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2887fcfb-986d-477d-a317-5d6c20455555", 0, "", "39ce6723-f723-4e44-bee0-59c2b1cb0d0d", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJYRKNkxssV3cvy6PqwDYS5F4xKhS3YJPZp8cBFksmNkqQSxbpHLLy583Z+zdUx6wA==", null, false, "67f66634-66d3-4ed4-9c83-0ce01a103b89", false, "Staff" },
                    { "4eedd273-3ca5-4441-90a2-ad7749481d64", 0, "", "be25ec17-5331-476d-826e-5325c3f8e26d", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEM0VF8mTwogrd0MmvjGAxRWwC4+PTMNhh12C/ps5dqNNY5IRBjzVzrSQmHY4EXxiJg==", null, false, "1549b808-895c-44ed-9fa9-4a1f8295df6c", false, "Staff2" },
                    { "9f11d40e-15b5-4537-b73d-cc439639eefd", 0, "", "eca42fc5-2287-4911-9d9d-c2fcda6051a9", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGq6ZwBxvzEiXJrwh0WzyajHIGC4f3UGgyZ2yJ8ZmimsgJz9aux7Gmc1ff23kTanDQ==", null, false, "17406f20-30f5-4967-9fbd-a6d8a847f472", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "107854e1-b4a9-4c97-a264-3a21788299e7", null, null, false, null, null, "", "For Her" },
                    { "58a4b838-5517-4d30-802c-80e4a3190cf5", null, null, false, null, null, "", "Air Force 1" },
                    { "646829a9-ec09-4b9b-8d21-ffdce76ed86e", null, null, false, null, null, "", "Yeezy" },
                    { "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", null, null, false, null, null, "", "Air Jordan 1" },
                    { "f43fcf3b-d344-402d-be52-b941e8961515", null, null, false, null, null, "", "NMD" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", false, "Yellow" },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", false, "Green" },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", false, "Black" },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", false, "Red" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "20c2b063-37c8-4e7f-8d80-7a53e5d21399", "test@gmail.com", false },
                    { "236f088d-f22f-4ce8-af3a-fc48b4ec189d", "test@gmail.com", false },
                    { "2f6dae1a-7c3f-49b4-afac-836ab2c349a6", "test@gmail.com", false },
                    { "d4375487-df2a-4fe5-965a-4062d3d75b84", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", false, 39 },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", false, 37 },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", false, 36 },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", false, 35 },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", false, 38 },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", false, 35 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d718c589-422d-4777-8843-b62f88977942", "2887fcfb-986d-477d-a317-5d6c20455555" },
                    { "d718c589-422d-4777-8843-b62f88977942", "4eedd273-3ca5-4441-90a2-ad7749481d64" },
                    { "5730ea65-5339-4663-b229-817d6a906ba0", "9f11d40e-15b5-4537-b73d-cc439639eefd" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "34825cae-3e29-4c4b-8674-d6ec2ee85169", "", new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, "", new DateTime(2023, 3, 26, 1, 32, 16, 700, DateTimeKind.Local).AddTicks(949), 1, new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "6ff8e19c-84fe-401b-8863-161e186807aa|b863f56d-f016-4cae-a2cb-26f2f3d9863d|30cd4afe-3269-481b-bb32-a833c13768c5|2f0d3b4f-2ec4-485f-a839-5b0e289148a4|", "2887fcfb-986d-477d-a317-5d6c20455555" },
                    { "48772dbe-d693-47ee-aceb-f6aa230e942b", "", new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, "", new DateTime(2023, 3, 26, 1, 32, 16, 700, DateTimeKind.Local).AddTicks(949), 1, new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "53fd7ff4-387a-4f7c-99f9-42f657f1816b|1c5dd50b-4faf-4dd7-9178-706cd26ad389|8b9fd97e-5624-452c-961d-20ba7863c88e|bc8de19d-caf1-4e1e-9d0f-3d4db95808c9|", "4eedd273-3ca5-4441-90a2-ad7749481d64" },
                    { "61411ef1-47d6-46a3-972b-4e91237c0af1", "", new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, "", new DateTime(2023, 3, 26, 1, 32, 16, 700, DateTimeKind.Local).AddTicks(949), 1, new DateTime(2023, 3, 26, 1, 32, 16, 699, DateTimeKind.Local).AddTicks(5047), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "0d854bac-b562-4762-8715-a5eb1a016d0c|9c683c32-85c8-46a0-b8be-8e7ea47a9244|6c1809e5-ef08-4b40-b18e-d2a47b760598|55ec2521-aa06-4103-ae18-e5fb0608abc1|", "9f11d40e-15b5-4537-b73d-cc439639eefd" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "04c11911-9ea7-4a23-b4cf-17812fbee8c3", null, null, false, null, null, "20c2b063-37c8-4e7f-8d80-7a53e5d21399", false, "Message", "Name", "Subject" },
                    { "258a3654-6cd2-4e7a-b2f7-79d4793fe161", null, null, false, null, null, "236f088d-f22f-4ce8-af3a-fc48b4ec189d", false, "Message", "Name", "Subject" },
                    { "bc390a7a-a440-4f8f-b277-314814bf7654", null, null, false, null, null, "2f6dae1a-7c3f-49b4-afac-836ab2c349a6", false, "Message", "Name", "Subject" },
                    { "f7c33777-7841-40a0-831b-e27e33186496", null, null, false, null, null, "d4375487-df2a-4fe5-965a-4062d3d75b84", true, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "0d854bac-b562-4762-8715-a5eb1a016d0c", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "0de67446-b541-4f66-b35c-f57339671a18", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "1c5dd50b-4faf-4dd7-9178-706cd26ad389", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "2dadf5dc-9552-4c3a-bf71-91b6547408b4", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "30cd4afe-3269-481b-bb32-a833c13768c5", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "385fdf4a-a915-4534-b94a-c623c0b130ab", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "4ad9b354-2bde-4f97-8ef8-b9bf1e6816e4", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "53fd7ff4-387a-4f7c-99f9-42f657f1816b", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "55ec2521-aa06-4103-ae18-e5fb0608abc1", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "6c1809e5-ef08-4b40-b18e-d2a47b760598", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "6ff8e19c-84fe-401b-8863-161e186807aa", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "82a94ab2-11aa-410b-9ab2-e1396b645848", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "8b9fd97e-5624-452c-961d-20ba7863c88e", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "918ecfc2-8cda-4b01-82d5-9e759b7ec6d4", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "93db71d4-d352-4205-a50b-5d1d14e45c0d", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "9c683c32-85c8-46a0-b8be-8e7ea47a9244", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "a3842ab1-fe8c-41c6-8773-005892e90c1b", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "b863f56d-f016-4cae-a2cb-26f2f3d9863d", null, null, false, null, null, "c790c0b4-11f4-4ca5-9e9f-c337837b9e85", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "bacdb8ca-edcc-4070-8d8a-94f23e8873bf", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "bc8de19d-caf1-4e1e-9d0f-3d4db95808c9", null, null, false, null, null, "58a4b838-5517-4d30-802c-80e4a3190cf5", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "beae3021-3a3b-40b3-b96c-0f66a6f88998", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "c213f64e-adf0-4d49-af12-9e8c9596dd11", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "de7b20ca-707c-4304-975b-3cf033f3e92d", null, null, false, null, null, "107854e1-b4a9-4c97-a264-3a21788299e7", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "e3402204-e7b0-488f-ba08-20eeb87b93d3", null, null, false, null, null, "f43fcf3b-d344-402d-be52-b941e8961515", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "e97cc0d8-ebe9-428c-9fb1-e67af221af57", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "ecd52245-2ad4-4806-9c32-c40fa15781de", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "f24ecc8a-0055-4588-9331-4e2175985aa3", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "f40ddf68-2e08-4739-af0f-d441b067e494", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "f47a6f3e-a05d-4bf9-924f-5733b97506bc", null, null, false, null, null, "646829a9-ec09-4b9b-8d21-ffdce76ed86e", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "0de67446-b541-4f66-b35c-f57339671a18", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "2dadf5dc-9552-4c3a-bf71-91b6547408b4", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "385fdf4a-a915-4534-b94a-c623c0b130ab", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "4ad9b354-2bde-4f97-8ef8-b9bf1e6816e4", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "82a94ab2-11aa-410b-9ab2-e1396b645848", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "8b9fd97e-5624-452c-961d-20ba7863c88e", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "918ecfc2-8cda-4b01-82d5-9e759b7ec6d4", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "93db71d4-d352-4205-a50b-5d1d14e45c0d", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "a3842ab1-fe8c-41c6-8773-005892e90c1b", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "bacdb8ca-edcc-4070-8d8a-94f23e8873bf", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "bc8de19d-caf1-4e1e-9d0f-3d4db95808c9", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "beae3021-3a3b-40b3-b96c-0f66a6f88998", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "c213f64e-adf0-4d49-af12-9e8c9596dd11", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "de7b20ca-707c-4304-975b-3cf033f3e92d", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "e3402204-e7b0-488f-ba08-20eeb87b93d3", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "e97cc0d8-ebe9-428c-9fb1-e67af221af57", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "ecd52245-2ad4-4806-9c32-c40fa15781de", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "f24ecc8a-0055-4588-9331-4e2175985aa3", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "f40ddf68-2e08-4739-af0f-d441b067e494", false },
                    { "7d25aeaf-940c-4dcf-8f28-9ae94be506fa", "f47a6f3e-a05d-4bf9-924f-5733b97506bc", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "0de67446-b541-4f66-b35c-f57339671a18", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "2dadf5dc-9552-4c3a-bf71-91b6547408b4", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "385fdf4a-a915-4534-b94a-c623c0b130ab", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "4ad9b354-2bde-4f97-8ef8-b9bf1e6816e4", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "6ff8e19c-84fe-401b-8863-161e186807aa", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "82a94ab2-11aa-410b-9ab2-e1396b645848", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "8b9fd97e-5624-452c-961d-20ba7863c88e", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "918ecfc2-8cda-4b01-82d5-9e759b7ec6d4", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "93db71d4-d352-4205-a50b-5d1d14e45c0d", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "a3842ab1-fe8c-41c6-8773-005892e90c1b", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "bacdb8ca-edcc-4070-8d8a-94f23e8873bf", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "bc8de19d-caf1-4e1e-9d0f-3d4db95808c9", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "beae3021-3a3b-40b3-b96c-0f66a6f88998", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "c213f64e-adf0-4d49-af12-9e8c9596dd11", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "de7b20ca-707c-4304-975b-3cf033f3e92d", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "e3402204-e7b0-488f-ba08-20eeb87b93d3", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "e97cc0d8-ebe9-428c-9fb1-e67af221af57", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "ecd52245-2ad4-4806-9c32-c40fa15781de", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "f24ecc8a-0055-4588-9331-4e2175985aa3", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "f40ddf68-2e08-4739-af0f-d441b067e494", false },
                    { "96e7dccd-0d89-4fdb-9504-b97427d0b63f", "f47a6f3e-a05d-4bf9-924f-5733b97506bc", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "0de67446-b541-4f66-b35c-f57339671a18", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "2dadf5dc-9552-4c3a-bf71-91b6547408b4", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "385fdf4a-a915-4534-b94a-c623c0b130ab", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "4ad9b354-2bde-4f97-8ef8-b9bf1e6816e4", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "82a94ab2-11aa-410b-9ab2-e1396b645848", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "8b9fd97e-5624-452c-961d-20ba7863c88e", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "918ecfc2-8cda-4b01-82d5-9e759b7ec6d4", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "93db71d4-d352-4205-a50b-5d1d14e45c0d", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "a3842ab1-fe8c-41c6-8773-005892e90c1b", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "bacdb8ca-edcc-4070-8d8a-94f23e8873bf", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "bc8de19d-caf1-4e1e-9d0f-3d4db95808c9", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "beae3021-3a3b-40b3-b96c-0f66a6f88998", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "c213f64e-adf0-4d49-af12-9e8c9596dd11", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "de7b20ca-707c-4304-975b-3cf033f3e92d", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "e3402204-e7b0-488f-ba08-20eeb87b93d3", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "e97cc0d8-ebe9-428c-9fb1-e67af221af57", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "ecd52245-2ad4-4806-9c32-c40fa15781de", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "f24ecc8a-0055-4588-9331-4e2175985aa3", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "f40ddf68-2e08-4739-af0f-d441b067e494", false },
                    { "bd3c0381-f96a-4a04-9c5e-478017784a9a", "f47a6f3e-a05d-4bf9-924f-5733b97506bc", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "0de67446-b541-4f66-b35c-f57339671a18", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "2dadf5dc-9552-4c3a-bf71-91b6547408b4", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "385fdf4a-a915-4534-b94a-c623c0b130ab", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "4ad9b354-2bde-4f97-8ef8-b9bf1e6816e4", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "82a94ab2-11aa-410b-9ab2-e1396b645848", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "8b9fd97e-5624-452c-961d-20ba7863c88e", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "918ecfc2-8cda-4b01-82d5-9e759b7ec6d4", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "93db71d4-d352-4205-a50b-5d1d14e45c0d", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "a3842ab1-fe8c-41c6-8773-005892e90c1b", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "bacdb8ca-edcc-4070-8d8a-94f23e8873bf", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "bc8de19d-caf1-4e1e-9d0f-3d4db95808c9", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "beae3021-3a3b-40b3-b96c-0f66a6f88998", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "c213f64e-adf0-4d49-af12-9e8c9596dd11", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "de7b20ca-707c-4304-975b-3cf033f3e92d", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "e3402204-e7b0-488f-ba08-20eeb87b93d3", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "e97cc0d8-ebe9-428c-9fb1-e67af221af57", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "ecd52245-2ad4-4806-9c32-c40fa15781de", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "f24ecc8a-0055-4588-9331-4e2175985aa3", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "f40ddf68-2e08-4739-af0f-d441b067e494", false },
                    { "cc16feba-89c3-4d33-b237-508a288d10c2", "f47a6f3e-a05d-4bf9-924f-5733b97506bc", false }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "46325bcf-6b8a-4e27-9974-3925c08e01c1", null, null, false, null, null, "6ff8e19c-84fe-401b-8863-161e186807aa", "Test comment", "9f11d40e-15b5-4537-b73d-cc439639eefd" },
                    { "7fa14df7-9cd1-485a-bcf8-a656e23dadcd", null, null, false, null, null, "6ff8e19c-84fe-401b-8863-161e186807aa", "Test comment", "4eedd273-3ca5-4441-90a2-ad7749481d64" },
                    { "c32f2cea-5563-4879-80d9-ecef4e2b4021", null, null, false, null, null, "b863f56d-f016-4cae-a2cb-26f2f3d9863d", "Test comment", "2887fcfb-986d-477d-a317-5d6c20455555" },
                    { "f607eca4-3e09-4290-b3f9-743a71815ef6", null, null, false, null, null, "6ff8e19c-84fe-401b-8863-161e186807aa", "Test comment", "2887fcfb-986d-477d-a317-5d6c20455555" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "1c501b62-8b86-40ad-a31b-06c1a4546009", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "68a2aecd-0e2a-4694-825d-91cd3634f3d4", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "95651ad4-7b23-4a89-a5be-1beff176c1ea", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "ba1144a1-2905-4dca-b2f9-ccb5bd8ee89b", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "30cd4afe-3269-481b-bb32-a833c13768c5", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "d31f4d52-7ea9-45f2-acfb-e61e13e75630", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "0d854bac-b562-4762-8715-a5eb1a016d0c", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "1c5dd50b-4faf-4dd7-9178-706cd26ad389", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "2f0d3b4f-2ec4-485f-a839-5b0e289148a4", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "30cd4afe-3269-481b-bb32-a833c13768c5", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "53fd7ff4-387a-4f7c-99f9-42f657f1816b", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "55ec2521-aa06-4103-ae18-e5fb0608abc1", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "6c1809e5-ef08-4b40-b18e-d2a47b760598", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "6ff8e19c-84fe-401b-8863-161e186807aa", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "9c683c32-85c8-46a0-b8be-8e7ea47a9244", false },
                    { "fa92ca0f-1ee0-4db7-bda7-a8093cb72c0c", "b863f56d-f016-4cae-a2cb-26f2f3d9863d", false }
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
