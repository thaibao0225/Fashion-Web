namespace Fashion_Infrastructure.Entities
{
    public class BillsTable : BaseTable
    {
        public string bill_Id { get; set; }
        public int bill_Code { get; set; } 
        public string bill_UserId { get; set; }
        public UsersTable userTable_UserId { get; set; }
        public int bill_Price { get; set; } 
        public string bill_ProductsIdList { get; set; }
        public string bill_ProductPriceList { get; set; }
        public string bill_ProductUnitList { get; set; }
        public string bill_ProductColorList { get; set; }
        public string bill_ProductSizeList { get; set; }
        public DateTime bill_CreateOn { get; set; }
        public bool bill_IsConfirm { get; set; }
        public bool bill_IsPayment  { get; set; }
    }
}
