using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Fuction.Models;
using Fashion_Fuction.DataCreated;
using Fashion_Infrastructure.Data;


namespace Fashion_Fuction.Services
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
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
            var productQuery = _context.productsTable;


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
            var productQuery = _context.productsTable;


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
                    product.product_Sold = productQuery.product_Sold;
                    product.product_Rate = productQuery.product_Rate;

                    return product;
                }


                return null;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
