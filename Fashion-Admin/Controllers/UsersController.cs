using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Infrastructure.Data;
using Fashion_Fuction.Services.Interface;
using Fashion_Fuction.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;
        private IUserService _userService;
        private IRoleService _roleService;
        public UsersController(ApplicationDbContext context, IUserService userService, IRoleService roleService)
        {
            _context = context;
            _userService = userService;
            _roleService = roleService;
        }


        // GET: UsersController
        [Route("/users")]
        public ActionResult Index()
        {
            
            return View(_userService.GetAllUser());
        }

        // GET: UsersController/Details/5
        [Route("/users/details")]
        public ActionResult Details(string id)
        {
            return View(_userService.GetUserById(id));
        }

        // GET: UsersController/Edit/5
        [Route("/users/edit")]
        public ActionResult Edit(string id)
        {
            ViewBag.RoleNameSelect = _roleService.GetAllRole();


            return View(_userService.GetUserById(id));
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [Route("/users/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {

                UserModel userModel = new UserModel();
                userModel.Id = collection["Id"];
                userModel.UserName = collection["UserName"];
                userModel.Email = collection["Email"];
                userModel.user_RoleIdNew = collection["user_RoleIdNew"];

                if (userModel != null)
                {
                    await _userService.UpdateUser(userModel);
                }
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        [Route("/users/delete")]
        public ActionResult Delete(string id)
        {
            return View(_userService.GetUserById(id));
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [Route("/users/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                await _userService.DeleteUser(collection["Id"]);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: UsersController/Delete/5
        [Route("/users/assigntorole")]
        public ActionResult AssignToRole(string id)
        {
            return View(_userService.GetUserById(id));
        }
    }
}
