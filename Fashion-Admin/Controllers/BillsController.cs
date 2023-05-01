using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Infrastructure.Data;
using Fashion_Fuction.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class BillsController : Controller
    {
        private ApplicationDbContext _context;
        private IBillService _billService;
        public BillsController(ApplicationDbContext context, IBillService billService)
        {
            _context = context;
            _billService = billService; 
        }

        // GET: BillsController
        [Route("/bills")]
        public ActionResult Index()
        {
            

            return View(_billService.GetBill());
        }

        // GET: BillsController/Details/5
        [Route("/bills/details")]
        public ActionResult Details(string id, string message ="")
        {

            ViewBag.Message = message;
            return View(_billService.GetBillById(id));
        }


        // GET: BillsController/Details/5
        [Route("/bills/confirm")]
        public async Task<ActionResult> Confirm(string billId)
        {
            await _billService.ChangeStatusConfirmBillById(billId);
            return RedirectToAction("Details", "bills", new { id = billId, message = "Success" });
        }

        // GET: BillsController/Details/5
        [Route("/bills/unconfirm")]
        public async Task<ActionResult> Unconfirm(string billId)
        {

            await _billService.ChangeStatusUnconfirmBillById(billId);
            return RedirectToAction("Details", "bills", new { id = billId, message = "Success" });
        }


        //// GET: BillsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: BillsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: BillsController/Delete/5
        [Route("/bills/delete")]
        public ActionResult Delete(string id)
        {
            return View(_billService.GetBillById(id));
        }

        // POST: BillsController/Delete/5
        [HttpPost]
        [Route("/bills/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                await _billService.DeleteBill(collection["bill_Id"]);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
