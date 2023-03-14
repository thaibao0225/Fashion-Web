using System.ComponentModel;

namespace Fashion_Model.Models
{
    public class BillsModel
    {
        public string bill_Id { get; set; }

        [DisplayName("Bill Code")]
        public int bill_Code { get; set; }

        [DisplayName("User Id")]
        public string bill_UserId { get; set; }

        [DisplayName("User Name")]
        public string bill_UserName { get; set; }

        [DisplayName("Price")]
        public double bill_Price { get; set; }

        [DisplayName("Product Id List")]
        public string bill_ProductsIdList { get; set; }

        [DisplayName("Product Price List")]
        public string bill_ProductPriceList { get; set; }

        [DisplayName("Product Unit List")]
        public string bill_ProductUnitList { get; set; }

        [DisplayName("Product Color List")]
        public string bill_ProductColorList { get; set; }

        [DisplayName("Product Size List")]
        public string bill_ProductSizeList { get; set; }
    }
}
