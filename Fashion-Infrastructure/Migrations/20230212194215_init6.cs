using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_Infrastructure.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "category_Name", "categpry_Description" },
                values: new object[] { "438ade55-27e9-4a55-8dbb-d83ed9356207", "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "category_Name", "category_Description" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "BillsTablebill_Id", "CreateBy", "CreateOn", "IsDelete", "UpdateBy", "UpdateOn", "product_CategoryId", "product_Description", "product_Img1", "product_Img2", "product_Img3", "product_Img4", "product_Img5", "product_Name", "product_Price", "product_Rate", "product_ShortDescription", "product_Sold", "product_Type", "product_ViewNumber" },
                values: new object[] { "2c5bb956-9d5f-440a-81b7-f2b530452f87", null, "CreateBy", "CreateOn", false, "UpdateBy", "UpdateOn", "438ade55-27e9-4a55-8dbb-d83ed9356207", "Guard dog", "img1", "img2", "img3", "img4", "img5", "Guard dog", 10.0, 4, "Short Description", 10, "Type1", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "2c5bb956-9d5f-440a-81b7-f2b530452f87");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "category_Id",
                keyValue: "438ade55-27e9-4a55-8dbb-d83ed9356207");
        }
    }
}
