namespace Fashion_Admin.Services
{
    public interface IRoleService
    {
        public string GetRoleId(string userId);

        public string GetRoleName(string roleId);
    }
}
