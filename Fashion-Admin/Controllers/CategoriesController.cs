using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private ApplicationDbContext _context;
        private ICategoryService _categoryService;
        public CategoriesController(ApplicationDbContext context, ICategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
        }

        // GET: CategoriesController
        [Route("/categories")]
        public ActionResult Index()
        {


            return View(_categoryService.GetAllCategory());
        }

        // GET: CategoriesController/Details/5
        [Route("/categories/details")]
        public ActionResult Details(string id)
        {
            return View(_categoryService.GetCategoryById(id));
        }

        // GET: CategoriesController/Create
        [Route("/categories/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [Route("/categories/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.category_Id = collection["category_Id"];
                categoryModel.category_Name = collection["category_Name"];
                await _categoryService.CreateCategory(categoryModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        [Route("/categories/edit")]
        public ActionResult Edit(string id)
        {
            return View(_categoryService.GetCategoryById(id));
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [Route("/categories/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.category_Id = collection["category_Id"];
                categoryModel.category_Name = collection["category_Name"];

                await _categoryService.UpdateCategory(categoryModel.category_Id, categoryModel);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        [Route("/categories/delete")]
        public ActionResult Delete(string id)
        {
            return View(_categoryService.GetCategoryById(id));
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [Route("/categories/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {   
                string categoryId = collection["category_Id"];

                await _categoryService.DeleteCategory(categoryId);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
