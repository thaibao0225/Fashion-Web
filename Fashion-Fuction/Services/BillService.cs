using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services
{
    public class BillService : IBillService
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

        public async Task<bool> ChangeStatusConfirmBillById(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);
            if (billQuery != null)
            {
                billQuery.bill_IsConfirm = true;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> ChangeStatusUnconfirmBillById(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);
            if (billQuery != null)
            {
                billQuery.bill_IsConfirm = false;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ChangeStatusPaymentBillById(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);
            if (billQuery != null)
            {
                billQuery.bill_IsPayment = true;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ChangeStatusUnpaymentBillById(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);
            if (billQuery != null)
            {
                billQuery.bill_IsPayment = false;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeletePayment(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);
            if (billQuery != null)
            {
                billQuery.IsDelete = true;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        //string productIdString,
        //    string productPriceString,
        //    string productQuantityString,
        //    string productColorString,
        //    string productSizeString

        public List<ProductModel> UnGenProductString(
            string productIdString,
            string productPriceString,
            string productQuantityString,
            string productColorString,
            string productSizeString
            )
        {
            List<ProductModel> productsList = new List<ProductModel>();
            var productIdArray = productIdString.Split('|');
            var productPriceArray = productPriceString.Split('|');
            var productQuantityArray = productQuantityString.Split('|');
            var productColorArray = productColorString.Split('|');
            var productSizeArray = productSizeString.Split('|');

            int lengthArray = productIdArray.Length;

            if ((productIdArray.Length == lengthArray) &&
                (productPriceArray.Length == lengthArray) &&
                (productQuantityArray.Length == lengthArray) &&
                (productColorArray.Length == lengthArray) &&
                (productSizeArray.Length == lengthArray))
            {
                int index = 0;
                foreach (var item in productIdArray)
                {
                    ProductModel productModel = new ProductModel();
                    productModel.product_Id = productIdArray[index];
                    productModel.product_Price = double.Parse(productPriceArray[index]);
                    productModel.product_Quantity = productQuantityArray[index];
                    productModel.product_ColorName = productColorArray[index];
                    productModel.product_SizeName = productSizeArray[index];

                    productsList.Add(productModel);
                    index++;
                }


                return productsList;
            }
            return new List<ProductModel>();
        }

        public BillModel GetBillById(string billId)
        {
            var billQuery = _context.billsTable.FirstOrDefault(x => x.bill_Id == billId);

            if (billQuery != null)
            {
                BillModel billModel = new BillModel();
                billModel.bill_Id = billId;
                billModel.bill_UserId = billQuery.bill_UserId;
                billModel.bill_CreateOn = billQuery.bill_CreateOn;
                billModel.bill_IsConfirm = billQuery.bill_IsConfirm;
                billModel.bill_IsPayment = billQuery.bill_IsPayment;
                billModel.bill_Price = billQuery.bill_Price;
                billModel.productsList = UnGenProductString(billQuery.bill_ProductsIdList,
                                                            billQuery.bill_ProductPriceList,
                                                            billQuery.bill_ProductUnitList,
                                                            billQuery.bill_ProductColorList,
                                                            billQuery.bill_ProductSizeList);


                return billModel;
            }
            return new BillModel();
        }

        public List<BillModel> GetBill()
        {

            List<BillModel> billList = new List<BillModel>();
            var billQuery = _context.billsTable.Where(x => x.IsDelete == false);

            if (billQuery != null)
            {
                foreach (var item in billQuery)
                {
                    BillModel billModel = new BillModel();
                    billModel.bill_Id = item.bill_Id;
                    billModel.bill_UserId = item.bill_UserId;
                    billModel.bill_Code = item.bill_Code;
                    var userQuery = _context.usersTable.FirstOrDefault(x => x.Id == item.bill_UserId);
                    if (userQuery != null)
                    {
                        billModel.bill_UserName = userQuery.UserName;
                    }
                    billModel.bill_CreateOn = item.bill_CreateOn;
                    billModel.bill_IsConfirm = item.bill_IsConfirm;
                    billModel.bill_IsPayment = item.bill_IsPayment;
                    billModel.bill_Price = item.bill_Price;
                    //billModel.productsList = UnGenProductString(billQuery.bill_ProductsIdList,
                    //                                            billQuery.bill_ProductPriceList,
                    //                                            billQuery.bill_ProductUnitList,
                    //                                            billQuery.bill_ProductColorList,
                    //                                            billQuery.bill_ProductSizeList);
                    billList.Add(billModel);
                }
                

                return billList;
            }
            return new List<BillModel>();
        }

    }
}
