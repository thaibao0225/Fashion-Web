using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Fashion_Infrastructure.Data.StaticData;

namespace Fashion_Infrastructure.Data
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder builder)
        {
            // Category Table
            string newCategory_Id1 = Guid.NewGuid().ToString();
            builder.Entity<CategoriesTable>().HasData(
                new CategoriesTable()
                {
                    category_Id  = newCategory_Id1,
                    category_Name = "category_Name",
                    categpry_Description = "category_Description",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                }
            );

            // Product Table
            string newProduct_Id1 = Guid.NewGuid().ToString();

            builder.Entity<ProductsTable>().HasData(
                new ProductsTable()
                {
                    product_Id = newProduct_Id1,
                    product_Name = "Guard dog",
                    product_Description = "Guard dog",
                    product_ShortDescription = "Short Description",
                    product_Img1 = "img1",
                    product_Img2 = "img2",
                    product_Img3 = "img3",
                    product_Img4 = "img4",
                    product_Img5 = "img5",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                }
                );



        }
    }
}
