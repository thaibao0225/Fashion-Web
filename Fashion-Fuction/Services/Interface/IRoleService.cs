namespace Fashion_Fuction.Services.Interface
{
    public interface IRoleService
    {
        public string GetRoleId(string userId);

        public string GetRoleName(string roleId);
    }
}
