using Fashion_Fuction.Services;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Admin.Controllers
{
    public class EmailCustomerController : Controller
    {
        private ApplicationDbContext _context;
        private IContactService _contactService;
        public EmailCustomerController(ApplicationDbContext context)
        {
            _context = context;
            _contactService = new ContactService(context);
        }

        // GET: EmailCustomerController
        [Route("/emailcustomer")]
        public ActionResult Index()
        {
            //var query = _context.emailCustomerTable.Where(x => x.emailC_IsDelete == false);
            return View(_contactService.GetAllEmail());
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
