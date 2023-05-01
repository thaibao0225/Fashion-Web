using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Fuction.DataCreated;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;

namespace Fashion_Fuction.Services
{
    public class CategoryService : ICategoryService
    {
        private ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategory(CategoryModel categoryModel)
        {
            try
            {
                CategoriesTable categoryCreate = new CategoriesTable();

                categoryCreate.category_Id = Guid.NewGuid().ToString();
                categoryCreate.category_Name = categoryModel.category_Name;
                categoryCreate.IsDelete = false;

                await _context.categoriesTable.AddAsync(categoryCreate);
                var result = await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<bool> UpdateCategory(string id, CategoryModel categoryModel)
        {
            try
            {
                var categoryQuery = _context.categoriesTable.FirstOrDefault(x => x.category_Id == id);
                if (categoryQuery != null)
                {
                    categoryQuery.category_Name = categoryModel.category_Name;

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

        public async Task<bool> DeleteCategory(string id)
        {
            try
            {
                var categoryQuery = _context.categoriesTable.FirstOrDefault(x => x.category_Id == id);
                if (categoryQuery != null)
                {
                    categoryQuery.IsDelete = true;

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

        public List<CategoryModel> GetAllCategory()
        {
            try
            {
                var categoryQuery = _context.categoriesTable.Where(x => x.IsDelete == false);

                List<CategoryModel> categoryModelList = new List<CategoryModel>();
                foreach (var categoryItem in categoryQuery)
                {
                    CategoryModel category = new CategoryModel();
                    category.category_Id = categoryItem.category_Id;
                    category.category_Name = categoryItem.category_Name;
                    categoryModelList.Add(category);
                }

                return categoryModelList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public CategoryModel GetCategoryById(string categoryId)
        {
            try
            {
                var categoryQuery = _context.categoriesTable.FirstOrDefault(x => x.IsDelete == false && x.category_Id == categoryId);

                if (categoryQuery != null)
                {
                    CategoryModel category = new CategoryModel();
                    category.category_Id = categoryQuery.category_Id;
                    category.category_Name = categoryQuery.category_Name;


                    return category;
                }
                return new CategoryModel();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
