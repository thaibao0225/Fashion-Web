using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;

namespace Fashion_Fuction.Services
{
    public class RoleService : IRoleService
    {
        private ApplicationDbContext _context;
        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetRoleId(string userId)
        {
            var query = _context.UserRoles.FirstOrDefault(x => x.UserId == userId);

            if (query == null)
            {
                return "";
            }
            return query.UserId.ToString();
        }

        public string GetRoleName(string roleId)
        {
            var query = _context.rolesTable.FirstOrDefault(x => x.Id == roleId);

            if (query == null)
            {
                return "";
            }
            return query.Name.ToString();
        }
    }
}
