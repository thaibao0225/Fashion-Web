using Fashion_Fuction.Models;
using Fashion_Fuction.Services;
using Fashion_Infrastructure.Data;
using Fashion_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Fashion_Fuction.DataCreated;

namespace Fashion_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private IProductService _productService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _productService = new ProductService(context);
        }

        public IActionResult Index()
        {
            //Category
            var queryCategory = _context.categoriesTable;

            List<CategoryModel> categoryList = new List<CategoryModel>();
            foreach (var item in queryCategory)
            {
                CategoryModel category = new CategoryModel();

                category.category_Id = item.category_Id;
                category.category_Name = item.category_Name;
                category.category_NumberOfProduct = 0;

                categoryList.Add(category);
            }

            ViewBag.CategoryList = categoryList;


            // Product

            ViewBag.ProductList = _productService.GetProductList(8, DataAll.Web);




            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}