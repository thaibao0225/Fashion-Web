using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;

namespace Fashion_Fuction.Services
{
    public class RoleService : IRoleService
    {
        private ApplicationDbContext _context;
        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RoleModel> GetAllRole()
        {
            try
            {
                var roleQuery = _context.rolesTable.Where(x => x.IsDelete == false);

                List<RoleModel> roleList = new List<RoleModel>();

                foreach (var item in roleQuery)
                {
                    RoleModel roleModel = new RoleModel();
                    roleModel.Id = item.Id;
                    roleModel.RoleName = item.Name;

                    roleList.Add(roleModel);
                }

                return roleList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public RoleModel GetRoleById(string roleId)
        {
            try
            {
                var roleQuery = _context.rolesTable.FirstOrDefault(x => x.Id == roleId);

                if (roleQuery != null)
                {
                    RoleModel roleModel = new RoleModel();
                    roleModel.Id = roleQuery.Id;
                    roleModel.RoleName = roleQuery.Name;
                    return roleModel;
                }
                return new RoleModel();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateRole(RoleModel roleModel)
        {
            try
            {
                RolesTable roleTable = new RolesTable();
                roleTable.Id = Guid.NewGuid().ToString();
                roleTable.Name = roleModel.RoleName;
                roleTable.NormalizedName = roleModel.RoleName.ToLower();

                await _context.rolesTable.AddAsync(roleTable);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteRoleById(string roleId)
        {
            try
            {
                var roleQuery = _context.rolesTable.FirstOrDefault(x => x.Id == roleId);

                if (roleQuery != null)
                {
                    roleQuery.IsDelete = true;

                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateRole(RoleModel roleModel)
        {
            try
            {
                var roleQuery = _context.rolesTable.FirstOrDefault(x => x.Id == roleModel.Id);

                if (roleQuery != null)
                {
                    roleQuery.Name = roleModel.RoleName;
                    roleQuery.NormalizedName = roleModel.RoleName.ToLower();

                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
