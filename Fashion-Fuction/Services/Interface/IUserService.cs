using Fashion_Fuction.Models;
using Microsoft.AspNetCore.Http;

namespace Fashion_Fuction.Services.Interface
{
    public interface IUserService
    {
        public List<UserModel> GetAllUser();
        public UserModel GetUserById(string userId);
        public Task<UserModel> UpdateUser(UserModel userModel);
        public Task<bool> DeleteUser(string userId);
        public Task<bool> AssignToRole(string userId, string roleIdNew);
        public Task<bool> UpdateUserBill(IFormCollection collection, string userId);
    }
}
