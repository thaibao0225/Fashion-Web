using Microsoft.AspNetCore.Identity;

namespace Fashion_Infrastructure.Entities
{
    public class UsersTable : IdentityUser
    {
        public string Address { get; set; } = string.Empty;

        public List<BillsTable> billsTablesList { get; set; }
    }
}
