using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Web.Controllers
{
    public class CartController : Controller
    {
        // GET: CartController
        [Route("/cart")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: CartController/Details/5
        
        [HttpPost]
        [Route("/cart/addtocart")]
        [ValidateAntiForgeryToken]
        public ActionResult AddToCart(IFormCollection collection)
        {

            string productId =  collection["product_Id"];
            string sizeId =  collection["product_SizeId"];
            string colorId = collection["product_ColorId"];
            int Quantity =  int.Parse(collection["product_Quantity"]);


            return View();
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
