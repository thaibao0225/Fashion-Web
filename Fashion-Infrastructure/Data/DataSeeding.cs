using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Fashion_Infrastructure.Data.StaticData;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Fashion_Infrastructure.Data
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder builder)
        {
            


            // Table Roles
            string newRole_Id1 = Guid.NewGuid().ToString();
            string newRole_Id2 = Guid.NewGuid().ToString();

            builder.Entity<RolesTable>().HasData(
                new RolesTable()
                {
                    Id = newRole_Id1,
                    Name = "ADMIN",
                    NormalizedName = "admin",
                    IsDelete = false
                },
                new RolesTable()
                {
                    Id = newRole_Id2,
                    Name = "STAFF",
                    NormalizedName = "staff",
                    IsDelete = false
                }
                );

            // Users Table

            string newUser_Id1 = Guid.NewGuid().ToString();
            string newUser_Id2 = Guid.NewGuid().ToString();
            string newUser_Id3 = Guid.NewGuid().ToString();
            string newUser_Id4 = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<UsersTable>();

            builder.Entity<UsersTable>().HasData(
                new UsersTable()
                {
                    Id = newUser_Id1,
                    UserName = "Staft",
                    FirstName = "",
                    LastName = "",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    Email = "staff@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    IsDelete = false
                },
                new UsersTable()
                {
                    Id = newUser_Id2,
                    UserName = "Admin",
                    FirstName = "",
                    LastName = "",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    IsDelete = false
                }
                );


            //  Table User Role
            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   RoleId = newRole_Id1,
                   UserId = newUser_Id1
               },
               new IdentityUserRole<string>
               {
                   RoleId = newRole_Id2,
                   UserId = newUser_Id2
               });


            // Table Bills
            string newBill_Id1 = Guid.NewGuid().ToString();
            string newBill_Id2 = Guid.NewGuid().ToString();
            string newBill_Id3 = Guid.NewGuid().ToString();


            builder.Entity<BillsTable>().HasData(
                new BillsTable()
                {
                    bill_Id = newBill_Id1,
                    bill_Code = 1,
                    bill_UserId = newUser_Id1,
                    bill_Price = 0,
                    bill_ProductsIdList = "",
                    bill_ProductPriceList = "",
                    bill_ProductUnitList = "",
                    bill_ProductColorList = "",
                    bill_ProductSizeList = "",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                },
                new BillsTable()
                {
                    bill_Id = newBill_Id2,
                    bill_Code = 1,
                    bill_UserId = newUser_Id1,
                    bill_Price = 0,
                    bill_ProductsIdList = "",
                    bill_ProductPriceList = "",
                    bill_ProductUnitList = "",
                    bill_ProductColorList = "",
                    bill_ProductSizeList = "",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                },
                new BillsTable()
                {
                    bill_Id = newBill_Id3,
                    bill_Code = 1,
                    bill_UserId = newUser_Id2,
                    bill_Price = 0,
                    bill_ProductsIdList = "",
                    bill_ProductPriceList = "",
                    bill_ProductUnitList = "",
                    bill_ProductColorList = "",
                    bill_ProductSizeList = "",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                }
                );


            // Category Table
            string newCategory_Id1 = Guid.NewGuid().ToString();
            builder.Entity<CategoriesTable>().HasData(
                new CategoriesTable()
                {
                    category_Id = newCategory_Id1,
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
