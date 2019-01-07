using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCVWithSotre.Controllers
{
    public class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            base.ExecuteCore();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["UserName"] == null)
            {
                filterContext.Result = RedirectToAction("Index_Login", "Login");
            }
            
        }
        protected override bool DisableAsyncSupport
        {
            get
            {
                return true;
            }
        }
    }
}