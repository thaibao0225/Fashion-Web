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
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                //Contact Model
                string Id = collection["Id"];
                string Name = collection["Name"];
                string Email = collection["Email"];
                string Subject = collection["Subject"];
                string Message = collection["Message"];


                EmailCustomerTable customerTable = new EmailCustomerTable();
                string emailId = Guid.NewGuid().ToString();

                customerTable.emailC_Id = emailId;
                customerTable.emailC_Email = Email;
                customerTable.emailC_IsDelete = false;
                await _context.emailCustomerTable.AddAsync(customerTable);


                ContactTable contactTable = new ContactTable();
                contactTable.contact_Id = Guid.NewGuid().ToString();
                contactTable.contact_Name = Name;
                contactTable.contact_EmailId = emailId;
                contactTable.emailC_Subject = Subject;
                contactTable.emailC_Message = Message;
                contactTable.emailC_IsCheck = false;
                await _context.contactTable.AddAsync(contactTable);
                await _context.SaveChangesAsync();

                return Redirect("/");
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
