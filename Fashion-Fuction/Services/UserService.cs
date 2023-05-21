using Castle.MicroKernel.Util;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using static Castle.MicroKernel.ModelBuilder.Descriptors.InterceptorDescriptor;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Fashion_Fuction.Services
{
    public class UserService : IUserService
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
            //var userQuery = from a in _context.usersTable
            //                join b in _context.UserRoles on a.Id equals b.UserId
            //                join c in _context.rolesTable on b.RoleId equals c.Id
            //                where a.IsDelete == false 
            //                select new { a, c };

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
            //var userQuery = _context.usersTable.FirstOrDefault(x => x.Id == userId);

            var userQuery = from a in _context.usersTable
                            join b in _context.UserRoles on a.Id equals b.UserId
                            join c in _context.rolesTable on b.RoleId equals c.Id
                            where b.UserId == userId
                            select new { a, c };


            if (userQuery != null && userQuery.GetEnumerator().MoveNext())
            {
                foreach (var item in userQuery)
                {
                    UserModel userModel = new UserModel();
                    userModel.Id = item.a.Id;
                    userModel.UserName = item.a.UserName;
                    userModel.Email = item.a.Email;
                    userModel.RoleName = item.c.Name;
                    userModel.IsDelete = item.a.IsDelete;

                    return userModel;
                }
            }
            else
            {
                var userFirtQuery = _context.usersTable.FirstOrDefault(x => x.Id == userId);
                if (userFirtQuery != null)
                {
                    UserModel userModel = new UserModel();
                    userModel.Id = userFirtQuery.Id;
                    userModel.UserName = userFirtQuery.UserName;
                    userModel.Email = userFirtQuery.Email;
                    userModel.RoleName = "";
                    userModel.IsDelete = userFirtQuery.IsDelete;

                    return userModel;
                }
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

                    await AssignToRole(userModel.Id, userModel.user_RoleIdNew);

                    return userModel;
                }

                return new UserModel();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<bool> UpdateUserBill(IFormCollection collection, string userId)
        {
            try
            {
                string firstName = collection["firstName"];
                string lastName = collection["lastName"];
                string country = collection["country"];
                string address = collection["address"];
                string city = collection["city"];
                string zip = collection["zip"];
                string phone = collection["phone"];
                string email = collection["email"];
                string discount = collection["discount"];

                // Add information
                var user = _context.usersTable.FirstOrDefault(x => x.Id == userId);

                if (user != null)
                {
                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.bill_Address1 = address;
                    user.bill_City = city;
                    user.bill_PostalCode = zip;
                    user.PhoneNumber = phone;
                    user.Email = email;
                    _context.usersTable.Update(user);
                }

                return true;
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


        public async Task<bool> AssignToRole(string userId, string roleIdNew)
        {
            try
            {
                var userRoleQuery = _context.UserRoles.FirstOrDefault(x => x.UserId == userId);

                if (userRoleQuery != null)
                {
                    _context.UserRoles.Remove(userRoleQuery);

                    userRoleQuery.RoleId = roleIdNew;
                    userRoleQuery.UserId = userId;

                    _context.UserRoles.Add(userRoleQuery);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    var identityUserRole = new IdentityUserRole<string>
                    {
                        RoleId = roleIdNew,
                        UserId = userId
                    };

                    _context.UserRoles.Add(identityUserRole);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
