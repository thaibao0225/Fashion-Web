using Fashion_Fuction.Models;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services
{
    public class BillService
    {
        private ApplicationDbContext _context;

        public BillService(ApplicationDbContext context)
        {
            _context = context;
        }

        public BillModel PrepareBill(string userId, List<ProductModel> productList, int discount = 0)
        {
            double sumPrice = 0;
            BillModel billModel = new BillModel();

            billModel.bill_Id = Guid.NewGuid().ToString();
            billModel.bill_UserId = userId;
            billModel.bill_CreateOn = DateTime.Now;
            billModel.bill_IsConfirm = false;
            billModel.bill_IsPayment = false;

            billModel.productsList = new List<ProductModel>();
            foreach (var productItem in productList)
            {
                ProductModel product = new ProductModel();
                product.product_Id = productItem.product_Id;
                product.product_Name = productItem.product_Name;
                product.product_Img1 = productItem.product_Img1;
                product.product_Price = productItem.product_Price;
                product.product_Quantity = productItem.product_Quantity;
                product.product_ColorName = productItem.product_ColorName;
                product.product_SizeName = productItem.product_SizeName;
                sumPrice = sumPrice + productItem.product_Price;


                billModel.productsList.Add(product);
            }

            billModel.bill_Price = sumPrice; //
            return billModel;
        }

        public string GenProductId(List<ProductModel> productList)
        {
            string productIdString = "";
            foreach (var item in productList)
            {
                productIdString = productIdString + item.product_Id + "|";
            }
            return productIdString;
        }

        public string GenProductPrice(List<ProductModel> productList)
        {
            string productPriceString = "";
            foreach (var item in productList)
            {
                productPriceString = productPriceString + item.product_Price + "|";
            }
            return productPriceString;
        }
        public string GenProductQuantity(List<ProductModel> productList)
        {
            string productQuantityString = "";
            foreach (var item in productList)
            {
                productQuantityString = productQuantityString + item.product_Quantity + "|";
            }
            return productQuantityString;
        }

        public string GenProductColor(List<ProductModel> productList)
        {
            string productColorString = "";
            foreach (var item in productList)
            {
                productColorString = productColorString + item.product_ColorName + "|";
            }
            return productColorString;
        }

        public string GenProductSize(List<ProductModel> productList)
        {
            string productSizeString = "";
            foreach (var item in productList)
            {
                productSizeString = productSizeString + item.product_SizeName + "|";
            }
            return productSizeString;
        }

        public async Task<bool> CreateBill(string userId, BillModel bill)
        {
            BillsTable billsTable = new BillsTable();
            billsTable.bill_Id = bill.bill_Id;
            billsTable.bill_UserId = bill.bill_UserId;
            billsTable.bill_CreateOn = bill.bill_CreateOn;
            billsTable.bill_IsConfirm = bill.bill_IsConfirm;
            billsTable.bill_IsPayment = bill.bill_IsPayment;
            billsTable.bill_Price = bill.bill_Price;
            billsTable.bill_ProductsIdList = GenProductId(bill.productsList);
            billsTable.bill_ProductPriceList = GenProductPrice(bill.productsList);
            billsTable.bill_ProductUnitList = GenProductQuantity(bill.productsList);
            billsTable.bill_ProductColorList = GenProductColor(bill.productsList);
            billsTable.bill_ProductSizeList = GenProductSize(bill.productsList);

            await _context.billsTable.AddAsync(billsTable);
            await _context.SaveChangesAsync();

            return true;
        }

        //public BillModel GetBillById(string billId )
        //{

        //}

    }
}
