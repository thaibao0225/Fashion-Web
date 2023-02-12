namespace Fashion_Infrastructure.Entities
{
    public class BillsTable : BaseTable
    {
        public string bill_Id { get; set; }
        public string bill_Code { get; set; } = string.Empty;
        public string bill_UserId { get; set; }
        public UsersTable userTable_UserId { get; set; }
        public double bill_Price { get; set; } 
        public string bill_ProductsIdList { get; set; }
        public double bill_ProductPriceList { get; set; }
        public int bill_ProductUnitList { get; set; }
        public string bill_ProductColorList { get; set; }
        public string bill_ProductSizeList { get; set; }
    }
}
