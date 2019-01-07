using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;
namespace MCVWithSotre.Controllers
{
    public class tbl_EmployeeController : BaseController
    {
        // GET: tbl_Employee
        public ActionResult Index_tbl_Employee()
        {
            return View();
        }

        
    }
}