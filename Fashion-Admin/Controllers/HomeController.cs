using Fashion_Admin.Models;
using Fashion_Fuction.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IContactService _contactService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ICommentService commentService, IContactService contactService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _commentService = commentService;
            _contactService = contactService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {

            ViewBag.CountProduct = _productService.CountProduct();
            ViewBag.CountComment = _commentService.CountAllComment();
            ViewBag.CountCategory = _categoryService.CountContact();
            ViewBag.CountMailContact = _contactService.CountContact();
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