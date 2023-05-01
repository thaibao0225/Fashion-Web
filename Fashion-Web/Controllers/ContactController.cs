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
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
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
                contactTable.contact_Subject = Subject;
                contactTable.contact_Message = Message;
                contactTable.contact_IsCheck = false;
                await _context.contactTable.AddAsync(contactTable);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Contact", new { message = "Successed" });
            }
            catch
            {
                return View();
            }
        }

       
    }
}
