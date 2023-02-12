using Microsoft.AspNetCore.Identity;

namespace Fashion_Infrastructure.Entities
{
    public class Users : IdentityUser
    {
        public string Address { get; set; } = string.Empty;


    }
}
