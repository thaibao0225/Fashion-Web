using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services;
using Fashion_Fuction.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class ContactController : Controller
    {
        private ApplicationDbContext _context;
        private IContactService _contactService;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
            _contactService = new ContactService(context); 
        }

        // GET: ContactController
        [Route("/contact")]
        public ActionResult Index()
        {
            

            return View(_contactService.GetAllContact());
        }

        // GET: ContactController/Details/5
        [Route("/contact/details")]
        public ActionResult Details(string id)
        {

            return View(_contactService.GetContactById(id));
        }

        // GET: ContactController/Create
        public async Task<ActionResult> Checked(string id)
        {
            try
            {

                await _contactService.Checked(id);

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
