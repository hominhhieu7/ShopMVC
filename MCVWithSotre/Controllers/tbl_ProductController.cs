using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;

namespace MCVWithSotre.Controllers
{
    public class tbl_ProductController : BaseController
    {
        
        // GET: tbl_Product
        public ActionResult Index(int id = 0)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var datapdd = context.sp_Product_List(0).ToList();
                ViewBag.List = datapdd;
                var GroupProduct = context.sp_GoupProduct_List(0).ToList();
                ViewBag.ListGroupProduct = GroupProduct;
                var Employee = context.sp_Employee_List(0).ToList();
                ViewBag.ListEmployee = Employee;
                if(id != 0)
                    return View(context.sp_Product_List(id).FirstOrDefault());
                else
                {
                    var nulldata = new sp_Product_List_Result();
                    nulldata.ProductID = 0;
                    nulldata.ProductName = "";
                    nulldata.PriceProduct = 0;
                    return View(nulldata);
                }
            }
           
        }
        public ActionResult Index_Product(int id = 0)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var datapdd = context.sp_Product_List(0).ToList();
                ViewBag.List = datapdd;
                var GroupProduct = context.sp_GoupProduct_List(0).ToList();
                ViewBag.ListGroupProduct = GroupProduct;
                var Employee = context.sp_Employee_List(0).ToList();
                ViewBag.ListEmployee = Employee;
                if (id != 0)
                    return View(context.sp_Product_List(id).FirstOrDefault());
                else
                {
                    var nulldata = new sp_Product_List_Result();
                    nulldata.ProductID = 0;
                    nulldata.ProductName = "";
                    nulldata.PriceProduct = 0;
                    return View(nulldata);
                }
            }

        }
        [HttpPost]
        public ActionResult Addnew(tbl_Product obj)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var add =
                    context.Database.SqlQuery<string>("EXEC dbo.sp_Product_Save @ProductID = " + obj.ProductID +
                                                      ", @ProductName = N'" + obj.ProductName + "', @PriceProduct = " +
                                                      obj.PriceProduct + ", @CreateBy = " + obj.CreateBy +
                                                      ", @GroupProductId = " + obj.GroupProductID).FirstOrDefault();
                if (add == "Khong ton tai nhom san pham nay")
                    Session["tb"] = "ll";
                else
                {
                    Session["tb"] = "ok";
                }
                return RedirectToAction("Index", "tbl_Product");
            }
        }
        public ActionResult Del(int id)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                 var del = context.Database.SqlQuery<string>("Exec sp_Product_Delete " + id ).First();
            }
            return RedirectToAction("Index", "tbl_Product");
        }
        [HttpPost]
        public ActionResult Addnewxml(string sp_xml_Product_Save)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var add =
                    context.Database.SqlQuery<string>("exec sp_xml_Product_Save N'" + sp_xml_Product_Save+"'")
                        .FirstOrDefault();

                return Json(add, JsonRequestBehavior.AllowGet);
            }
        }
    }
}