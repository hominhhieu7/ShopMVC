using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCVWithSotre.Database;

namespace MCVWithSotre.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public string OrderCode { get; set; }
        public string OrderName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> TotalProduct { get; set; }
        public Nullable<double> MoneyDiscount { get; set; }
        public Nullable<double> DiscountMoneyDirectly { get; set; }
        public Nullable<double> TotalMoney { get; set; }
        public Nullable<int> Inventory { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public List<tbl_OrderDetail> OrderDetail { get; set; }
    }
}