using Microsoft.AspNetCore.Identity;

namespace Fashion_Infrastructure.Entities
{
    public class UsersTable : IdentityUser
    {
        public string Address { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Boolean IsDelete { get; set; } = false;

        public List<BillsTable> billsTablesList { get; set; }
    }
}
