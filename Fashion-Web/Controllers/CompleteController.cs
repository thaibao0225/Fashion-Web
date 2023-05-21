using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Web.Controllers
{
    public class CompleteController : Controller
    {
        // GET: CompleteController
        [Route("/complete")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: CompleteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompleteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompleteController/Create
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

        // GET: CompleteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompleteController/Edit/5
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

        // GET: CompleteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompleteController/Delete/5
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
