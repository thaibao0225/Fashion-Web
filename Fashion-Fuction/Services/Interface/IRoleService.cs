using Fashion_Fuction.Models;

namespace Fashion_Fuction.Services.Interface
{
    public interface IRoleService
    {
        public List<RoleModel> GetAllRole();
        public RoleModel GetRoleById(string roleId);
        public Task<bool> CreateRole(RoleModel roleModel);
        public Task<bool> DeleteRoleById(string roleId);
        public Task<bool> UpdateRole(RoleModel roleModel);
    }
}
