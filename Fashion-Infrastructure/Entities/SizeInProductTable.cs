namespace Fashion_Infrastructure.Entities
{
    public class SizeInProductTable
    {
        public string sip_Id { get; set; }
        public SizeTable sip_Size { get; set; }

        public string sip_ProductId { get; set; }
        public ProductsTable sip_Product { get; set; }
        public int sip_QuantityExisting { get; set; }

        public bool sip_IsDelete { get; set; }
    }
}
