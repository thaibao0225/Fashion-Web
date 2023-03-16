namespace Fashion_Infrastructure.Entities
{
    public class EmailCustomerTable
    {
        public string emailC_Id { get; set; }
        public string emailC_Email { get; set; }
        public bool emailC_IsDelete { get; set; }

        public List<ContactTable> emailC_ContactTableList { get; set; }
    }
}
