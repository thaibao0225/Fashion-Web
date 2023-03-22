using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Fuction.Services;

namespace Fashion_Admin.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;
        private IProductService _productService;

        public ProductsController(ApplicationDbContext context) 
        {
            _context = context;
            _productService = new ProductService(context);
        }
        // GET: ProductsController
        [Route("/products")]
        public ActionResult Index()
        {
            return View(_productService.GetAllList());
        }

        // GET: ProductsController/Details/5
        [Route("/products/details")]
        public ActionResult Details(string id)
        {
            return View(_productService.GetProductById(id));
        }

        // GET: ProductsController/Create
        [Route("/products/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        [Route("/products/edit")]
        public ActionResult Edit(string id)
        {
            return View(_productService.GetProductById(id));
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        [Route("/products/delete")]
        public ActionResult Delete(string id)
        {
            return View(_productService.GetProductById(id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
