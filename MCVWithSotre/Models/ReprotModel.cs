using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCVWithSotre.Database;

namespace MCVWithSotre.Models
{
    public class ReprotModel
    {
        public string CustomerName { get; set; }
        public Nullable<int> TotalProduct { get; set; }
        public Nullable<double> TotalMoney { get; set; }
        public System.DateTime? TuNgay { get; set; }
        public System.DateTime? Denngay { get; set; }
    }
}