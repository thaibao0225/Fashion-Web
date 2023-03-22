using Fashion_Fuction.Services;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public ContactController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: ContactController
        [Route("/contact")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create

        [HttpPost]
        [Route("/contact")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                //Contact Model
                string Id = collection["Id"];
                string Name = collection["Name"];
                string Email = collection["Email"];
                string Subject = collection["Subject"];
                string Message = collection["Message"];



                ////Contact Table
                //string contact_Id = collection["contact_Id"];
                //string contact_Name = collection["contact_Name"];
                //string contact_EmailId = collection["contact_EmailId"];
                //string emailC_Subject = collection["emailC_Subject"];
                //string emailC_Message = collection["emailC_Message"];
                //string emailC_IsCheck = collection["emailC_IsCheck"];


                ////EmailCustomer Table
                //string emailC_Id = collection["emailC_Id"];
                //string emailC_Email = collection["emailC_Email"];
                //string emailC_IsDelete = collection["emailC_IsDelete"];

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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
