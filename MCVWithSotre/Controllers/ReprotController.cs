using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;
using MCVWithSotre.Models;

namespace MCVWithSotre.Controllers
{
    public class ReprotController : BaseController
    {
        // GET: Reprot
        public ActionResult IndexReport()
        {
            return View();
        }

        public ActionResult SearchCustomer(ReprotModel obj)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                // cach 1
                var datasearch =
                    context.Database.SqlQuery<ReprotModel>("exec sp_OrderCustomer_RP '" + obj.TuNgay + "','" + obj.Denngay
                                                       + "'").ToList();

                // cach 2
                //var data = context.sp_OrderCustomer_RP(obj.TuNgay, obj.Denngay);
                return Json(datasearch, JsonRequestBehavior.AllowGet);
            }
        }
    }
}