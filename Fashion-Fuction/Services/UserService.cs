using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using System.Collections.Generic;

namespace Fashion_Fuction.Services
{
    public class UserService: IUserService
    {
        private ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        //public string GetRoleNameOfUser(string userId)
        //{
        //    var query = _context.usersTable.Where(u => u.Id == userId); 

        //    return "";
        //}

        public List<UserModel> GetAllUser()
        {
            var userQuery = _context.usersTable.Where(x => x.IsDelete == false);
            List<UserModel> userList = new List<UserModel>();
            foreach (var item in userQuery)
            {
                UserModel userModel = new UserModel();
                userModel.Id = item.Id;
                userModel.UserName = item.UserName;
                userModel.Email = item.Email;
                userModel.IsDelete = item.EmailConfirmed;

                userList.Add(userModel);
            }

            return userList;
        }

        public UserModel GetUserById(string userId)
        {
            var userQuery = _context.usersTable.FirstOrDefault(x => x.Id == userId);
            if (userQuery != null)
            {
                UserModel userModel = new UserModel();
                userModel.Id = userQuery.Id;
                userModel.UserName = userQuery.UserName;
                userModel.Email = userQuery.Email;
                userModel.IsDelete = userQuery.EmailConfirmed;

                return userModel;
            }
            
            return new UserModel();
        }

        public async Task<UserModel> UpdateUser(UserModel userModel)
        {
            try
            {
                var userQuery = _context.usersTable.FirstOrDefault(x => x.Id == userModel.Id);
                if (userQuery != null)
                {

                    userQuery.UserName = userModel.UserName;
                    userQuery.Email = userModel.Email;
                    userQuery.NormalizedUserName = userModel.Email.ToUpper(); 
                    userQuery.NormalizedEmail = userModel.Email.ToUpper();

                    await _context.SaveChangesAsync();

                    return userModel;
                }

                return new UserModel();
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public async Task<bool> DeleteUser(string userId)
        {
            try
            {
                var userQuery = _context.usersTable.FirstOrDefault(x => x.Id == userId);
                if (userQuery != null)
                {

                    userQuery.EmailConfirmed = false;
                    userQuery.IsDelete = true;

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
