using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCVWithSotre.Database;

namespace MCVWithSotre.Models
{
    public class ReportCustomerModel
    {
        public string ProductName { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public int? CreateBy { get; set; }
        public Nullable<int> TotalProduct { get; set; }
        public Nullable<int> Quanlity { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<double> TotalMoney { get; set; }
    }
}