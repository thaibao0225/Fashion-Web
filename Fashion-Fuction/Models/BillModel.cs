using Fashion_Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Models
{
    public class BillModel
    {
        public string bill_Id { get; set; }
        [DisplayName("Code")]
        public int bill_Code { get; set; }


        public string bill_UserId { get; set; }

        [DisplayName("Customer")]
        public string bill_UserName { get; set; }

        [DisplayName("Price")]
        public double bill_Price { get; set; }
        //public string bill_ProductsIdList { get; set; }
        //public string bill_ProductPriceList { get; set; }
        //public string bill_ProductUnitList { get; set; }
        //public string bill_ProductColorList { get; set; }
        //public string bill_ProductSizeList { get; set; }

        [DisplayName("Create on")]
        public DateTime bill_CreateOn { get; set; }

        [DisplayName("Confirm")]
        public bool bill_IsConfirm { get; set; }

        [DisplayName("Payment")]
        public bool bill_IsPayment { get; set; }
        public List<ProductModel> productsList { get; set; }
    }
}
