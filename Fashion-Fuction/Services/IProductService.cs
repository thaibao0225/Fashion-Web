using Fashion_Fuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services
{
    public interface IProductService
    {
        public List<ProductModel> GetAllList(string page = "Admin");
        public List<ProductModel> GetProductList(int size, string page = "Admin");
        public ProductModel GetProductById(string id, string page = "Admin");
    }
}
