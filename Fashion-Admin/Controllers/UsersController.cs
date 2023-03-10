using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Infrastructure.Data;
using Fashion_Model.Models;

namespace Fashion_Admin.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: UsersController
        [Route("/users")]
        public ActionResult Index()
        {
            var query = _context.usersTable.ToList();
            var userMobdel = query.Select(x => new UsersModel()
            {
                user_Id = x.Id,
                user_FirstName = x.FirstName,
                user_LastName = x.LastName,
                user_Email = x.Email,
                user_UserName = x.UserName,
                is_Delete = x.IsDelete
            });

            return View(userMobdel);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
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

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
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

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
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
