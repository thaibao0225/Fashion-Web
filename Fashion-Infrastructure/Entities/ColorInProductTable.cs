namespace Fashion_Infrastructure.Entities
{
    public class ColorInProductTable
    {
        public string cip_ColorId { get; set; }
        public ColorsTable cip_Color { get; set; }

        public string cip_ProductId { get; set; }
        public ProductsTable cip_Product { get; set; }
        public int cip_QuantityExisting { get; set; }

        public bool cip_IsDelete { get; set; }
    }
}
