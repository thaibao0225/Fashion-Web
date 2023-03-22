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
                    Name = "Admin",
                    NormalizedName = "admin",
                    IsDelete = false
                },
                new RolesTable()
                {
                    Id = newRole_Id2,
                    Name = "Staff",
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
                    UserName = "Staff",
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
                },
                new UsersTable()
                {
                    Id = newUser_Id3,
                    UserName = "Staff2",
                    FirstName = "",
                    LastName = "",
                    NormalizedUserName = "STAFF2@GMAIL.COM",
                    NormalizedEmail = "STAFF2@GMAIL.COM",
                    Email = "staff2@gmail.com",
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
               },
               new IdentityUserRole<string>
               {
                   RoleId = newRole_Id1,
                   UserId = newUser_Id3
               });


            // Category Table
            string newCategory_Id1 = Guid.NewGuid().ToString();
            string newCategory_Id2 = Guid.NewGuid().ToString();
            string newCategory_Id3 = Guid.NewGuid().ToString();
            string newCategory_Id4 = Guid.NewGuid().ToString();
            string newCategory_Id5 = Guid.NewGuid().ToString();


            builder.Entity<CategoriesTable>().HasData(
                new CategoriesTable()
                {
                    category_Id = newCategory_Id1,
                    category_Name = "Air Jordan 1",
                    //categpry_Description = "category_Description",
                    IsDelete = false
                },
                new CategoriesTable()
                {
                    category_Id = newCategory_Id2,
                    category_Name = "Air Force 1",
                    //categpry_Description = "category_Description",
                    IsDelete = false
                },
                new CategoriesTable()
                {
                    category_Id = newCategory_Id3,
                    category_Name = "Yeezy",
                    //categpry_Description = "category_Description",
                    IsDelete = false
                },
                new CategoriesTable()
                {
                    category_Id = newCategory_Id4,
                    category_Name = "NMD",
                    //categpry_Description = "category_Description",
                    IsDelete = false
                },
                new CategoriesTable()
                {
                    category_Id = newCategory_Id5,
                    category_Name = "For Her",
                    //categpry_Description = "category_Description",
                    IsDelete = false
                }
            );

            // Product Table
            string newProduct_Id1 = Guid.NewGuid().ToString();
            string newProduct_Id2 = Guid.NewGuid().ToString();
            string newProduct_Id3 = Guid.NewGuid().ToString();
            string newProduct_Id4 = Guid.NewGuid().ToString();
            string newProduct_Id5 = Guid.NewGuid().ToString();
            string newProduct_Id6 = Guid.NewGuid().ToString();
            string newProduct_Id7 = Guid.NewGuid().ToString();
            string newProduct_Id8 = Guid.NewGuid().ToString();
            string newProduct_Id9 = Guid.NewGuid().ToString();
            string newProduct_Id10 = Guid.NewGuid().ToString();
            string newProduct_Id11 = Guid.NewGuid().ToString();
            string newProduct_Id12 = Guid.NewGuid().ToString();
            string newProduct_Id13 = Guid.NewGuid().ToString();
            string newProduct_Id14 = Guid.NewGuid().ToString();
            string newProduct_Id15 = Guid.NewGuid().ToString();
            string newProduct_Id16 = Guid.NewGuid().ToString();
            string newProduct_Id17 = Guid.NewGuid().ToString();
            string newProduct_Id18 = Guid.NewGuid().ToString();
            string newProduct_Id19 = Guid.NewGuid().ToString();
            string newProduct_Id20 = Guid.NewGuid().ToString();
            string newProduct_Id21 = Guid.NewGuid().ToString();
            string newProduct_Id22 = Guid.NewGuid().ToString();
            string newProduct_Id23 = Guid.NewGuid().ToString();
            string newProduct_Id24 = Guid.NewGuid().ToString();
            string newProduct_Id25 = Guid.NewGuid().ToString();
            string newProduct_Id26 = Guid.NewGuid().ToString();
            string newProduct_Id27 = Guid.NewGuid().ToString();
            string newProduct_Id28 = Guid.NewGuid().ToString();
            string newProduct_Id29 = Guid.NewGuid().ToString();
            string newProduct_Id30 = Guid.NewGuid().ToString();

            builder.Entity<ProductsTable>().HasData(
                new ProductsTable()
                {
                    product_Id = newProduct_Id1,
                    product_Name = " Nike Air Jordan 1 Elevate",
                    product_Description = "Nike Air Jordan 1 Low Elevate Low ‘Iced Lilac’ hiện đã có sẵn tại Sneaker Daily Shop, đừng bỏ lỡ cơ hội của mình nhé!",
                    product_ShortDescription = "Nike Air Jordan 1 Elevate Low ‘Iced Lilac’ DH7004-501",
                    product_Img1 = "StaticFiles/p-1/product-1.png",
                    product_Img2 = "StaticFiles/p-1/product-2.png",
                    product_Img3 = "StaticFiles/p-1/product-3.png",
                    product_Img4 = "StaticFiles/p-1/product-4.png",
                    product_Img5 = "StaticFiles/p-1/product-5.png",
                    product_Price = 5290000,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id2,
                    product_Name = "Nike Air Jordan 1 Elevate",
                    product_Description = "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110",
                    product_ShortDescription = "Nike Air Jordan 1 Elevate Low Neutral Grey (Women’s) DH7004-110",
                    product_Img1 = "StaticFiles/p-2/product-1.png",
                    product_Img2 = "StaticFiles/p-2/product-2.png",
                    product_Img3 = "StaticFiles/p-2/product-3.png",
                    product_Img4 = "StaticFiles/p-2/product-4.png",
                    product_Img5 = "StaticFiles/p-2/product-5.png",
                    product_Price = 5290000,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id3,
                    product_Name = "Nike Air Jordan 1 Retro",
                    product_Description = "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001",
                    product_ShortDescription = "Nike Air Jordan 1 Retro High 85 ‘Black White’ BQ4422-001",
                    product_Img1 = "StaticFiles/p-3/product-1.png",
                    product_Img2 = "StaticFiles/p-3/product-2.png",
                    product_Img3 = "StaticFiles/p-3/product-3.png",
                    product_Img4 = "StaticFiles/p-3/product-4.png",
                    product_Img5 = "StaticFiles/p-3/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id4,
                    product_Name = "Nike Air Jordan 1 Mid",
                    product_Description = "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100",
                    product_ShortDescription = "Nike Air Jordan 1 Mid SE ‘Coconut Milk’ DV1302-100",
                    product_Img1 = "StaticFiles/p-4/product-1.png",
                    product_Img2 = "StaticFiles/p-4/product-2.png",
                    product_Img3 = "StaticFiles/p-4/product-3.png",
                    product_Img4 = "StaticFiles/p-4/product-4.png",
                    product_Img5 = "StaticFiles/p-4/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id5,
                    product_Name = "Nike Air Jordan 1 Low",
                    product_Description = "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501",
                    product_ShortDescription = "Nike Air Jordan 1 Low ‘Barely Grape’ (W) DC0774-501",
                    product_Img1 = "StaticFiles/p-5/product-1.png",
                    product_Img2 = "StaticFiles/p-5/product-2.png",
                    product_Img3 = "StaticFiles/p-5/product-3.png",
                    product_Img4 = "StaticFiles/p-5/product-4.png",
                    product_Img5 = "StaticFiles/p-5/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id6,
                    product_Name = "Nike Air Jordan 1 Low",
                    product_Description = "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201",
                    product_ShortDescription = "Nike Air Jordan 1 Low ‘Desert’ (W) DC0774-201",
                    product_Img1 = "StaticFiles/p-6/product-1.png",
                    product_Img2 = "StaticFiles/p-6/product-2.png",
                    product_Img3 = "StaticFiles/p-6/product-3.png",
                    product_Img4 = "StaticFiles/p-6/product-4.png",
                    product_Img5 = "StaticFiles/p-6/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id1,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id7,
                    product_Name = "Nike Air Force 1",
                    product_Description = "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001",
                    product_ShortDescription = "Nike Air Force 1 ’07 LV8 ‘Black Sail’ DV0794-001",
                    product_Img1 = "StaticFiles/p-7/product-1.png",
                    product_Img2 = "StaticFiles/p-7/product-2.png",
                    product_Img3 = "StaticFiles/p-7/product-3.png",
                    product_Img4 = "StaticFiles/p-7/product-4.png",
                    product_Img5 = "StaticFiles/p-7/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id8,
                    product_Name = "Nike Air Force 1",
                    product_Description = "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100",
                    product_ShortDescription = "Nike Air Force 1 ’07 LV8 ‘Sanddrift Sail’ DV0794-100",
                    product_Img1 = "StaticFiles/p-8/product-1.png",
                    product_Img2 = "StaticFiles/p-8/product-2.png",
                    product_Img3 = "StaticFiles/p-8/product-3.png",
                    product_Img4 = "StaticFiles/p-8/product-4.png",
                    product_Img5 = "StaticFiles/p-8/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id9,
                    product_Name = "Nike Air Force 1 Low",
                    product_Description = "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120",
                    product_ShortDescription = "Nike Air Force 1 Low Shadow ‘Leopard’ CI0919-120",
                    product_Img1 = "StaticFiles/p-9/product-1.png",
                    product_Img2 = "StaticFiles/p-9/product-2.png",
                    product_Img3 = "StaticFiles/p-9/product-3.png",
                    product_Img4 = "StaticFiles/p-9/product-4.png",
                    product_Img5 = "StaticFiles/p-9/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id10,
                    product_Name = "Nike Air Force 1 Low",
                    product_Description = "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102",
                    product_ShortDescription = "Nike Air Force 1 Low Shadow ‘Summit White University Red Black’ DR7883-102",
                    product_Img1 = "StaticFiles/p-10/product-1.png",
                    product_Img2 = "StaticFiles/p-10/product-2.png",
                    product_Img3 = "StaticFiles/p-10/product-3.png",
                    product_Img4 = "StaticFiles/p-10/product-4.png",
                    product_Img5 = "StaticFiles/p-10/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id11,
                    product_Name = "Nike Air Force 1",
                    product_Description = "Nike Air Force 1 ’07 LX Leap High FD4622-131",
                    product_ShortDescription = "Nike Air Force 1 ’07 LX Leap High FD4622-131",
                    product_Img1 = "StaticFiles/p-11/product-1.png",
                    product_Img2 = "StaticFiles/p-11/product-2.png",
                    product_Img3 = "StaticFiles/p-11/product-3.png",
                    product_Img4 = "StaticFiles/p-11/product-4.png",
                    product_Img5 = "StaticFiles/p-11/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id12,
                    product_Name = "Nike Air Force 1",
                    product_Description = "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600",
                    product_ShortDescription = "Nike Air Force 1 ’07 Retro Color Of The Month University Red White FD7039-600",
                    product_Img1 = "StaticFiles/p-12/product-1.png",
                    product_Img2 = "StaticFiles/p-12/product-2.png",
                    product_Img3 = "StaticFiles/p-12/product-3.png",
                    product_Img4 = "StaticFiles/p-12/product-4.png",
                    product_Img5 = "StaticFiles/p-12/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id2,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id13,
                    product_Name = "Adidas Yeezy Boost 350",
                    product_Description = "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540",
                    product_ShortDescription = "Adidas Yeezy Boost 350 V2 ‘Onyx’ HQ4540",
                    product_Img1 = "StaticFiles/p-13/product-1.png",
                    product_Img2 = "StaticFiles/p-13/product-2.png",
                    product_Img3 = "StaticFiles/p-13/product-3.png",
                    product_Img4 = "StaticFiles/p-13/product-4.png",
                    product_Img5 = "StaticFiles/p-13/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id14,
                    product_Name = "Adidas Yeezy Boost 350",
                    product_Description = "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773",
                    product_ShortDescription = "Adidas Yeezy Boost 350 V2 ‘MX Oat’ GW3773",
                    product_Img1 = "StaticFiles/p-14/product-1.png",
                    product_Img2 = "StaticFiles/p-14/product-2.png",
                    product_Img3 = "StaticFiles/p-14/product-3.png",
                    product_Img4 = "StaticFiles/p-14/product-4.png",
                    product_Img5 = "StaticFiles/p-14/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id15,
                    product_Name = "Adidas Yeezy Boost 350",
                    product_Description = "Adidas Yeezy Boost 350 V2 Sesame F99710",
                    product_ShortDescription = "Adidas Yeezy Boost 350 V2 Sesame F99710",
                    product_Img1 = "StaticFiles/p-15/product-1.png",
                    product_Img2 = "StaticFiles/p-15/product-2.png",
                    product_Img3 = "StaticFiles/p-15/product-3.png",
                    product_Img4 = "StaticFiles/p-15/product-4.png",
                    product_Img5 = "StaticFiles/p-15/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id16,
                    product_Name = "Adidas Yeezy Boost 350",
                    product_Description = "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060",
                    product_ShortDescription = "Adidas Yeezy Boost 350 V2 ‘Salt’ HQ2060",
                    product_Img1 = "StaticFiles/p-16/product-1.png",
                    product_Img2 = "StaticFiles/p-16/product-2.png",
                    product_Img3 = "StaticFiles/p-16/product-3.png",
                    product_Img4 = "StaticFiles/p-16/product-4.png",
                    product_Img5 = "StaticFiles/p-16/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id17,
                    product_Name = "Adidas Originals Yeezy",
                    product_Description = "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472",
                    product_ShortDescription = "Adidas Originals Yeezy Foam Runner ‘Stone Sage’ GX4472",
                    product_Img1 = "StaticFiles/p-17/product-1.png",
                    product_Img2 = "StaticFiles/p-17/product-2.png",
                    product_Img3 = "StaticFiles/p-17/product-3.png",
                    product_Img4 = "StaticFiles/p-17/product-4.png",
                    product_Img5 = "StaticFiles/p-17/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id18,
                    product_Name = "Adidas Yeezy Boost 350",
                    product_Description = "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612",
                    product_ShortDescription = "Adidas Yeezy Boost 350 V2 ‘Core Black Red’ BY9612",
                    product_Img1 = "StaticFiles/p-18/product-1.png",
                    product_Img2 = "StaticFiles/p-18/product-2.png",
                    product_Img3 = "StaticFiles/p-18/product-3.png",
                    product_Img4 = "StaticFiles/p-18/product-4.png",
                    product_Img5 = "StaticFiles/p-18/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id3,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id19,
                    product_Name = "Adidas NMD_R1",
                    product_Description = "Adidas NMD_R1 ‘Black Solar Red’ GZ9274",
                    product_ShortDescription = "Adidas NMD_R1 ‘Black Solar Red’ GZ9274",
                    product_Img1 = "StaticFiles/p-19/product-1.png",
                    product_Img2 = "StaticFiles/p-19/product-2.png",
                    product_Img3 = "StaticFiles/p-19/product-3.png",
                    product_Img4 = "StaticFiles/p-19/product-4.png",
                    product_Img5 = "StaticFiles/p-19/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id20,
                    product_Name = "Adidas BOSSK NMD_R1",
                    product_Description = "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792",
                    product_ShortDescription = "Adidas BOSSK NMD_R1 SPECTOO ‘Black Yellow’ GX6792",
                    product_Img1 = "StaticFiles/p-20/product-1.png",
                    product_Img2 = "StaticFiles/p-20/product-2.png",
                    product_Img3 = "StaticFiles/p-20/product-3.png",
                    product_Img4 = "StaticFiles/p-20/product-4.png",
                    product_Img5 = "StaticFiles/p-20/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id21,
                    product_Name = "Adidas NMD R1",
                    product_Description = "Adidas NMD R1 ‘Off White Sand’ FV1793",
                    product_ShortDescription = "Adidas NMD R1 ‘Off White Sand’ FV1793",
                    product_Img1 = "StaticFiles/p-21/product-1.png",
                    product_Img2 = "StaticFiles/p-21/product-2.png",
                    product_Img3 = "StaticFiles/p-21/product-3.png",
                    product_Img4 = "StaticFiles/p-21/product-4.png",
                    product_Img5 = "StaticFiles/p-21/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id22,
                    product_Name = "Adidas NMD R1",
                    product_Description = "Adidas NMD R1 Pixar ‘Black’ GX0997",
                    product_ShortDescription = "Adidas NMD R1 Pixar ‘Black’ GX0997",
                    product_Img1 = "StaticFiles/p-22/product-1.png",
                    product_Img2 = "StaticFiles/p-22/product-2.png",
                    product_Img3 = "StaticFiles/p-22/product-3.png",
                    product_Img4 = "StaticFiles/p-22/product-4.png",
                    product_Img5 = "StaticFiles/p-22/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id23,
                    product_Name = "Originals Unisex adidas",
                    product_Description = "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996",
                    product_ShortDescription = "Originals Unisex adidas Nmd R1 ‘Cloud White’ GX0996",
                    product_Img1 = "StaticFiles/p-23/product-1.png",
                    product_Img2 = "StaticFiles/p-23/product-2.png",
                    product_Img3 = "StaticFiles/p-23/product-3.png",
                    product_Img4 = "StaticFiles/p-23/product-4.png",
                    product_Img5 = "StaticFiles/p-23/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id24,
                    product_Name = "Adidas EQ19 Run H00933",
                    product_Description = "Adidas EQ19 Run H00933",
                    product_ShortDescription = "Adidas EQ19 Run H00933",
                    product_Img1 = "StaticFiles/p-24/product-1.png",
                    product_Img2 = "StaticFiles/p-24/product-2.png",
                    product_Img3 = "StaticFiles/p-24/product-3.png",
                    product_Img4 = "StaticFiles/p-24/product-4.png",
                    product_Img5 = "StaticFiles/p-24/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id4,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id25,
                    product_Name = "MLB Playball",
                    product_Description = "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS",
                    product_ShortDescription = "MLB Playball Mule Dia Monogram New York Yankees ‘Black’ 3AMUMDA2N-50BKS",
                    product_Img1 = "StaticFiles/p-25/product-1.png",
                    product_Img2 = "StaticFiles/p-25/product-2.png",
                    product_Img3 = "StaticFiles/p-25/product-3.png",
                    product_Img4 = "StaticFiles/p-25/product-4.png",
                    product_Img5 = "StaticFiles/p-25/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id26,
                    product_Name = "MLB Playball Mule",
                    product_Description = "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS",
                    product_ShortDescription = "MLB Playball Mule Dia Monogram New York Yankees ‘Beige’ 3AMUMDA2N-50BGS",
                    product_Img1 = "StaticFiles/p-26/product-1.png",
                    product_Img2 = "StaticFiles/p-26/product-2.png",
                    product_Img3 = "StaticFiles/p-26/product-3.png",
                    product_Img4 = "StaticFiles/p-26/product-4.png",
                    product_Img5 = "StaticFiles/p-26/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id27,
                    product_Name = "MLB Playball Mule",
                    product_Description = "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD",
                    product_ShortDescription = "MLB Playball Mule Dia Monogram New York Yankees ‘Cream’ 3AMUM212N-50BGD",
                    product_Img1 = "StaticFiles/p-27/product-1.png",
                    product_Img2 = "StaticFiles/p-27/product-2.png",
                    product_Img3 = "StaticFiles/p-27/product-3.png",
                    product_Img4 = "StaticFiles/p-27/product-4.png",
                    product_Img5 = "StaticFiles/p-27/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id28,
                    product_Name = "MLB Playball Origin Mule",
                    product_Description = "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L",
                    product_ShortDescription = "MLB Playball Origin Mule New York Yankees Black 32SHS1111-50L",
                    product_Img1 = "StaticFiles/p-28/product-1.png",
                    product_Img2 = "StaticFiles/p-28/product-2.png",
                    product_Img3 = "StaticFiles/p-28/product-3.png",
                    product_Img4 = "StaticFiles/p-28/product-4.png",
                    product_Img5 = "StaticFiles/p-28/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id29,
                    product_Name = "MLB Mule Playball",
                    product_Description = "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS",
                    product_ShortDescription = "MLB Mule Playball Fur Diamond Monogram New York Yankees Black 3AMUUFS26-50BKS",
                    product_Img1 = "StaticFiles/p-29/product-1.png",
                    product_Img2 = "StaticFiles/p-29/product-2.png",
                    product_Img3 = "StaticFiles/p-29/product-3.png",
                    product_Img4 = "StaticFiles/p-29/product-4.png",
                    product_Img5 = "StaticFiles/p-29/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                },
                new ProductsTable()
                {
                    product_Id = newProduct_Id30,
                    product_Name = "MLB Mule Playball Fur",
                    product_Description = "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD",
                    product_ShortDescription = "MLB Mule Playball Fur Diamond Monogram Boston Red Sox D.Beige 3AMUUFS26-43BGD",
                    product_Img1 = "StaticFiles/p-30/product-1.png",
                    product_Img2 = "StaticFiles/p-30/product-2.png",
                    product_Img3 = "StaticFiles/p-30/product-3.png",
                    product_Img4 = "StaticFiles/p-30/product-4.png",
                    product_Img5 = "StaticFiles/p-30/product-5.png",
                    product_Price = 10,
                    product_Type = CommonProduct.ProductType1,
                    product_Sold = 10,
                    product_Rate = 4,
                    product_ViewNumber = 10,
                    product_CategoryId = newCategory_Id5,
                    IsDelete = false
                }
                );

            // Color Table
            string newColor_Id1 = Guid.NewGuid().ToString();
            string newColor_Id2 = Guid.NewGuid().ToString();
            string newColor_Id3 = Guid.NewGuid().ToString();
            string newColor_Id4 = Guid.NewGuid().ToString();

            builder.Entity<ColorsTable>().HasData(
                new ColorsTable()
                {
                    color_Id = newColor_Id1,
                    color_Name = BaseData.RedName,
                    color_IdDelete = false
                },
                new ColorsTable()
                {
                    color_Id = newColor_Id2,
                    color_Name = BaseData.BlackName,
                    color_IdDelete = false
                },
                new ColorsTable()
                {
                    color_Id = newColor_Id3,
                    color_Name = BaseData.GreenName,
                    color_IdDelete = false
                },
                new ColorsTable()
                {
                    color_Id = newColor_Id4,
                    color_Name = BaseData.YellowName,
                    color_IdDelete = false
                }
                );

            // Color Table

            builder.Entity<ColorInProductTable>().HasData(
                new ColorInProductTable()
                {
                    cip_ColorId = newColor_Id1,
                    cip_ProductId = newProduct_Id1,
                    cip_IsDelete = false
                }, 
                new ColorInProductTable()
                {
                    cip_ColorId = newColor_Id2,
                    cip_ProductId = newProduct_Id1,
                    cip_IsDelete = false
                },
                new ColorInProductTable()
                {
                    cip_ColorId = newColor_Id3,
                    cip_ProductId = newProduct_Id1,
                    cip_IsDelete = false
                },
                new ColorInProductTable()
                {
                    cip_ColorId = newColor_Id4,
                    cip_ProductId = newProduct_Id1,
                    cip_IsDelete = false
                }
                );

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
                    bill_ProductsIdList = newProduct_Id1+"|"+ newProduct_Id2 + "|" + newProduct_Id3 + "|" + newProduct_Id4 + "|",
                    bill_ProductPriceList = "10|10|10|10|",
                    bill_ProductUnitList = "1|1|1|1|",
                    bill_ProductColorList = "Red|Black|Green|Yellow",
                    bill_ProductSizeList = "X|XL|S|M",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                }, new BillsTable()
                {
                    bill_Id = newBill_Id2,
                    bill_Code = 1,
                    bill_UserId = newUser_Id2,
                    bill_Price = 0,
                    bill_ProductsIdList = newProduct_Id5 + "|" + newProduct_Id6 + "|" + newProduct_Id7 + "|" + newProduct_Id8 + "|",
                    bill_ProductPriceList = "10|10|10|10|",
                    bill_ProductUnitList = "1|1|1|1|",
                    bill_ProductColorList = "Red|Black|Green|Yellow",
                    bill_ProductSizeList = "X|XL|S|M",

                    CreateBy = BaseData.CreateBy,
                    CreateOn = BaseData.CreateOn,
                    UpdateBy = BaseData.UpdateBy,
                    UpdateOn = BaseData.UpdateOn,
                    IsDelete = false
                }, new BillsTable()
                {
                    bill_Id = newBill_Id3,
                    bill_Code = 1,
                    bill_UserId = newUser_Id3,
                    bill_Price = 0,
                    bill_ProductsIdList = newProduct_Id9 + "|" + newProduct_Id10 + "|" + newProduct_Id11 + "|" + newProduct_Id12 + "|",
                    bill_ProductPriceList = "10|10|10|10|",
                    bill_ProductUnitList = "1|1|1|1|",
                    bill_ProductColorList = "Red|Black|Green|Yellow",
                    bill_ProductSizeList = "X|XL|S|M",

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
