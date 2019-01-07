using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;
using MCVWithSotre.Models;

namespace MCVWithSotre.Controllers
{
    public class ReportCustomerController : BaseController
    {
        // GET: ReportCustomer
        public ActionResult Index_RPCustomer()
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var dataCustomer = context.sp_Customer_List(0).ToList();
                ViewBag.ListCustomer = dataCustomer;
            }
            return View();
        }

        public ActionResult SearchCustomer(ReportCustomerModel objCustomer)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var datasearch =
                    context.Database.SqlQuery<ReportCustomerModel>("exec sp_ReportCustomer_RP " + objCustomer.CustomerId)
                        .ToList();

                return Json(datasearch, JsonRequestBehavior.AllowGet);
            }
        }
    }
}