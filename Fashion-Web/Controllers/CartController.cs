using Fashion_Fuction.Services.Interface;
using Fashion_Fuction.Services;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Fashion_Fuction.DataCreated;
using Fashion_Fuction.Models;
using System.Text.Json.Nodes;
using Fashion_Web.StaticsFunction;

namespace Fashion_Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        private ApplicationDbContext _context;
        private IProductService _productService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(ILogger<ShopController> logger, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _context = context;
            _productService = new ProductService(context);
            this._httpContextAccessor = httpContextAccessor;
        }

        // GET: CartController
        [Route("/cart")]
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

        public List<ProductModel> unGenJsonCookie(string json)
        {
            return JsonConvert.DeserializeObject<List<ProductModel>>(json);
        }

        // GET: CartController/Details/5

        [HttpPost]
        [Route("/cart/addtocart")]
        [ValidateAntiForgeryToken]
        public ActionResult AddToCart(IFormCollection collection)
        {

            string productId = collection["product_Id"];
            string sizeId = collection["product_SizeId"];
            string colorId = collection["product_ColorId"];
            int Quantity = int.Parse(collection["product_Quantity"]);

            CartModel cartModel = new CartModel();
            cartModel.productList = new List<ProductModel>();
            

            

            //if (!HttpContext.Request.Cookies.ContainsKey(KeyCookie.cart_Product)) // existing 
            //{
            //    if ((productId != null) && (sizeId != null) && (colorId != null) && (Quantity != 0))
            //    {
            //        List<ProductModel> productModelList = new List<ProductModel>();

            //        ProductModel productModel = new ProductModel();
            //        productModel.product_Id = productId;
            //        productModel.product_SizeId = sizeId;
            //        productModel.product_SizeName = _productService.GetSize(sizeId);
            //        productModel.product_ColorId = colorId;
            //        productModel.product_ColorName = _productService.GetColor(colorId);
            //        productModel.product_Quantity = Quantity;
    
            //        productModelList.Add(productModel);

            //        CartStatics.GetNumberOfProductInCart = Quantity;

            //        string stringjson = JsonConvert.SerializeObject(productModelList);
            //        Console.WriteLine(stringjson);

            //        CookieOptions option = new CookieOptions();
            //        option.Expires = DateTime.Now.AddDays(1);
            //        HttpContext.Response.Cookies.Append(KeyCookie.cart_Product, stringjson, option);
            //    }
            //}
            //else
            //{
            //    string cookieValueFromCart = HttpContext.Request.Cookies[KeyCookie.cart_Product];
            //    if (cookieValueFromCart != null)
            //    {
            //        List<ProductModel> records = JsonConvert.DeserializeObject<List<ProductModel>>(cookieValueFromCart);

            //        var checkExistingRecords = records.FirstOrDefault(x => x.product_Id == productId
            //        && x.product_SizeId == sizeId
            //        && x.product_ColorId == colorId);

            //        if (checkExistingRecords != null)
            //        {

            //            checkExistingRecords.product_Quantity = checkExistingRecords.product_Quantity + Quantity;


            //            string stringjson = JsonConvert.SerializeObject(records);
            //            Console.WriteLine(stringjson);
            //            CartStatics.GetNumberOfProductInCart = _productService.GetSumNumberOfProduct(records);
            //            CookieOptions option = new CookieOptions();
            //            option.Expires = DateTime.Now.AddDays(1);
            //            HttpContext.Response.Cookies.Append(KeyCookie.cart_Product, stringjson, option);
            //        }
            //        else
            //        {
            //            if ((productId != null) && (sizeId != null) && (colorId != null) && (Quantity != 0))
            //            {

            //                ProductModel productModel = new ProductModel();
            //                productModel.product_Id = productId;
            //                productModel.product_SizeId = sizeId;
            //                productModel.product_SizeName = _productService.GetSize(sizeId);
            //                productModel.product_ColorId = colorId;
            //                productModel.product_ColorName = _productService.GetColor(colorId);
            //                productModel.product_Quantity = Quantity;
            //                records.Add(productModel);

            //                CartStatics.GetNumberOfProductInCart = _productService.GetSumNumberOfProduct(records);

            //                string stringjson = JsonConvert.SerializeObject(records);
            //                Console.WriteLine(stringjson);

            //                CookieOptions option = new CookieOptions();
            //                option.Expires = DateTime.Now.AddDays(1);
            //                HttpContext.Response.Cookies.Append(KeyCookie.cart_Product, stringjson, option);
            //            }
            //        }
            //    }
            //}
            return RedirectToAction("Details", "shop", new { id = productId });
        }


        

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
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
