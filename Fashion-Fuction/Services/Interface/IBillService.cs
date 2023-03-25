using Fashion_Fuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services.Interface
{
    public interface IBillService
    {
        public BillModel PrepareBill(string userId, List<ProductModel> productList, int discount = 0);
        public Task<bool> CreateBill(string userId, BillModel bill);
        public Task<bool> ChangeStatusConfirmBillById(string billId);
        public Task<bool> ChangeStatusUnconfirmBillById(string billId);
        public Task<bool> ChangeStatusPaymentBillById(string billId);
        public Task<bool> ChangeStatusUnpaymentBillById(string billId);
        public Task<bool> DeletePayment(string billId);
        public BillModel GetBillById(string billId);
        public List<BillModel> GetBill();
        public Task<bool> DeleteBill(string billId);
    }
}
