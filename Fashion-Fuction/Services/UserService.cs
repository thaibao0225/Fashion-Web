using Fashion_Infrastructure.Data;

namespace Fashion_Fuction.Services
{
    public class UserService: IUserService
    {
        private ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetRoleNameOfUser(string userId)
        {
            var query = _context.usersTable.Where(u => u.Id == userId); 

            return "";
        }
    }
}
