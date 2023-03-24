using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Fuction.Models;
using Fashion_Fuction.DataCreated;
using Fashion_Infrastructure.Data;
using Abp.Domain.Uow;
using Fashion_Fuction.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Fashion_Infrastructure.Entities;

namespace Fashion_Fuction.Services
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _context;
        public ProductService(
            ApplicationDbContext context
            )
        {
            _context = context;

        }
        public List<ProductModel> GetAllList(string page = "Admin")
        {
            string prefix = "";
            if (page == "Web")
            {
                prefix = DataAll.AdminUrl;
            }
            var productQuery = _context.productsTable.Where(x => x.IsDelete == false);


            List<ProductModel> productModelList = new List<ProductModel>();
            foreach (var item in productQuery)
            {
                ProductModel product = new ProductModel();
                product.product_Id = item.product_Id;
                product.product_Name = item.product_Name;
                product.product_Description = item.product_Description;
                product.product_ShortDescription = item.product_ShortDescription;
                product.product_Price = item.product_Price;
                product.product_Img1 = prefix + item.product_Img1;
                product.product_Img2 = prefix + item.product_Img2;
                product.product_Img3 = prefix + item.product_Img3;
                product.product_Img4 = prefix + item.product_Img4;
                product.product_Img5 = prefix + item.product_Img5;
                product.product_Sold = item.product_Sold;
                product.product_Rate = item.product_Rate;

                productModelList.Add(product);

            }


            return productModelList;
        }


        //Page = Admin
        //Page = Web

        public List<ProductModel> GetProductList(int size, string page = "Admin")
        {
            string prefix = "";
            if (page == "Web")
            {
                prefix = DataAll.AdminUrl;
            }
            var productQuery = _context.productsTable.Where(x => x.IsDelete == false);


            List<ProductModel> productModelList = new List<ProductModel>();
            foreach (var item in productQuery)
            {
                size--;


                ProductModel product = new ProductModel();
                product.product_Id = item.product_Id;
                product.product_Name = item.product_Name;
                product.product_Description = item.product_Description;
                product.product_ShortDescription = item.product_ShortDescription;
                product.product_Price = item.product_Price;
                product.product_Img1 = prefix + item.product_Img1;
                product.product_Img2 = prefix + item.product_Img2;
                product.product_Img3 = prefix + item.product_Img3;
                product.product_Img4 = prefix + item.product_Img4;
                product.product_Img5 = prefix + item.product_Img5;
                product.product_Sold = item.product_Sold;
                product.product_Rate = item.product_Rate;

                productModelList.Add(product);

                if (size == 0) break;
            }


            return productModelList;
        }

        public ProductModel GetProductById(string id, string page = "Admin")
        {
            try
            {
                string prefix = "";
                if (page == "Web")
                {
                    prefix = DataAll.AdminUrl;
                }
                var productQuery = _context.productsTable.FirstOrDefault(x => x.product_Id == id);

                if (productQuery != null)
                {
                    ProductModel product = new ProductModel();
                    product.product_Id = productQuery.product_Id;
                    product.product_Name = productQuery.product_Name;
                    product.product_Description = productQuery.product_Description;
                    product.product_ShortDescription = productQuery.product_ShortDescription;
                    product.product_Price = productQuery.product_Price;
                    product.product_Img1 = prefix + productQuery.product_Img1;
                    product.product_Img2 = prefix + productQuery.product_Img2;
                    product.product_Img3 = prefix + productQuery.product_Img3;
                    product.product_Img4 = prefix + productQuery.product_Img4;
                    product.product_Img5 = prefix + productQuery.product_Img5;
                    product.product_Sold = productQuery.product_Sold;
                    product.product_Rate = productQuery.product_Rate;
                    product.product_ViewNumber = productQuery.product_ViewNumber;
                    product.product_Type = productQuery.product_Type;

                    var categoryQuery = _context.categoriesTable.FirstOrDefault(x => x.category_Id == productQuery.product_CategoryId);

                    if (categoryQuery != null)
                    {
                        product.product_CategoryName = categoryQuery.category_Name;
                    }
                    else
                    {
                        product.product_CategoryName = "";
                    }



                    return product;
                }
                return new ProductModel();
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<bool> DeleteProductById(string id)
        {
            try
            {

                var produceQuery = _context.productsTable.FirstOrDefault(x => x.product_Id == id);


                if (produceQuery != null)
                {
                    produceQuery.IsDelete = true;
                    await _context.SaveChangesAsync();
                    return true;
                }






                return false;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public async Task<bool> UpdateProductById(string id, ProductModel productModel)
        {
            try
            {
                var produceQuery = _context.productsTable.FirstOrDefault(x => x.product_Id == id);

                if (produceQuery != null)
                {
                    produceQuery.product_Id = id;
                    produceQuery.product_Name = productModel.product_Name;
                    produceQuery.product_Description = productModel.product_Description;
                    produceQuery.product_ShortDescription = productModel.product_ShortDescription;
                    produceQuery.product_Price = productModel.product_Price;
                    //produceQuery.product_Sold = productModel.product_Sold;
                    //produceQuery.product_Rate = productModel.product_Rate;
                    if (productModel.product_Img1 != "")
                    {
                        produceQuery.product_Img1 = productModel.product_Img1;
                    }
                    if (productModel.product_Img2 != "")
                    {
                        produceQuery.product_Img2 = productModel.product_Img2;
                    }
                    if (productModel.product_Img3 != "")
                    {
                        produceQuery.product_Img3 = productModel.product_Img3;
                    }
                    if (productModel.product_Img4 != "")
                    {
                        produceQuery.product_Img4 = productModel.product_Img4;
                    }
                    if (productModel.product_Img5 != "")
                    {
                        produceQuery.product_Img5 = productModel.product_Img5;
                    }

                    produceQuery.product_Type = productModel.product_Type;
                    //produceQuery.product_ViewNumber = productModel.product_ViewNumber;
                    produceQuery.product_CategoryId = productModel.product_CategoryId;

                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateProduct(ProductModel productModel)
        {
            try
            {
                ProductsTable produceQuery = new ProductsTable();
                produceQuery.product_Id = Guid.NewGuid().ToString();
                produceQuery.product_Name = productModel.product_Name;
                produceQuery.product_Description = productModel.product_Description;
                produceQuery.product_ShortDescription = productModel.product_ShortDescription;
                produceQuery.product_Price = productModel.product_Price;
                produceQuery.product_Sold = productModel.product_Sold;
                produceQuery.product_Rate = 3;
                produceQuery.product_Img1 = productModel.product_Img1;
                produceQuery.product_Img2 = productModel.product_Img2;
                produceQuery.product_Img3 = productModel.product_Img3;
                produceQuery.product_Img4 = productModel.product_Img4;
                produceQuery.product_Img5 = productModel.product_Img5;
                produceQuery.product_Type = productModel.product_Type;
                produceQuery.product_ViewNumber = productModel.product_ViewNumber;
                produceQuery.product_CategoryId = productModel.product_CategoryId;


                await _context.productsTable.AddAsync(produceQuery);
                await _context.SaveChangesAsync();

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
