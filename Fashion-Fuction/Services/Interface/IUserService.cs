using Fashion_Fuction.Models;

namespace Fashion_Fuction.Services.Interface
{
    public interface IUserService
    {
        public List<UserModel> GetAllUser();
        public UserModel GetUserById(string userId);
        public Task<UserModel> UpdateUser(UserModel userModel);
        public Task<bool> DeleteUser(string userId);
    }
}
