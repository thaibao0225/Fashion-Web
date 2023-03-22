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
                    { "9adc7c17-1f8e-4527-b0e3-ac5ea2162ec0", "a019a02d-5ffe-4d59-a37d-a141d9597fa6", "RolesTable", false, "Admin", "admin" },
                    { "ad248906-1815-4d41-9b63-392eeb113f7a", "a3190cd0-8235-43b1-8acb-840bc223e384", "RolesTable", false, "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8704b774-124e-4353-a85f-24da0fcc0313", 0, "", "629f273d-edce-4e1c-ac23-1a6f101d83cc", "UsersTable", "staff@gmail.com", true, "", false, "", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEEz+jFLZCXT3GRJqGznc0n45Wk+WKBMDaqmOsXuhUCBOU9P2HZPUTk7lIgVMejVNLA==", null, false, "30f38f54-95d0-4a15-a8d0-16466ec7e5ff", false, "Staff" },
                    { "ba532b7c-6631-420a-83eb-401605a41e7a", 0, "", "2a87fd56-add5-4534-b0b8-7dc275d51b1f", "UsersTable", "admin@gmail.com", true, "", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK9MOCFkRqEJoJQQFCjwEVzlWUdcss+CKoYJeKCHihSJVFb//Hj/x2X9WmwPVjbvCg==", null, false, "2f89c0eb-e39a-4936-8dac-2f38f2a1ce23", false, "Admin" },
                    { "cb97e0a7-bb80-4210-bf07-2987b95ed23d", 0, "", "ecc575b5-10a5-44c5-a1f4-0a02fd98852e", "UsersTable", "staff2@gmail.com", true, "", false, "", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEBHKET3jXi0fypAWrYUU6+rvGXqFlJNDQnwWCv003byBtHD+vgyAex8fPzdC5IChlw==", null, false, "befbc03b-3a29-4ce3-95d6-08b806afd4f5", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Description", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "2d81d097-a481-4848-b08d-e36d7d03e161", null, null, false, null, null, "", false, "Air Force 1" },
                    { "667ee33c-102e-4867-be70-67557b81fca0", null, null, false, null, null, "", false, "NMD" },
                    { "8ea6b7ae-38f8-49e1-901b-7d236db243b0", null, null, false, null, null, "", false, "For Her" },
                    { "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", null, null, false, null, null, "", false, "Air Jordan 1" },
                    { "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", null, null, false, null, null, "", false, "Yeezy" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "color_Id", "color_IdDelete", "color_Name" },
                values: new object[,]
                {
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", false, "Green" },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", false, "Red" },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", false, "Yellow" },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", false, "Black" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "size_Id", "size_IsDelete", "size_Name" },
                values: new object[,]
                {
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", false, 38 },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", false, 35 },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", false, 35 },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", false, 36 },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", false, 37 },
                    { "b729df62-1400-484e-ad07-006180764855", false, 39 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9adc7c17-1f8e-4527-b0e3-ac5ea2162ec0", "8704b774-124e-4353-a85f-24da0fcc0313" },
                    { "ad248906-1815-4d41-9b63-392eeb113f7a", "ba532b7c-6631-420a-83eb-401605a41e7a" },
                    { "9adc7c17-1f8e-4527-b0e3-ac5ea2162ec0", "cb97e0a7-bb80-4210-bf07-2987b95ed23d" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "bill_Code", "bill_CreateOn", "bill_IsConfirm", "bill_IsPayment", "bill_Price", "bill_ProductColorList", "bill_ProductPriceList", "bill_ProductSizeList", "bill_ProductUnitList", "bill_ProductsIdList", "bill_UserId" },
                values: new object[,]
                {
                    { "139fb0ca-123e-4841-b97d-06315431a2d1", "", new DateTime(2023, 3, 23, 0, 41, 20, 741, DateTimeKind.Local).AddTicks(254), false, "", new DateTime(2023, 3, 23, 0, 41, 20, 742, DateTimeKind.Local).AddTicks(250), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "60d3611a-b1b7-48ea-96f3-d80b9884213e|6ad3c1c8-09f7-4388-82d4-aafcd77f6940|9383bda5-e8c2-4351-b071-f0291ddef67f|10867dcf-3634-4316-a4bb-db0ab182e2ec|", "ba532b7c-6631-420a-83eb-401605a41e7a" },
                    { "1451d77a-a185-4d10-905c-2bc0a7f629ae", "", new DateTime(2023, 3, 23, 0, 41, 20, 741, DateTimeKind.Local).AddTicks(254), false, "", new DateTime(2023, 3, 23, 0, 41, 20, 742, DateTimeKind.Local).AddTicks(250), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "9f93172b-77ca-4dde-b634-6a1768975b28|769a1b20-df41-4118-8b17-d5b9468a9079|88457fe7-6ec7-4f01-b039-61aafde239b6|a4f42a4b-b9ab-46a7-b769-72f5962c4e8c|", "8704b774-124e-4353-a85f-24da0fcc0313" },
                    { "67bf096d-6f71-4621-bcad-41b3fe09ede1", "", new DateTime(2023, 3, 23, 0, 41, 20, 741, DateTimeKind.Local).AddTicks(254), false, "", new DateTime(2023, 3, 23, 0, 41, 20, 742, DateTimeKind.Local).AddTicks(250), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 0.0, "Red|Black|Green|Yellow", "10|10|10|10|", "X|XL|S|M", "1|1|1|1|", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3|b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c|1a271ff1-e455-4a85-bcc3-6ba0b35c3b89|b245e5c8-ab89-478c-9243-8194eb6e1e4d|", "cb97e0a7-bb80-4210-bf07-2987b95ed23d" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[,]
                {
                    { "10867dcf-3634-4316-a4bb-db0ab182e2ec", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", "StaticFiles/p-8/product-1.png", "StaticFiles/p-8/product-2.png", "StaticFiles/p-8/product-3.png", "StaticFiles/p-8/product-4.png", "StaticFiles/p-8/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100", 10, "Type1", 10 },
                    { "1a271ff1-e455-4a85-bcc3-6ba0b35c3b89", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 ’07 LX Leap High FD4622-131", "StaticFiles/p-11/product-1.png", "StaticFiles/p-11/product-2.png", "StaticFiles/p-11/product-3.png", "StaticFiles/p-11/product-4.png", "StaticFiles/p-11/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LX Leap High FD4622-131", 10, "Type1", 10 },
                    { "23c6abde-4590-4235-bc7f-b72710b379e2", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", "StaticFiles/p-20/product-1.png", "StaticFiles/p-20/product-2.png", "StaticFiles/p-20/product-3.png", "StaticFiles/p-20/product-4.png", "StaticFiles/p-20/product-5.png", "Adidas BOSSK NMD_R1", 10.0, 4, "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792", 10, "Type1", 10 },
                    { "25c065c4-4acb-4f0c-a0d3-cccd917199a0", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Adidas NMD R1 Pixar ‘Black’ GX0997", "StaticFiles/p-22/product-1.png", "StaticFiles/p-22/product-2.png", "StaticFiles/p-22/product-3.png", "StaticFiles/p-22/product-4.png", "StaticFiles/p-22/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 Pixar ‘Black’ GX0997", 10, "Type1", 10 },
                    { "26d3c30b-b2fe-4777-96c7-0ca09274105a", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", "StaticFiles/p-30/product-1.png", "StaticFiles/p-30/product-2.png", "StaticFiles/p-30/product-3.png", "StaticFiles/p-30/product-4.png", "StaticFiles/p-30/product-5.png", "MLB Mule Playball Fur", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD", 10, "Type1", 10 },
                    { "2adedc2c-fa8e-4f10-baf1-a5a6c9ccbd92", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Adidas NMD R1 ‘Off White Sand’ FV1793", "StaticFiles/p-21/product-1.png", "StaticFiles/p-21/product-2.png", "StaticFiles/p-21/product-3.png", "StaticFiles/p-21/product-4.png", "StaticFiles/p-21/product-5.png", "Adidas NMD R1", 10.0, 4, "Adidas NMD R1 ‘Off White Sand’ FV1793", 10, "Type1", 10 },
                    { "3e2d6ddb-f35b-4df8-be79-750f2313f767", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", "StaticFiles/p-16/product-1.png", "StaticFiles/p-16/product-2.png", "StaticFiles/p-16/product-3.png", "StaticFiles/p-16/product-4.png", "StaticFiles/p-16/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060", 10, "Type1", 10 },
                    { "424ff46c-a81f-4fed-a342-89161a1825e9", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", "StaticFiles/p-18/product-1.png", "StaticFiles/p-18/product-2.png", "StaticFiles/p-18/product-3.png", "StaticFiles/p-18/product-4.png", "StaticFiles/p-18/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612", 10, "Type1", 10 },
                    { "487cc631-dd5c-4d66-a839-95f4f748050f", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", "StaticFiles/p-26/product-1.png", "StaticFiles/p-26/product-2.png", "StaticFiles/p-26/product-3.png", "StaticFiles/p-26/product-4.png", "StaticFiles/p-26/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS", 10, "Type1", 10 },
                    { "60d3611a-b1b7-48ea-96f3-d80b9884213e", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", "StaticFiles/p-5/product-1.png", "StaticFiles/p-5/product-2.png", "StaticFiles/p-5/product-3.png", "StaticFiles/p-5/product-4.png", "StaticFiles/p-5/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501", 10, "Type1", 10 },
                    { "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", "StaticFiles/p-6/product-1.png", "StaticFiles/p-6/product-2.png", "StaticFiles/p-6/product-3.png", "StaticFiles/p-6/product-4.png", "StaticFiles/p-6/product-5.png", "Nike Air Jordan 1 Low", 10.0, 4, "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201", 10, "Type1", 10 },
                    { "6ae0963d-7969-43aa-9f13-79998e0eb218", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", "StaticFiles/p-23/product-1.png", "StaticFiles/p-23/product-2.png", "StaticFiles/p-23/product-3.png", "StaticFiles/p-23/product-4.png", "StaticFiles/p-23/product-5.png", "Originals Unisex adidas", 10.0, 4, "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996", 10, "Type1", 10 },
                    { "705a9428-1524-4142-95b4-5cbcbcd54c2d", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", "StaticFiles/p-19/product-1.png", "StaticFiles/p-19/product-2.png", "StaticFiles/p-19/product-3.png", "StaticFiles/p-19/product-4.png", "StaticFiles/p-19/product-5.png", "Adidas NMD_R1", 10.0, 4, "Adidas NMD_R1 ‘Black Solar Red’ GZ9274", 10, "Type1", 10 },
                    { "712b8b74-7cac-47bd-987a-3b9b78070878", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", "StaticFiles/p-17/product-1.png", "StaticFiles/p-17/product-2.png", "StaticFiles/p-17/product-3.png", "StaticFiles/p-17/product-4.png", "StaticFiles/p-17/product-5.png", "Adidas Originals Yeezy", 10.0, 4, "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472", 10, "Type1", 10 },
                    { "769a1b20-df41-4118-8b17-d5b9468a9079", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", "StaticFiles/p-2/product-1.png", "StaticFiles/p-2/product-2.png", "StaticFiles/p-2/product-3.png", "StaticFiles/p-2/product-4.png", "StaticFiles/p-2/product-5.png", "Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110", 10, "Type1", 10 },
                    { "7b7dc639-667c-408e-8a52-c3ddd24caf7e", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", "StaticFiles/p-25/product-1.png", "StaticFiles/p-25/product-2.png", "StaticFiles/p-25/product-3.png", "StaticFiles/p-25/product-4.png", "StaticFiles/p-25/product-5.png", "MLB Playball", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS", 10, "Type1", 10 },
                    { "81c2cb74-0c83-41d5-988d-d368c023faf0", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", "StaticFiles/p-27/product-1.png", "StaticFiles/p-27/product-2.png", "StaticFiles/p-27/product-3.png", "StaticFiles/p-27/product-4.png", "StaticFiles/p-27/product-5.png", "MLB Playball Mule", 10.0, 4, "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD", 10, "Type1", 10 },
                    { "88457fe7-6ec7-4f01-b039-61aafde239b6", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", "StaticFiles/p-3/product-1.png", "StaticFiles/p-3/product-2.png", "StaticFiles/p-3/product-3.png", "StaticFiles/p-3/product-4.png", "StaticFiles/p-3/product-5.png", "Nike Air Jordan 1 Retro", 10.0, 4, "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001", 10, "Type1", 10 },
                    { "8bc63de7-19fc-4911-a0d7-dc6cbbf15232", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", "StaticFiles/p-29/product-1.png", "StaticFiles/p-29/product-2.png", "StaticFiles/p-29/product-3.png", "StaticFiles/p-29/product-4.png", "StaticFiles/p-29/product-5.png", "MLB Mule Playball", 10.0, 4, "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS", 10, "Type1", 10 },
                    { "8e24595b-1be1-4e33-9983-524256e712da", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", "StaticFiles/p-13/product-1.png", "StaticFiles/p-13/product-2.png", "StaticFiles/p-13/product-3.png", "StaticFiles/p-13/product-4.png", "StaticFiles/p-13/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540", 10, "Type1", 10 },
                    { "9383bda5-e8c2-4351-b071-f0291ddef67f", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", "StaticFiles/p-7/product-1.png", "StaticFiles/p-7/product-2.png", "StaticFiles/p-7/product-3.png", "StaticFiles/p-7/product-4.png", "StaticFiles/p-7/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001", 10, "Type1", 10 },
                    { "9f93172b-77ca-4dde-b634-6a1768975b28", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!", "StaticFiles/p-1/product-1.png", "StaticFiles/p-1/product-2.png", "StaticFiles/p-1/product-3.png", "StaticFiles/p-1/product-4.png", "StaticFiles/p-1/product-5.png", " Nike Air Jordan 1 Elevate", 5290000.0, 4, "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501", 10, "Type1", 10 },
                    { "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", null, null, false, null, null, "b0b39ffb-118a-4bb0-8565-c7814ccd6f8f", "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", "StaticFiles/p-4/product-1.png", "StaticFiles/p-4/product-2.png", "StaticFiles/p-4/product-3.png", "StaticFiles/p-4/product-4.png", "StaticFiles/p-4/product-5.png", "Nike Air Jordan 1 Mid", 10.0, 4, "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100", 10, "Type1", 10 },
                    { "ac8682e8-a1b5-42bb-9386-8cd6c71eac0e", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", "StaticFiles/p-14/product-1.png", "StaticFiles/p-14/product-2.png", "StaticFiles/p-14/product-3.png", "StaticFiles/p-14/product-4.png", "StaticFiles/p-14/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773", 10, "Type1", 10 },
                    { "b245e5c8-ab89-478c-9243-8194eb6e1e4d", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", "StaticFiles/p-12/product-1.png", "StaticFiles/p-12/product-2.png", "StaticFiles/p-12/product-3.png", "StaticFiles/p-12/product-4.png", "StaticFiles/p-12/product-5.png", "Nike Air Force 1", 10.0, 4, "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600", 10, "Type1", 10 },
                    { "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", "StaticFiles/p-10/product-1.png", "StaticFiles/p-10/product-2.png", "StaticFiles/p-10/product-3.png", "StaticFiles/p-10/product-4.png", "StaticFiles/p-10/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102", 10, "Type1", 10 },
                    { "c218ec36-600b-42de-bccc-a78896d0009c", null, null, false, null, null, "8ea6b7ae-38f8-49e1-901b-7d236db243b0", "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", "StaticFiles/p-28/product-1.png", "StaticFiles/p-28/product-2.png", "StaticFiles/p-28/product-3.png", "StaticFiles/p-28/product-4.png", "StaticFiles/p-28/product-5.png", "MLB Playball Origin Mule", 10.0, 4, "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L", 10, "Type1", 10 },
                    { "c26c1ca6-514a-426f-9f81-8203ec4bbde3", null, null, false, null, null, "d51b45c1-d670-4ede-9541-e4ccd5b7acb0", "Adidas Yeezy Boost 350 V2 Sesame F99710", "StaticFiles/p-15/product-1.png", "StaticFiles/p-15/product-2.png", "StaticFiles/p-15/product-3.png", "StaticFiles/p-15/product-4.png", "StaticFiles/p-15/product-5.png", "Adidas Yeezy Boost 350", 10.0, 4, "Adidas Yeezy Boost 350 V2 Sesame F99710", 10, "Type1", 10 },
                    { "ed952d6d-01f8-42ec-a79a-add965424751", null, null, false, null, null, "667ee33c-102e-4867-be70-67557b81fca0", "Adidas EQ19 Run H00933", "StaticFiles/p-24/product-1.png", "StaticFiles/p-24/product-2.png", "StaticFiles/p-24/product-3.png", "StaticFiles/p-24/product-4.png", "StaticFiles/p-24/product-5.png", "Adidas EQ19 Run H00933", 10.0, 4, "Adidas EQ19 Run H00933", 10, "Type1", 10 },
                    { "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", null, null, false, null, null, "2d81d097-a481-4848-b08d-e36d7d03e161", "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", "StaticFiles/p-9/product-1.png", "StaticFiles/p-9/product-2.png", "StaticFiles/p-9/product-3.png", "StaticFiles/p-9/product-4.png", "StaticFiles/p-9/product-5.png", "Nike Air Force 1 Low", 10.0, 4, "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120", 10, "Type1", 10 }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "1a271ff1-e455-4a85-bcc3-6ba0b35c3b89", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "23c6abde-4590-4235-bc7f-b72710b379e2", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "25c065c4-4acb-4f0c-a0d3-cccd917199a0", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "26d3c30b-b2fe-4777-96c7-0ca09274105a", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "2adedc2c-fa8e-4f10-baf1-a5a6c9ccbd92", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "3e2d6ddb-f35b-4df8-be79-750f2313f767", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "424ff46c-a81f-4fed-a342-89161a1825e9", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "487cc631-dd5c-4d66-a839-95f4f748050f", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "6ae0963d-7969-43aa-9f13-79998e0eb218", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "705a9428-1524-4142-95b4-5cbcbcd54c2d", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "712b8b74-7cac-47bd-987a-3b9b78070878", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "7b7dc639-667c-408e-8a52-c3ddd24caf7e", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "81c2cb74-0c83-41d5-988d-d368c023faf0", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "8bc63de7-19fc-4911-a0d7-dc6cbbf15232", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "8e24595b-1be1-4e33-9983-524256e712da", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "ac8682e8-a1b5-42bb-9386-8cd6c71eac0e", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "b245e5c8-ab89-478c-9243-8194eb6e1e4d", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "c218ec36-600b-42de-bccc-a78896d0009c", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "c26c1ca6-514a-426f-9f81-8203ec4bbde3", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "ed952d6d-01f8-42ec-a79a-add965424751", false },
                    { "2e6bb710-752d-439b-81ac-ddb8cbf97e8c", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "1a271ff1-e455-4a85-bcc3-6ba0b35c3b89", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "23c6abde-4590-4235-bc7f-b72710b379e2", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "25c065c4-4acb-4f0c-a0d3-cccd917199a0", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "26d3c30b-b2fe-4777-96c7-0ca09274105a", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "2adedc2c-fa8e-4f10-baf1-a5a6c9ccbd92", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "3e2d6ddb-f35b-4df8-be79-750f2313f767", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "424ff46c-a81f-4fed-a342-89161a1825e9", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "487cc631-dd5c-4d66-a839-95f4f748050f", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "6ae0963d-7969-43aa-9f13-79998e0eb218", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "705a9428-1524-4142-95b4-5cbcbcd54c2d", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "712b8b74-7cac-47bd-987a-3b9b78070878", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "7b7dc639-667c-408e-8a52-c3ddd24caf7e", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "81c2cb74-0c83-41d5-988d-d368c023faf0", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "8bc63de7-19fc-4911-a0d7-dc6cbbf15232", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "8e24595b-1be1-4e33-9983-524256e712da", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "ac8682e8-a1b5-42bb-9386-8cd6c71eac0e", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "b245e5c8-ab89-478c-9243-8194eb6e1e4d", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "c218ec36-600b-42de-bccc-a78896d0009c", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "c26c1ca6-514a-426f-9f81-8203ec4bbde3", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "ed952d6d-01f8-42ec-a79a-add965424751", false },
                    { "7b2c09a8-8b5b-4555-845e-eaa80466763b", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "1a271ff1-e455-4a85-bcc3-6ba0b35c3b89", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "23c6abde-4590-4235-bc7f-b72710b379e2", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "25c065c4-4acb-4f0c-a0d3-cccd917199a0", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "26d3c30b-b2fe-4777-96c7-0ca09274105a", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "2adedc2c-fa8e-4f10-baf1-a5a6c9ccbd92", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "3e2d6ddb-f35b-4df8-be79-750f2313f767", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "424ff46c-a81f-4fed-a342-89161a1825e9", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "487cc631-dd5c-4d66-a839-95f4f748050f", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "6ae0963d-7969-43aa-9f13-79998e0eb218", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "705a9428-1524-4142-95b4-5cbcbcd54c2d", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "712b8b74-7cac-47bd-987a-3b9b78070878", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "7b7dc639-667c-408e-8a52-c3ddd24caf7e", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "81c2cb74-0c83-41d5-988d-d368c023faf0", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "8bc63de7-19fc-4911-a0d7-dc6cbbf15232", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "8e24595b-1be1-4e33-9983-524256e712da", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "ac8682e8-a1b5-42bb-9386-8cd6c71eac0e", false }
                });

            migrationBuilder.InsertData(
                table: "ColorInProduct",
                columns: new[] { "cip_ColorId", "cip_ProductId", "cip_IsDelete" },
                values: new object[,]
                {
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "b245e5c8-ab89-478c-9243-8194eb6e1e4d", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "c218ec36-600b-42de-bccc-a78896d0009c", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "c26c1ca6-514a-426f-9f81-8203ec4bbde3", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "ed952d6d-01f8-42ec-a79a-add965424751", false },
                    { "860cbe7b-5063-49ef-9dab-fe0dd158aee3", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "1a271ff1-e455-4a85-bcc3-6ba0b35c3b89", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "23c6abde-4590-4235-bc7f-b72710b379e2", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "25c065c4-4acb-4f0c-a0d3-cccd917199a0", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "26d3c30b-b2fe-4777-96c7-0ca09274105a", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "2adedc2c-fa8e-4f10-baf1-a5a6c9ccbd92", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "3e2d6ddb-f35b-4df8-be79-750f2313f767", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "424ff46c-a81f-4fed-a342-89161a1825e9", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "487cc631-dd5c-4d66-a839-95f4f748050f", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "6ae0963d-7969-43aa-9f13-79998e0eb218", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "705a9428-1524-4142-95b4-5cbcbcd54c2d", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "712b8b74-7cac-47bd-987a-3b9b78070878", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "7b7dc639-667c-408e-8a52-c3ddd24caf7e", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "81c2cb74-0c83-41d5-988d-d368c023faf0", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "8bc63de7-19fc-4911-a0d7-dc6cbbf15232", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "8e24595b-1be1-4e33-9983-524256e712da", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "ac8682e8-a1b5-42bb-9386-8cd6c71eac0e", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "b245e5c8-ab89-478c-9243-8194eb6e1e4d", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "c218ec36-600b-42de-bccc-a78896d0009c", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "c26c1ca6-514a-426f-9f81-8203ec4bbde3", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "ed952d6d-01f8-42ec-a79a-add965424751", false },
                    { "d094391d-9208-4ffb-a46d-ee018ccc5ab7", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "9383bda5-e8c2-4351-b071-f0291ddef67f", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "0edbbeb3-c014-4214-9bbb-d113ae504836", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "1ac84ea7-5c36-4ffb-9c2b-a2e606c256ea", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "4d6582fd-1b5c-4fbc-85e0-88bebfc45de0", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "4fd42937-082b-436a-acdd-e6f960a20282", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false }
                });

            migrationBuilder.InsertData(
                table: "SizeInProduct",
                columns: new[] { "sip_Id", "sip_ProductId", "sip_IsDelete" },
                values: new object[,]
                {
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "b006312c-c15f-4308-b853-4206bda4fe4a", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false },
                    { "b729df62-1400-484e-ad07-006180764855", "10867dcf-3634-4316-a4bb-db0ab182e2ec", false },
                    { "b729df62-1400-484e-ad07-006180764855", "60d3611a-b1b7-48ea-96f3-d80b9884213e", false },
                    { "b729df62-1400-484e-ad07-006180764855", "6ad3c1c8-09f7-4388-82d4-aafcd77f6940", false },
                    { "b729df62-1400-484e-ad07-006180764855", "769a1b20-df41-4118-8b17-d5b9468a9079", false },
                    { "b729df62-1400-484e-ad07-006180764855", "88457fe7-6ec7-4f01-b039-61aafde239b6", false },
                    { "b729df62-1400-484e-ad07-006180764855", "9383bda5-e8c2-4351-b071-f0291ddef67f", false },
                    { "b729df62-1400-484e-ad07-006180764855", "9f93172b-77ca-4dde-b634-6a1768975b28", false },
                    { "b729df62-1400-484e-ad07-006180764855", "a4f42a4b-b9ab-46a7-b769-72f5962c4e8c", false },
                    { "b729df62-1400-484e-ad07-006180764855", "b759b84f-a72e-4ea7-9aa2-312f4ab1bd1c", false },
                    { "b729df62-1400-484e-ad07-006180764855", "f88677ad-231f-4e6c-af2b-4e02b6a9b7d3", false }
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
