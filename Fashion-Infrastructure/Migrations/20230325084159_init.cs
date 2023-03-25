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
                    { "4413e7b3-8c69-4d07-81a3-a10b343b69a2", "9c359e39-e7cc-4032-9812-fb56dbe55c59", "RolesTable", false, "Admin", "admin" },
                    { "b90f4d1b-8656-45d3-bf61-e891729108ff", "feab7855-0b04-4647-88d8-793e7aacad4a", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e60ba1e-1f7b-4bfd-bbc3-cd2e4ca6c501", 0, "", "19f6d57b-e0f0-4068-b620-6236ad9292c6", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEAIsIeUN5Ck4TbVRyfvqKUcvdi2poxypffsH5CTaaVCnU+rKz4QD+75i4oFIoZI5Eg==", null, false, "c2ae6f90-00a4-42e2-b26d-da7b712b25d1", false, "Staff" },
                    { "400f4da8-4cc2-4d11-92bc-92b193caca14", 0, "", "ef2d3c40-3720-4655-a4ad-cfd6c96015cf", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEEsQxGJW+IP0ACyoUTnVDKgwA1st6uCqfWyE4JcbEJ9cNQYMXo//JAjtLrh2Ynu1Iw==", null, false, "5b4a60c6-1616-41d7-9e06-adf14c262db4", false, "Staff2" },
                    { "eef303fa-73ea-415b-8da8-f03c8996c2d3", 0, "", "4c0f4aad-f9ad-4452-baca-0319bef62947", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBVZOz7hF3rmaQ3xRRocuao6WF3QCzb3xSU54jC+WGRN1PCrw/zhC5C+xjXE0am4Kg==", null, false, "79645df1-9833-45c0-a095-f26f6b11a097", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", null, null, false, null, null, "", "NMD" },
                    { "3a7221c4-45ce-48f0-a817-db4099029e05", null, null, false, null, null, "", "Air Force 1" },
                    { "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", null, null, false, null, null, "", "Yeezy" },
                    { "5e15a885-19ba-4784-aec7-b132ddb10832", null, null, false, null, null, "", "Air Jordan 1" },
                    { "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", null, null, false, null, null, "", "For Her" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", false, "Red" },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", false, "Black" },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", false, "Green" },
                    { "f5399208-978f-4f84-a901-d73683b2a050", false, "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "299cd847-7368-40a0-b402-86793d283b88", false, 38 },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", false, 35 },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", false, 35 },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", false, 39 },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", false, 37 },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", false, 36 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4413e7b3-8c69-4d07-81a3-a10b343b69a2", "1e60ba1e-1f7b-4bfd-bbc3-cd2e4ca6c501" },
                    { "4413e7b3-8c69-4d07-81a3-a10b343b69a2", "400f4da8-4cc2-4d11-92bc-92b193caca14" },
                    { "b90f4d1b-8656-45d3-bf61-e891729108ff", "eef303fa-73ea-415b-8da8-f03c8996c2d3" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "574d562f-4e52-43ef-9d86-77328efa98fc", "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(1181), false, "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(6725), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "5df896fe-886a-4563-a7d6-7b81f43a48f3|aee0b280-3f71-4804-b48b-8191a0d0772b|8c9d5d1a-9164-4f20-9690-bed6175f8bb5|ef51e442-8c35-4f72-bcaa-37fa54580225|", "400f4da8-4cc2-4d11-92bc-92b193caca14" },
                    { "943adb69-1077-435c-bc37-000d29770c56", "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(1181), false, "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(6725), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "66d4d929-9382-4cd5-8497-e6d7795caadb|b884ef22-81a5-401a-9ba0-05176dcc53c9|bcf894f4-f22f-4d52-ae39-c49596c00ea9|a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435|", "1e60ba1e-1f7b-4bfd-bbc3-cd2e4ca6c501" },
                    { "f093bdc2-66fd-43a6-b765-3787638b4815", "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(1181), false, "", new DateTime(2023, 3, 25, 15, 41, 59, 121, DateTimeKind.Local).AddTicks(6725), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81|67dba0ab-b2b2-434c-a15f-71f831ea4679|65fb23c2-5002-481a-a8fc-4641ed30b99e|26e58f2d-fc90-482b-a515-3d8ae0b093c2|", "eef303fa-73ea-415b-8da8-f03c8996c2d3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "194f268a-1ab9-40d3-b371-10ff8f044b7e", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "26e58f2d-fc90-482b-a515-3d8ae0b093c2", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "4f0b5526-544a-4452-bf55-adcfa32cd140", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "542db538-cc21-42bd-93ef-275355b54033", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "5df896fe-886a-4563-a7d6-7b81f43a48f3", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 },
                    { "64e86739-2b3c-4230-8262-ac3a41a10169", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "65fb23c2-5002-481a-a8fc-4641ed30b99e", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "66d4d929-9382-4cd5-8497-e6d7795caadb", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "67dba0ab-b2b2-434c-a15f-71f831ea4679", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "693a7599-4fe0-4496-890c-3f5e9ec020c0", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "7c29cdce-d73e-44eb-af28-ca4f0f42dd34", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "82881bb4-411d-40be-b087-2ae8ad4389e0", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "8c9d5d1a-9164-4f20-9690-bed6175f8bb5", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "91ec97c3-3934-4307-9831-327478cc929a", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "9b4aae86-e3fd-4100-b36d-f997b3d1ff47", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "9e06e459-2e91-4224-a010-da563bca9c54", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "9fddf3cc-f048-4701-a5a3-04e232cc8687", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "a0e4b6a5-9e0b-4065-8253-3d49b4f52205", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "aee0b280-3f71-4804-b48b-8191a0d0772b", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "b71f05e5-c7a1-401b-afab-7b6184cb3e37", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "b884ef22-81a5-401a-9ba0-05176dcc53c9", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "bcf894f4-f22f-4d52-ae39-c49596c00ea9", null, null, false, null, null, "5e15a885-19ba-4784-aec7-b132ddb10832", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "cf21b4fe-8109-422c-affe-44912537f35d", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "ece404ed-935e-443d-abc2-9ddd5b03b36f", null, null, false, null, null, "9791d9e7-f40d-4dbf-9f88-ea2eeb825c07", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "ef51e442-8c35-4f72-bcaa-37fa54580225", null, null, false, null, null, "3a7221c4-45ce-48f0-a817-db4099029e05", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "f6379e2a-b212-4765-b894-a0d25528dd6a", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "fb826d12-f90f-4840-8a86-a2f9b02229dd", null, null, false, null, null, "1a415ad0-6579-40de-b538-bd5ca7cc4a2f", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "fd58106b-2575-4916-ab3d-68c74648c60a", null, null, false, null, null, "3db269ff-ef88-4deb-a1ee-894fe6c6bbe1", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "194f268a-1ab9-40d3-b371-10ff8f044b7e", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "4f0b5526-544a-4452-bf55-adcfa32cd140", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "542db538-cc21-42bd-93ef-275355b54033", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "64e86739-2b3c-4230-8262-ac3a41a10169", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "693a7599-4fe0-4496-890c-3f5e9ec020c0", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "7c29cdce-d73e-44eb-af28-ca4f0f42dd34", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "82881bb4-411d-40be-b087-2ae8ad4389e0", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "8c9d5d1a-9164-4f20-9690-bed6175f8bb5", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "91ec97c3-3934-4307-9831-327478cc929a", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "9b4aae86-e3fd-4100-b36d-f997b3d1ff47", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "9e06e459-2e91-4224-a010-da563bca9c54", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "9fddf3cc-f048-4701-a5a3-04e232cc8687", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "a0e4b6a5-9e0b-4065-8253-3d49b4f52205", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "b71f05e5-c7a1-401b-afab-7b6184cb3e37", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "cf21b4fe-8109-422c-affe-44912537f35d", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "ece404ed-935e-443d-abc2-9ddd5b03b36f", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "ef51e442-8c35-4f72-bcaa-37fa54580225", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "f6379e2a-b212-4765-b894-a0d25528dd6a", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "fb826d12-f90f-4840-8a86-a2f9b02229dd", false },
                    { "1028f55c-917d-44ff-ad08-18ae0ecce6ec", "fd58106b-2575-4916-ab3d-68c74648c60a", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "194f268a-1ab9-40d3-b371-10ff8f044b7e", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "4f0b5526-544a-4452-bf55-adcfa32cd140", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "542db538-cc21-42bd-93ef-275355b54033", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "64e86739-2b3c-4230-8262-ac3a41a10169", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "693a7599-4fe0-4496-890c-3f5e9ec020c0", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "7c29cdce-d73e-44eb-af28-ca4f0f42dd34", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "82881bb4-411d-40be-b087-2ae8ad4389e0", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "8c9d5d1a-9164-4f20-9690-bed6175f8bb5", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "91ec97c3-3934-4307-9831-327478cc929a", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "9b4aae86-e3fd-4100-b36d-f997b3d1ff47", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "9e06e459-2e91-4224-a010-da563bca9c54", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "9fddf3cc-f048-4701-a5a3-04e232cc8687", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "a0e4b6a5-9e0b-4065-8253-3d49b4f52205", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "b71f05e5-c7a1-401b-afab-7b6184cb3e37", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "cf21b4fe-8109-422c-affe-44912537f35d", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "ece404ed-935e-443d-abc2-9ddd5b03b36f", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "ef51e442-8c35-4f72-bcaa-37fa54580225", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "f6379e2a-b212-4765-b894-a0d25528dd6a", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "fb826d12-f90f-4840-8a86-a2f9b02229dd", false },
                    { "5fbdc58b-f2a7-4808-a302-fc0649022b12", "fd58106b-2575-4916-ab3d-68c74648c60a", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "194f268a-1ab9-40d3-b371-10ff8f044b7e", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "4f0b5526-544a-4452-bf55-adcfa32cd140", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "542db538-cc21-42bd-93ef-275355b54033", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "64e86739-2b3c-4230-8262-ac3a41a10169", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "693a7599-4fe0-4496-890c-3f5e9ec020c0", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "7c29cdce-d73e-44eb-af28-ca4f0f42dd34", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "82881bb4-411d-40be-b087-2ae8ad4389e0", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "8c9d5d1a-9164-4f20-9690-bed6175f8bb5", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "91ec97c3-3934-4307-9831-327478cc929a", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "9b4aae86-e3fd-4100-b36d-f997b3d1ff47", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "9e06e459-2e91-4224-a010-da563bca9c54", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "9fddf3cc-f048-4701-a5a3-04e232cc8687", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "a0e4b6a5-9e0b-4065-8253-3d49b4f52205", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "b71f05e5-c7a1-401b-afab-7b6184cb3e37", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "cf21b4fe-8109-422c-affe-44912537f35d", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "ece404ed-935e-443d-abc2-9ddd5b03b36f", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "ef51e442-8c35-4f72-bcaa-37fa54580225", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "f6379e2a-b212-4765-b894-a0d25528dd6a", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "fb826d12-f90f-4840-8a86-a2f9b02229dd", false },
                    { "da0c9feb-30af-4ede-9a93-206a432ec5c3", "fd58106b-2575-4916-ab3d-68c74648c60a", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "194f268a-1ab9-40d3-b371-10ff8f044b7e", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "4f0b5526-544a-4452-bf55-adcfa32cd140", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "542db538-cc21-42bd-93ef-275355b54033", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "64e86739-2b3c-4230-8262-ac3a41a10169", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "693a7599-4fe0-4496-890c-3f5e9ec020c0", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "7c29cdce-d73e-44eb-af28-ca4f0f42dd34", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "82881bb4-411d-40be-b087-2ae8ad4389e0", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "8c9d5d1a-9164-4f20-9690-bed6175f8bb5", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "91ec97c3-3934-4307-9831-327478cc929a", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "9b4aae86-e3fd-4100-b36d-f997b3d1ff47", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "9e06e459-2e91-4224-a010-da563bca9c54", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "9fddf3cc-f048-4701-a5a3-04e232cc8687", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "a0e4b6a5-9e0b-4065-8253-3d49b4f52205", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "b71f05e5-c7a1-401b-afab-7b6184cb3e37", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "cf21b4fe-8109-422c-affe-44912537f35d", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "ece404ed-935e-443d-abc2-9ddd5b03b36f", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "ef51e442-8c35-4f72-bcaa-37fa54580225", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "f6379e2a-b212-4765-b894-a0d25528dd6a", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "fb826d12-f90f-4840-8a86-a2f9b02229dd", false },
                    { "f5399208-978f-4f84-a901-d73683b2a050", "fd58106b-2575-4916-ab3d-68c74648c60a", false }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "comment_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "comment_ProductId", "comment_Text", "comment_UserId" },
                values: new object[,]
                {
                    { "47047367-f1b7-40a1-a60a-940bd90a1502", null, null, false, null, null, "66d4d929-9382-4cd5-8497-e6d7795caadb", "Red", "eef303fa-73ea-415b-8da8-f03c8996c2d3" },
                    { "a71a8ec3-0687-4e18-9737-07d489e8f028", null, null, false, null, null, "66d4d929-9382-4cd5-8497-e6d7795caadb", "Red", "1e60ba1e-1f7b-4bfd-bbc3-cd2e4ca6c501" },
                    { "b171e59a-de13-4beb-86f3-ef7148f745eb", null, null, false, null, null, "66d4d929-9382-4cd5-8497-e6d7795caadb", "Red", "400f4da8-4cc2-4d11-92bc-92b193caca14" },
                    { "fe5d333b-ee3f-429b-aa9c-9286839cacc5", null, null, false, null, null, "b884ef22-81a5-401a-9ba0-05176dcc53c9", "Red", "1e60ba1e-1f7b-4bfd-bbc3-cd2e4ca6c501" }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "299cd847-7368-40a0-b402-86793d283b88", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "299cd847-7368-40a0-b402-86793d283b88", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "299cd847-7368-40a0-b402-86793d283b88", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "3a4b6ccf-6eba-4e03-9b1b-efea3dd9f276", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "442adaea-b2c9-4701-8b69-c1939654f79b", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "6dd45276-4a83-4114-abf0-3104cd8397d8", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "70b0dce9-4477-4996-bc49-e5df811e6be2", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "26e58f2d-fc90-482b-a515-3d8ae0b093c2", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "5b23e71c-854e-46ca-bab9-6a2ac33b4a81", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "5df896fe-886a-4563-a7d6-7b81f43a48f3", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "65fb23c2-5002-481a-a8fc-4641ed30b99e", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "66d4d929-9382-4cd5-8497-e6d7795caadb", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "67dba0ab-b2b2-434c-a15f-71f831ea4679", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "a0fdfcd1-e9f1-41d9-a8ce-b1f761b0b435", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "aee0b280-3f71-4804-b48b-8191a0d0772b", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "b884ef22-81a5-401a-9ba0-05176dcc53c9", false },
                    { "e80d96c1-b107-40a3-b346-fb4c21c2b5b2", "bcf894f4-f22f-4d52-ae39-c49596c00ea9", false }
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
