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
                    { "23b68f40-e0fe-4b0e-8b20-42f20557c02b", "7d4b42e9-bae5-4b7f-9e8f-574f0a7af16e", "RolesTable", false, "Admin", "admin" },
                    { "338d35b4-7017-4098-a487-a8cd6b388fb1", "1ff40a82-96c3-4bc4-85aa-ad39ee2754fe", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "87a81173-6876-469d-a551-05bd817efa8d", 0, "", "da26c09f-7818-4bc7-bc30-77dad53bb18c", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEEequifVnMJ+wBvLEL90quzX7weBBgTr/P8nroYTfJ60h9MncJF5W+DnyMF/UNd2Mg==", null, false, "ec25d420-2554-4466-a9d3-2870c1060f1f", false, "Staff" },
                    { "bdabb2a9-ec27-4d3a-a878-ccece8fbf127", 0, "", "3c446517-d80b-4dc8-b697-f34a6d4013df", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEM6V5C0GctdLn4Mykk+7o5lqbUPGklyWZOK2HjRRDBq3t4HR6OY7O/iy4c9bTKIRaQ==", null, false, "c1776d74-08b3-4156-9879-047f51527941", false, "Admin" },
                    { "c1a71d1b-c777-473a-881d-15f13ff356e6", 0, "", "e456430c-f5d5-4e15-9b14-e7ef0189a15a", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEA4XnAIENxKt7KjyRdWY+atjNZFbZIgOUxbA2KhfW1+czfIfouj2sSnbMM4egjOTrw==", null, false, "ca55c205-ff9a-4dae-93a9-7e4be462e0ae", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", null, null, false, null, null, "", "For Her" },
                    { "203bc5a1-51bd-4aa2-9784-86dfd02bde85", null, null, false, null, null, "", "Air Jordan 1" },
                    { "4e3745b3-50d4-419f-963b-bef9b6fcc42a", null, null, false, null, null, "", "NMD" },
                    { "d874e827-f0aa-4744-8a79-5c6a121a0cb4", null, null, false, null, null, "", "Air Force 1" },
                    { "fe8faab2-c176-4156-bc5d-b4850a9d29cc", null, null, false, null, null, "", "Yeezy" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", false, "Green" },
                    { "56693053-a55a-421a-85a7-23109552a23b", false, "Yellow" },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", false, "Red" },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", false, "Black" }
                });

            migrationBuilder.InsertData(
                table: "EmailCustomer",
                columns: new[] { "emailC_Id", "emailC_Email", "emailC_IsDelete" },
                values: new object[,]
                {
                    { "0c621ea4-c41d-4109-8ecb-eaa22ab7e84a", "test@gmail.com", false },
                    { "1b2e5513-be77-48a7-ab62-24128352aab0", "test@gmail.com", false },
                    { "4cf9f2f8-fab3-41ba-b0d8-f0bbd1858b32", "test@gmail.com", false },
                    { "ba9ccf94-573b-4984-8b33-cb0f69a4efd3", "test@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", false, 37 },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", false, 38 },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", false, 35 },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", false, 39 },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", false, 35 },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", false, 36 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23b68f40-e0fe-4b0e-8b20-42f20557c02b", "87a81173-6876-469d-a551-05bd817efa8d" },
                    { "338d35b4-7017-4098-a487-a8cd6b388fb1", "bdabb2a9-ec27-4d3a-a878-ccece8fbf127" },
                    { "23b68f40-e0fe-4b0e-8b20-42f20557c02b", "c1a71d1b-c777-473a-881d-15f13ff356e6" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "15e82488-2a39-40e3-8d4d-42d089fa5f22", "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(1211), false, "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(7160), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c|7e0ba4d6-0acb-46d8-9e37-94998d261620|6925f78f-234e-4fe7-956b-5f8cebad76d0|67844f18-046f-453f-b368-deb96749fdff|", "bdabb2a9-ec27-4d3a-a878-ccece8fbf127" },
                    { "b4ace813-314c-4f89-86c0-d95e5bab5376", "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(1211), false, "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(7160), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80|e366dbc6-10e8-4907-a70e-dbf75281fef5|2e225a09-bfff-4f83-82ae-2a8da2f904f5|6c66d5f8-a5eb-4948-8572-f07663def263|", "87a81173-6876-469d-a551-05bd817efa8d" },
                    { "d996e51e-46df-4aa8-b88d-6888f21c99e3", "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(1211), false, "", new DateTime(2023, 3, 26, 0, 42, 52, 234, DateTimeKind.Local).AddTicks(7160), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow|", "10|10|10|10|", "X|XL|S|M|", "1|1|1|1|", "df97464d-29ad-4635-8d5d-6e163de1acc3|7ce83e17-d2ca-4884-b40c-887dd862e5c4|ae124687-9305-4101-94d8-8a25c5be7ac2|a2fdd4e6-d599-4cf3-8e71-1db2de03d147|", "c1a71d1b-c777-473a-881d-15f13ff356e6" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "contact_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "contact_EmailId", "contact_IsCheck", "contact_Message", "contact_Name", "contact_Subject" },
                values: new object[,]
                {
                    { "17e2a7cb-cd2b-40a5-85a0-f69b7d504b4b", null, null, false, null, null, "1b2e5513-be77-48a7-ab62-24128352aab0", false, "Message", "Name", "Subject" },
                    { "352c1766-8a9a-4996-b8f3-6014ba78a69b", null, null, false, null, null, "4cf9f2f8-fab3-41ba-b0d8-f0bbd1858b32", false, "Message", "Name", "Subject" },
                    { "68d24d61-0140-47d8-b495-62c146485536", null, null, false, null, null, "ba9ccf94-573b-4984-8b33-cb0f69a4efd3", true, "Message", "Name", "Subject" },
                    { "c7c2396f-114c-450d-b03d-149fc16c2c77", null, null, false, null, null, "0c621ea4-c41d-4109-8ecb-eaa22ab7e84a", false, "Message", "Name", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "04340236-7b95-44f9-99b7-98b1a3c11020", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "090a9a36-7bf2-4c00-950d-abba7e836176", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "11e87998-8442-40cc-af15-aeef5d646848", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "2ada6771-1d6c-412c-b367-c1f1f68a4bdd", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "2e225a09-bfff-4f83-82ae-2a8da2f904f5", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "2e6f936a-8d7f-4e33-b42e-5b3b9ecf5bf8", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "388dac06-1dd3-482a-a35b-24da3e1b7242", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "3dfe22cf-f4f2-491c-8129-b170f939cf38", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "453fffe8-0223-4581-8b0c-1e7e4d4eb205", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "67844f18-046f-453f-b368-deb96749fdff", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "6925f78f-234e-4fe7-956b-5f8cebad76d0", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "6bdad827-c05a-490b-8510-65345746d4c5", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "6c66d5f8-a5eb-4948-8572-f07663def263", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "7467cd0f-5d5c-4dfa-81bd-e2ef64d04606", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "75aab323-f1d8-4153-ba4a-cb7f4aa1fc47", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "75bb11b0-e84b-4162-9f04-265b3d10aee6", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "7ce83e17-d2ca-4884-b40c-887dd862e5c4", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "7e0ba4d6-0acb-46d8-9e37-94998d261620", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "863fc968-30ed-4326-b5e6-cb5a461a2ae2", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "879b240a-36be-4f33-b466-b465d3709a69", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "a2fdd4e6-d599-4cf3-8e71-1db2de03d147", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "ad5b452c-0993-4424-9e1b-5445949d1d47", null, null, false, null, null, "4e3745b3-50d4-419f-963b-bef9b6fcc42a", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "ae124687-9305-4101-94d8-8a25c5be7ac2", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "cf1a83b2-84c2-4411-9f62-43fe36401727", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "df97464d-29ad-4635-8d5d-6e163de1acc3", null, null, false, null, null, "d874e827-f0aa-4744-8a79-5c6a121a0cb4", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "e366dbc6-10e8-4907-a70e-dbf75281fef5", null, null, false, null, null, "203bc5a1-51bd-4aa2-9784-86dfd02bde85", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "f16e4b22-4184-4f23-bfde-b3f44b1d969c", null, null, false, null, null, "20084a1c-b6bd-4b2f-91e3-cea862dedb3d", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "f6ddae45-051a-4874-802a-f7392a129b94", null, null, false, null, null, "fe8faab2-c176-4156-bc5d-b4850a9d29cc", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "04340236-7b95-44f9-99b7-98b1a3c11020", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "090a9a36-7bf2-4c00-950d-abba7e836176", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "11e87998-8442-40cc-af15-aeef5d646848", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "2ada6771-1d6c-412c-b367-c1f1f68a4bdd", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "2e6f936a-8d7f-4e33-b42e-5b3b9ecf5bf8", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "388dac06-1dd3-482a-a35b-24da3e1b7242", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "3dfe22cf-f4f2-491c-8129-b170f939cf38", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "453fffe8-0223-4581-8b0c-1e7e4d4eb205", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "6bdad827-c05a-490b-8510-65345746d4c5", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "7467cd0f-5d5c-4dfa-81bd-e2ef64d04606", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "75aab323-f1d8-4153-ba4a-cb7f4aa1fc47", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "75bb11b0-e84b-4162-9f04-265b3d10aee6", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "863fc968-30ed-4326-b5e6-cb5a461a2ae2", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "879b240a-36be-4f33-b466-b465d3709a69", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "a2fdd4e6-d599-4cf3-8e71-1db2de03d147", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "ad5b452c-0993-4424-9e1b-5445949d1d47", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "ae124687-9305-4101-94d8-8a25c5be7ac2", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "cf1a83b2-84c2-4411-9f62-43fe36401727", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "f16e4b22-4184-4f23-bfde-b3f44b1d969c", false },
                    { "4aa9eb2f-f62d-4698-9495-33e9584359df", "f6ddae45-051a-4874-802a-f7392a129b94", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "04340236-7b95-44f9-99b7-98b1a3c11020", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "090a9a36-7bf2-4c00-950d-abba7e836176", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "11e87998-8442-40cc-af15-aeef5d646848", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "2ada6771-1d6c-412c-b367-c1f1f68a4bdd", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "2e6f936a-8d7f-4e33-b42e-5b3b9ecf5bf8", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "388dac06-1dd3-482a-a35b-24da3e1b7242", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "3dfe22cf-f4f2-491c-8129-b170f939cf38", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "453fffe8-0223-4581-8b0c-1e7e4d4eb205", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "56693053-a55a-421a-85a7-23109552a23b", "6bdad827-c05a-490b-8510-65345746d4c5", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "7467cd0f-5d5c-4dfa-81bd-e2ef64d04606", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "75aab323-f1d8-4153-ba4a-cb7f4aa1fc47", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "75bb11b0-e84b-4162-9f04-265b3d10aee6", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "863fc968-30ed-4326-b5e6-cb5a461a2ae2", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "879b240a-36be-4f33-b466-b465d3709a69", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "a2fdd4e6-d599-4cf3-8e71-1db2de03d147", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "ad5b452c-0993-4424-9e1b-5445949d1d47", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "ae124687-9305-4101-94d8-8a25c5be7ac2", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "cf1a83b2-84c2-4411-9f62-43fe36401727", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "f16e4b22-4184-4f23-bfde-b3f44b1d969c", false },
                    { "56693053-a55a-421a-85a7-23109552a23b", "f6ddae45-051a-4874-802a-f7392a129b94", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "04340236-7b95-44f9-99b7-98b1a3c11020", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "090a9a36-7bf2-4c00-950d-abba7e836176", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "11e87998-8442-40cc-af15-aeef5d646848", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "2ada6771-1d6c-412c-b367-c1f1f68a4bdd", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "2e6f936a-8d7f-4e33-b42e-5b3b9ecf5bf8", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "388dac06-1dd3-482a-a35b-24da3e1b7242", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "3dfe22cf-f4f2-491c-8129-b170f939cf38", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "453fffe8-0223-4581-8b0c-1e7e4d4eb205", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "6bdad827-c05a-490b-8510-65345746d4c5", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "7467cd0f-5d5c-4dfa-81bd-e2ef64d04606", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "75aab323-f1d8-4153-ba4a-cb7f4aa1fc47", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "75bb11b0-e84b-4162-9f04-265b3d10aee6", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "863fc968-30ed-4326-b5e6-cb5a461a2ae2", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "879b240a-36be-4f33-b466-b465d3709a69", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "a2fdd4e6-d599-4cf3-8e71-1db2de03d147", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "ad5b452c-0993-4424-9e1b-5445949d1d47", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "ae124687-9305-4101-94d8-8a25c5be7ac2", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "cf1a83b2-84c2-4411-9f62-43fe36401727", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "f16e4b22-4184-4f23-bfde-b3f44b1d969c", false },
                    { "606c753e-3243-4549-9298-7d5b8bf21ec7", "f6ddae45-051a-4874-802a-f7392a129b94", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "04340236-7b95-44f9-99b7-98b1a3c11020", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "090a9a36-7bf2-4c00-950d-abba7e836176", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "11e87998-8442-40cc-af15-aeef5d646848", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "2ada6771-1d6c-412c-b367-c1f1f68a4bdd", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "2e6f936a-8d7f-4e33-b42e-5b3b9ecf5bf8", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "388dac06-1dd3-482a-a35b-24da3e1b7242", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "3dfe22cf-f4f2-491c-8129-b170f939cf38", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "453fffe8-0223-4581-8b0c-1e7e4d4eb205", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "6bdad827-c05a-490b-8510-65345746d4c5", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "7467cd0f-5d5c-4dfa-81bd-e2ef64d04606", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "75aab323-f1d8-4153-ba4a-cb7f4aa1fc47", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "75bb11b0-e84b-4162-9f04-265b3d10aee6", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "863fc968-30ed-4326-b5e6-cb5a461a2ae2", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "879b240a-36be-4f33-b466-b465d3709a69", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "a2fdd4e6-d599-4cf3-8e71-1db2de03d147", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "ad5b452c-0993-4424-9e1b-5445949d1d47", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "ae124687-9305-4101-94d8-8a25c5be7ac2", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "cf1a83b2-84c2-4411-9f62-43fe36401727", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "f16e4b22-4184-4f23-bfde-b3f44b1d969c", false },
                    { "82634b81-c3a7-415e-bd7a-4bd663143936", "f6ddae45-051a-4874-802a-f7392a129b94", false }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "04d4fee4-478c-41ca-a7ae-e633d82b00f8", null, null, false, null, null, "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", "Red", "c1a71d1b-c777-473a-881d-15f13ff356e6" },
                    { "6b069cfd-c626-4108-9162-7d2a2bb53a9e", null, null, false, null, null, "e366dbc6-10e8-4907-a70e-dbf75281fef5", "Red", "87a81173-6876-469d-a551-05bd817efa8d" },
                    { "b980294c-8d14-40d1-8b71-9ecb9e654e9c", null, null, false, null, null, "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", "Red", "87a81173-6876-469d-a551-05bd817efa8d" },
                    { "cc6c6641-e8e6-4ddf-a1be-c9ec8dd4cc09", null, null, false, null, null, "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", "Red", "bdabb2a9-ec27-4d3a-a878-ccece8fbf127" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "05437c33-bbbb-4130-b5aa-124cc7955a91", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "2d3457d8-f713-408e-b7c1-1957b0242474", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "8baa66c6-7c2b-4d63-8665-a0878422671c", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "93caee66-aad9-4e08-9c9e-a3e796afc100", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "aa1c3c73-8c50-41de-bebd-903fdc7030b0", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "048c4d81-3fac-41e1-9ca7-bbb3bc876e80", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "2e225a09-bfff-4f83-82ae-2a8da2f904f5", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "67844f18-046f-453f-b368-deb96749fdff", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "6925f78f-234e-4fe7-956b-5f8cebad76d0", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "6c66d5f8-a5eb-4948-8572-f07663def263", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "7ce83e17-d2ca-4884-b40c-887dd862e5c4", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "7e0ba4d6-0acb-46d8-9e37-94998d261620", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "826048e2-4a9e-4e2a-8537-2c0da1df4d7c", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "df97464d-29ad-4635-8d5d-6e163de1acc3", false },
                    { "aeb982c9-7195-48c3-adcb-0075c92c7287", "e366dbc6-10e8-4907-a70e-dbf75281fef5", false }
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
