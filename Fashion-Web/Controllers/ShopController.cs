using Fashion_Fuction.DataCreated;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Fashion_Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        private ApplicationDbContext _context;
        private IProductService _productService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICommentService _commentService;

        public ShopController(ILogger<ShopController> logger, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ICommentService commentService)
        {
            _logger = logger;
            _context = context;
            _productService = new ProductService(context);
            _httpContextAccessor = httpContextAccessor;
            _commentService = commentService;
        }


        // GET: ShopController
        [Route("/shop")]
        public ActionResult Index()
        {

            // Product

            ViewBag.ProductList = _productService.GetProductList(9, DataAll.Web);

            return View();
        }

        // GET: ShopController/Details/5
        [Route("/shop/details")]
        public ActionResult Details(string id, string message = "")
        {
            //ViewBag.ProductFirst = _productService.GetProductById(id, DataAll.Web);
            var productDetail = _productService.GetProductById(id, DataAll.Web);
            productDetail = _productService.GetCurrentSizeOfProduct(productDetail);
            productDetail = _productService.GetCurrentColorOfProduct(productDetail);

            ViewBag.CommentsCount = 0;
            List<CommentModel> comments = _commentService.GetCommentByProductId(id);
            if(comments.Count > 0)
            {
                ViewBag.CommentsCount = comments.Count;

            }
            ViewBag.Message = message;
            return View(productDetail);
        }

        // POST: ShopController/Create
        [HttpPost]
        [Route("/shop/rating")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Rating(IFormCollection collection)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                string productId = collection["product_Id"];
                string commentRating = collection["comment_Rating"];
                string Comment = collection["Comment"];

                await _commentService.CreateCommentInProduct(productId, userId, Comment, Int32.Parse(commentRating));

                return RedirectToAction("Details", "shop", new { id = productId});
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopController/Create
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

        // GET: ShopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController/Edit/5
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

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopController/Delete/5
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
