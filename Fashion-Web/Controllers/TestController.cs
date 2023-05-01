using Fashion_Fuction.DataCreated;
using Fashion_Fuction.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fashion_Web.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        [Route("/test")]
        public ActionResult Index()
        {
            string cookieValueFromCart = HttpContext.Request.Cookies[KeyCookie.cart_Product];
            if (cookieValueFromCart != null)
            {

                List<ProductModel> Result = unGenJsonCookie(cookieValueFromCart);
            }

            return View();
        }

        public List<ProductModel> unGenJsonCookie(string json)
        {
            return JsonConvert.DeserializeObject<List<ProductModel>>(json);
        }

        // GET: TestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestController/Create
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

        // GET: TestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestController/Edit/5
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

        // GET: TestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestController/Delete/5
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
