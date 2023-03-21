using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Admin.Controllers
{
    public class RolesController : Controller
    {
        private ApplicationDbContext _context;
        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoliesController
        [Route("/roles")]
        public ActionResult Index()
        {
            var query = _context.rolesTable;

            return View(query);
        }

        // GET: RoliesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoliesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoliesController/Create
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

        // GET: RoliesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoliesController/Edit/5
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

        // GET: RoliesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoliesController/Delete/5
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
