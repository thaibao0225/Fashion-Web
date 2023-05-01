namespace Fashion_Infrastructure.Entities
{
    public class CartTable
    {
        public string cart_ProductId { get; set; }
        public ProductsTable cart_Product { get; set; }


        public string cart_SizeId { get; set; }
        public SizeTable cart_Size { get; set; }

        public string cart_ColorId { get; set; }
        public ColorsTable cart_Color { get; set; }

        public string cart_UserId { get; set; }
        public UsersTable cart_User { get; set; }

        public int cart_Quantity { get; set; }
    }
}
