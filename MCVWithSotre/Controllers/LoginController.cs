using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;

namespace MCVWithSotre.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index_Login()
        {
            return View();
        }

        public ActionResult login(tbl_Employee objEmployee)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var data =
                    context.tbl_Employee.Where(
                        a =>
                            a.AccountEmployee.Equals(objEmployee.AccountEmployee) &&
                            a.C_Password.Equals(objEmployee.C_Password)).FirstOrDefault();
                if (data != null)
                {
                    Session["Userid"] = data.EmployeeID;
                    Session["UserName"] = data.EmployeeName;
                    return Json("OK", JsonRequestBehavior.AllowGet);
                }
                return Json("Not OK", JsonRequestBehavior.AllowGet);
            }
        }
    }
}