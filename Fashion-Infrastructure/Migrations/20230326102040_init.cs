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
                    { "0470de33-0861-4b5e-81a6-34b32d6dcad6", "77540f60-37bb-4716-9ce2-fc490d388255", "RolesTable", false, "Admin", "admin" },
                    { "cf8d6cd5-a7f8-46c0-86d0-3abfa3fceacc", "86787744-32fe-44d1-bd20-6ec1a8fd8d1e", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a81d247-67bd-43f9-9d94-4829ab277e65", 0, "", "c866ee15-335f-45dd-ad33-42a7c00d7e7b", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK4X2qcmZlQZp+bE2BNY7DbXcw9uaKPFQP0Si8OCRUjnEu0VyJdGDjZ24nPgHdmyXQ==", null, false, "5d34e23e-95db-487d-83c5-286cb16ae565", false, "Admin" },
                    { "b74c3f51-e67f-421b-bab7-303c6900b01b", 0, "", "2f9004f5-ada2-4ad0-a335-25092e929538", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAENRLzjmKlVdmUktng1dNCO0nmZUuLTodc31ooclNb0IhzVl9SPjU1KN34T1ve/XWvg==", null, false, "e48a16e6-9ee4-4743-a692-c71e0692b933", false, "Staff2" },
                    { "bb6f1ab0-c5b2-44c8-a92b-a6829797d09d", 0, "", "2e5475e9-7882-4d27-a163-f12f8a37566b", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJRzBdgClmEfYzs0kG4pSpqHJuEb3qT+kYDIUC94uCNztVMTjBqal6wJGAN4eBRpBA==", null, false, "4444adce-0021-42bd-b6fa-58b95a24f2cf", false, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "42035e77-51fe-455f-b248-d7a4f708c748", null, null, false, null, null, "", "Air Jordan 1" },
                    { "465ac552-f8e6-4bf7-9324-a479b4388207", null, null, false, null, null, "", "NMD" },
                    { "94b04852-1faf-4476-bc4a-0c8aeec5fb00", null, null, false, null, null, "", "Air Force 1" },
                    { "c03de8ec-b799-4fe3-817c-80b407f9a6e3", null, null, false, null, null, "", "Yeezy" },
                    { "c8dec92f-2343-4762-8f7b-95ad38f992b0", null, null, false, null, null, "", "For Her" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", false, "Green" },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", false, "Yellow" },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", false, "Red" },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", false, "Black" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "1d048430-37db-404d-acdc-6d4aac59350f", "test@gmail.com", false },
                    { "1f2741c3-fafb-43db-8052-822185042892", "test@gmail.com", false },
                    { "a8f175b8-b2d3-485e-919e-f8ac2f089862", "test@gmail.com", false },
                    { "c29d9251-d2f7-486f-ba71-530b748cdf15", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", false, 35 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", false, 38 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", false, 35 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", false, 37 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", false, 39 },
                    { "dba56703-584b-4033-a568-6f4275288996", false, 36 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cf8d6cd5-a7f8-46c0-86d0-3abfa3fceacc", "3a81d247-67bd-43f9-9d94-4829ab277e65" },
                    { "0470de33-0861-4b5e-81a6-34b32d6dcad6", "b74c3f51-e67f-421b-bab7-303c6900b01b" },
                    { "0470de33-0861-4b5e-81a6-34b32d6dcad6", "bb6f1ab0-c5b2-44c8-a92b-a6829797d09d" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "3b22424d-3c4c-44e7-ab0e-0be0c3001785", "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(8304), 1, new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "65eaf3a2-a2b4-491d-94ff-d17c06729725|e49bbf2c-3146-4cc6-b4e7-03f1972dc0be|200d9063-3cd8-4bb9-8e45-116d7ded3d0f|4b76dd26-0085-4863-b2f1-20fa04857b73|", "bb6f1ab0-c5b2-44c8-a92b-a6829797d09d" },
                    { "6ed25e95-daa8-4431-a236-e19263fbe175", "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(8304), 1, new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "4624e955-d471-4128-ad7c-ecfac349a9d6|05f2c8d5-cd00-43fe-94b4-98ea45078bfb|94fb8505-559d-413a-9100-a113ff6f1ee2|7b19f56f-4706-4d8e-b081-020b3f44db74|", "b74c3f51-e67f-421b-bab7-303c6900b01b" },
                    { "b02d8109-2b7e-4357-a87d-e56869b1a312", "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, "", new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(8304), 1, new DateTime(2023, 3, 26, 17, 20, 40, 391, DateTimeKind.Local).AddTicks(2765), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "793bcbe2-b155-407d-ba69-ea2b4017826d|958d01c5-a237-4d06-aef7-9c97013bae01|55360ede-3bdd-47c9-9d47-cd5780de9b31|1f7599da-5e4a-4b6b-b23f-27e380b9c591|", "3a81d247-67bd-43f9-9d94-4829ab277e65" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "192278a6-b0ad-4e33-967e-a2b70beaafca", null, null, false, null, null, "a8f175b8-b2d3-485e-919e-f8ac2f089862", false, "Message", "Name", "Subject" },
                    { "8348e398-4709-4579-949b-a7d2fcddc13d", null, null, false, null, null, "1f2741c3-fafb-43db-8052-822185042892", false, "Message", "Name", "Subject" },
                    { "adbc8d3b-ca23-416b-8b06-a1e61e4e01e1", null, null, false, null, null, "1d048430-37db-404d-acdc-6d4aac59350f", true, "Message", "Name", "Subject" },
                    { "cbf89428-d90f-4ac9-820d-cf447d17fe12", null, null, false, null, null, "c29d9251-d2f7-486f-ba71-530b748cdf15", false, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "049de32f-9d21-406a-877b-af2bb48f6b07", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "1f7599da-5e4a-4b6b-b23f-27e380b9c591", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "22b4d0d0-af13-474b-814c-fc275bd0ad3c", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "284901f7-c625-4237-b26e-64df43940092", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "3b813af0-93e1-4350-a733-2b8e951254a5", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "3bc1b3b6-5ee5-45b2-900d-a1a725755bfd", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "4624e955-d471-4128-ad7c-ecfac349a9d6", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "4b76dd26-0085-4863-b2f1-20fa04857b73", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "55360ede-3bdd-47c9-9d47-cd5780de9b31", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "65eaf3a2-a2b4-491d-94ff-d17c06729725", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "6ad86cba-0694-4a33-a127-1933c379b8de", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "793bcbe2-b155-407d-ba69-ea2b4017826d", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "7a69cc7a-4396-4bad-9a02-45a756bddf4f", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "7b19f56f-4706-4d8e-b081-020b3f44db74", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "8258a4f7-e3c0-4fc9-8210-81cc0318ba5d", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "832f7e27-5677-44e4-9e03-68ad4e1e1dbe", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "8578fc74-f4f7-476c-bf70-6efcff55eaed", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "9097f91c-9281-42ce-844e-671c032dbc73", null, null, false, null, null, "c8dec92f-2343-4762-8f7b-95ad38f992b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "924d6da3-e944-4e0e-821b-2aac63a2e6a6", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "94fb8505-559d-413a-9100-a113ff6f1ee2", null, null, false, null, null, "94b04852-1faf-4476-bc4a-0c8aeec5fb00", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "958d01c5-a237-4d06-aef7-9c97013bae01", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", null, null, false, null, null, "c03de8ec-b799-4fe3-817c-80b407f9a6e3", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "c639151b-4fd2-4c7d-8aeb-59d39947aad2", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", null, null, false, null, null, "42035e77-51fe-455f-b248-d7a4f708c748", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "fb586ff0-3fdd-4bc2-8b79-30c1b0eed33e", null, null, false, null, null, "465ac552-f8e6-4bf7-9324-a479b4388207", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "049de32f-9d21-406a-877b-af2bb48f6b07", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "22b4d0d0-af13-474b-814c-fc275bd0ad3c", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "284901f7-c625-4237-b26e-64df43940092", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "3b813af0-93e1-4350-a733-2b8e951254a5", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "3bc1b3b6-5ee5-45b2-900d-a1a725755bfd", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "7a69cc7a-4396-4bad-9a02-45a756bddf4f", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "8258a4f7-e3c0-4fc9-8210-81cc0318ba5d", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "832f7e27-5677-44e4-9e03-68ad4e1e1dbe", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "9097f91c-9281-42ce-844e-671c032dbc73", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "924d6da3-e944-4e0e-821b-2aac63a2e6a6", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "c639151b-4fd2-4c7d-8aeb-59d39947aad2", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "1a4b5d91-66c2-4808-a9de-12db5bbca13c", "fb586ff0-3fdd-4bc2-8b79-30c1b0eed33e", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "049de32f-9d21-406a-877b-af2bb48f6b07", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "22b4d0d0-af13-474b-814c-fc275bd0ad3c", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "284901f7-c625-4237-b26e-64df43940092", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "3b813af0-93e1-4350-a733-2b8e951254a5", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "3bc1b3b6-5ee5-45b2-900d-a1a725755bfd", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "7a69cc7a-4396-4bad-9a02-45a756bddf4f", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "8258a4f7-e3c0-4fc9-8210-81cc0318ba5d", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "832f7e27-5677-44e4-9e03-68ad4e1e1dbe", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "9097f91c-9281-42ce-844e-671c032dbc73", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "924d6da3-e944-4e0e-821b-2aac63a2e6a6", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "c639151b-4fd2-4c7d-8aeb-59d39947aad2", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "5d106764-a267-4d11-a35a-d58b3048b64e", "fb586ff0-3fdd-4bc2-8b79-30c1b0eed33e", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "049de32f-9d21-406a-877b-af2bb48f6b07", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "22b4d0d0-af13-474b-814c-fc275bd0ad3c", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "284901f7-c625-4237-b26e-64df43940092", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "3b813af0-93e1-4350-a733-2b8e951254a5", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "3bc1b3b6-5ee5-45b2-900d-a1a725755bfd", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "7a69cc7a-4396-4bad-9a02-45a756bddf4f", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "8258a4f7-e3c0-4fc9-8210-81cc0318ba5d", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "832f7e27-5677-44e4-9e03-68ad4e1e1dbe", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "9097f91c-9281-42ce-844e-671c032dbc73", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "924d6da3-e944-4e0e-821b-2aac63a2e6a6", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete", "cip_QuantityExisting" },
                values: new object[,]
                {
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "c639151b-4fd2-4c7d-8aeb-59d39947aad2", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "7d231044-f1d6-4df8-b617-da8cd93a94d4", "fb586ff0-3fdd-4bc2-8b79-30c1b0eed33e", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "049de32f-9d21-406a-877b-af2bb48f6b07", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "22b4d0d0-af13-474b-814c-fc275bd0ad3c", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "284901f7-c625-4237-b26e-64df43940092", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "3b813af0-93e1-4350-a733-2b8e951254a5", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "3bc1b3b6-5ee5-45b2-900d-a1a725755bfd", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "7a69cc7a-4396-4bad-9a02-45a756bddf4f", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "8258a4f7-e3c0-4fc9-8210-81cc0318ba5d", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "832f7e27-5677-44e4-9e03-68ad4e1e1dbe", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "9097f91c-9281-42ce-844e-671c032dbc73", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "924d6da3-e944-4e0e-821b-2aac63a2e6a6", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "c639151b-4fd2-4c7d-8aeb-59d39947aad2", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "cce50c6c-39a2-44cd-a3c3-3b34a3d08114", "fb586ff0-3fdd-4bc2-8b79-30c1b0eed33e", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Rating", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "030f320d-04c1-442a-a763-aa8d0c5dde15", null, null, false, null, null, "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", 0, "Test comment", "bb6f1ab0-c5b2-44c8-a92b-a6829797d09d" },
                    { "77a728a4-4e7a-4c4c-b813-9c3c9cf94bce", null, null, false, null, null, "65eaf3a2-a2b4-491d-94ff-d17c06729725", 0, "Test comment", "bb6f1ab0-c5b2-44c8-a92b-a6829797d09d" },
                    { "911475d9-819a-433f-99aa-3fd685146488", null, null, false, null, null, "65eaf3a2-a2b4-491d-94ff-d17c06729725", 0, "Test comment", "b74c3f51-e67f-421b-bab7-303c6900b01b" },
                    { "ca643f8d-4d02-4184-bf9d-b5be439e26ff", null, null, false, null, null, "65eaf3a2-a2b4-491d-94ff-d17c06729725", 0, "Test comment", "3a81d247-67bd-43f9-9d94-4829ab277e65" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "54d377c9-353a-4f3a-a63b-68224b14e2a8", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "66e21d54-a8e1-44d3-ab0c-0a9ef48b3499", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "8c94fb0a-4aac-438f-bcb9-c38e70a42b83", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "af785b46-930a-4de9-aa58-47f0cf1ea505", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete", "sip_QuantityExisting" },
                values: new object[,]
                {
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "cbe366bd-3b6e-482b-b7b8-db90ad1c3b1d", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "05f2c8d5-cd00-43fe-94b4-98ea45078bfb", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "1f7599da-5e4a-4b6b-b23f-27e380b9c591", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "200d9063-3cd8-4bb9-8e45-116d7ded3d0f", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "32bbf063-9263-43d0-9324-8f5e4aaa9b9f", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "4624e955-d471-4128-ad7c-ecfac349a9d6", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "4b76dd26-0085-4863-b2f1-20fa04857b73", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "55360ede-3bdd-47c9-9d47-cd5780de9b31", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "65eaf3a2-a2b4-491d-94ff-d17c06729725", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "6ad86cba-0694-4a33-a127-1933c379b8de", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "793bcbe2-b155-407d-ba69-ea2b4017826d", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "7b19f56f-4706-4d8e-b081-020b3f44db74", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "8578fc74-f4f7-476c-bf70-6efcff55eaed", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "8ca0ca86-4fd3-44cd-a428-24d3967d1bb3", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "94fb8505-559d-413a-9100-a113ff6f1ee2", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "958d01c5-a237-4d06-aef7-9c97013bae01", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "b6fd4537-d59c-428f-93c1-1d6c4ebad63f", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "b7a34a73-1c5d-4dd9-9819-532e64c7e44e", false, 10 },
                    { "dba56703-584b-4033-a568-6f4275288996", "e49bbf2c-3146-4cc6-b4e7-03f1972dc0be", false, 10 }
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
