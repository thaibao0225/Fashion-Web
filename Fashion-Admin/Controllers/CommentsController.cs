﻿using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class CommentsController : Controller
    {
        private ApplicationDbContext _context;
        private ICommentService _commentService;
        public CommentsController(ApplicationDbContext context, ICommentService commentService)
        {
            _context = context;
            _commentService = commentService;
        }
        // GET: CommentsController
        [Route("/comments")]
        public ActionResult Index()
        {
            return View(_commentService.GetAllComment());
        }

        // GET: CommentsController/Details/5
        public async Task<ActionResult> BlockComment(string id)
        {

            try
            {

                await _commentService.DeleteComment(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: CommentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentsController/Create
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

        // GET: CommentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommentsController/Edit/5
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

        // GET: CommentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentsController/Delete/5
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
