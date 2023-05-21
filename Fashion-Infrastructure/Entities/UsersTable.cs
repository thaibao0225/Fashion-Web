using Microsoft.AspNetCore.Identity;

namespace Fashion_Infrastructure.Entities
{
    public class UsersTable : IdentityUser
    {
        public string Address { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string bill_Address1 { set; get; } = string.Empty;
        public string bill_City { set; get; } = string.Empty;
        public string bill_State { set; get; } = string.Empty;
        public string bill_PostalCode { set; get; } = string.Empty;

        public Boolean IsDelete { get; set; } = false;

        public List<CommentTable> CommentTableList { get; set; }
        
        public List<BillsTable> billsTablesList { get; set; }
        public List<CartTable> cartTableList { get; set; }
    }
}
