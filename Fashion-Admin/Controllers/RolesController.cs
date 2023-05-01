using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Fashion_Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private ApplicationDbContext _context;
        private IRoleService _roleService;
        public RolesController(ApplicationDbContext context, IRoleService roleService)
        {
            _context = context;
            _roleService = roleService;
        }

        // GET: RoliesController
        [Route("/roles")]
        public ActionResult Index()
        {
            

            return View(_roleService.GetAllRole());
        }

        // GET: RoliesController/Details/5
        [Route("/roles/details")]
        public ActionResult Details(string id)
        {
            return View(_roleService.GetRoleById(id));
        }

        // GET: RoliesController/Create
        [Route("/roles/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoliesController/Create
        [HttpPost]
        [Route("/roles/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {

                RoleModel roleModel = new RoleModel();
                roleModel.RoleName = collection["RoleName"];
                await _roleService.CreateRole(roleModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoliesController/Edit/5
        [Route("/roles/edit")]
        public ActionResult Edit(string id)
        {
            return View(_roleService.GetRoleById(id));
        }

        // POST: RoliesController/Edit/5
        [HttpPost]
        [Route("/roles/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                RoleModel roleModel = new RoleModel();
                roleModel.Id = collection["Id"];
                roleModel.RoleName = collection["RoleName"];

                await _roleService.UpdateRole(roleModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoliesController/Delete/5
        [Route("/roles/delete")]
        public ActionResult Delete(string id)
        {
            return View(_roleService.GetRoleById(id));
        }

        // POST: RoliesController/Delete/5
        [HttpPost]
        [Route("/roles/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                await _roleService.DeleteRoleById(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
