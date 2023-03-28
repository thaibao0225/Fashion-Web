using Fashion_Fuction.Models;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services.Interface
{
    public interface IProductService
    {
        public List<ProductModel> GetAllList( string page = "Admin");
        public List<ProductModel> GetProductList( int size, string page = "Admin");
        public ProductModel GetProductById( string id, string page = "Admin");
        public Task<bool> DeleteProductById( string id);
        public Task<bool> UpdateProductById( string id, ProductModel productModel);
        public Task<bool> CreateProduct( ProductModel productModel);
        public ProductModel GetCurrentSizeOfProduct(ProductModel productModel);
        public ProductModel GetCurrentColorOfProduct(ProductModel productModel);
        public int GetSize(string sizeId);
        public string GetColor(string colorId);
        public List<ProductModel> GetProductByModelId(List<ProductModel> productList, string page = "Admin");
    }
}
