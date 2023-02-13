using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Admin.Controllers
{
    public class EmailCustomerController : Controller
    {
        // GET: EmailCustomerController
        [Route("/emailcustomer")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmailCustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmailCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmailCustomerController/Create
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

        // GET: EmailCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmailCustomerController/Edit/5
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

        // GET: EmailCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmailCustomerController/Delete/5
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
