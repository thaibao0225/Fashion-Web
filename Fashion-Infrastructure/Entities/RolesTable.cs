using Microsoft.AspNetCore.Identity;
namespace Fashion_Infrastructure.Entities
{
    public class RolesTable: IdentityRole
    {
        public Boolean IsDelete { get; set; } = false;
    }
}
