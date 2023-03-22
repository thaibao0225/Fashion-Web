namespace Fashion_Infrastructure.Entities
{
    public class ContactTable : BaseTable
    {
        public string contact_Id { get; set; }
        public string contact_Name { get; set; }
        public string contact_EmailId { get; set; }
        public EmailCustomerTable contact_EmailCustomerTable { get; set; }

        public string emailC_Subject { get; set; }
        public string emailC_Message { get; set; }
        public bool emailC_IsCheck { get; set; }
    }
}
