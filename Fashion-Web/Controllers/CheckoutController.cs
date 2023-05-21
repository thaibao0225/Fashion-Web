using Fashion_Fuction.DataCreated;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Fuction.Services;
using Fashion_Infrastructure.Data;
using Fashion_Web.StaticsFunction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Fashion_Web.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;
        private ApplicationDbContext _context;
        private IProductService _productService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBillService _billService;

        public CheckoutController(ILogger<CheckoutController> logger, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, IBillService billService)
        {
            _logger = logger;
            _context = context;
            _productService = new ProductService(context);
            this._httpContextAccessor = httpContextAccessor;
            _billService = billService;
        }
        // GET: CheckoutController
        [Route("/checkout")]
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies.ContainsKey(KeyCookie.cart_Product)) // existing 
            {
                string cookieValueFromCart = HttpContext.Request.Cookies[KeyCookie.cart_Product];
                if (cookieValueFromCart != null)
                {
                    List<ProductModel> records = JsonConvert.DeserializeObject<List<ProductModel>>(cookieValueFromCart);
                    CartStatics.GetNumberOfProductInCart = _productService.GetSumNumberOfProduct(records);

                    return View(_productService.GetProductByModelId(records, DataAll.Web));
                }


            }
            return NotFound();
        }

        // GET: CheckoutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CheckoutController/Create
        [Route("/checkout/create")]
        public ActionResult Create()
        {

            return View();
        }

        // POST: CheckoutController/Create
        [Route("/checkout/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var queryUser = _context.usersTable.FirstOrDefault(x => x.Id == userId);

                if (HttpContext.Request.Cookies.ContainsKey(KeyCookie.cart_Product)) // existing 
                {
                    string cookieValueFromCart = HttpContext.Request.Cookies[KeyCookie.cart_Product];
                    if (cookieValueFromCart != null)
                    {
                        List<ProductModel> records = JsonConvert.DeserializeObject<List<ProductModel>>(cookieValueFromCart);
                        CartStatics.GetNumberOfProductInCart = _productService.GetSumNumberOfProduct(records);
                        var prepareBill = _billService.PrepareBill(userId, _productService.GetProductByModelId(records, DataAll.Web), 0);
                        await _billService.CreateBill(userId, prepareBill);

                        //return View(_productService.GetProductByModelId(records, DataAll.Web));


                    }


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckoutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckoutController/Edit/5
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

        // GET: CheckoutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckoutController/Delete/5
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
