﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Infrastructure.Data;
using Fashion_Fuction.Services.Interface;

namespace Fashion_Admin.Controllers
{
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillsController/Create
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

        // GET: BillsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillsController/Edit/5
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

        // GET: BillsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillsController/Delete/5
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
