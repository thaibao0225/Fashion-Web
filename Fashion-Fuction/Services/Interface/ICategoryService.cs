using Fashion_Fuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services.Interface
{
    public interface ICategoryService
    {
        public Task<bool> CreateCategory(CategoryModel categoryModel);
        public Task<bool> UpdateCategory(string id, CategoryModel categoryModel);
        public Task<bool> DeleteCategory(string id);
        public List<CategoryModel> GetAllCategory();
        public CategoryModel GetCategoryById(string categoryId);

    }
}
