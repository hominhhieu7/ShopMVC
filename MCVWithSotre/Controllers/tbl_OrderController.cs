using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVWithSotre.Database;
using MCVWithSotre.Models;

namespace MCVWithSotre.Controllers
{
    public class tbl_OrderController : BaseController
    {
        // GET: tbl_Order
        public ActionResult Index()
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var DataProduct = context.sp_Product_List(0).ToList();
                ViewBag.ListDataProduct = DataProduct;
                var datacustomer = context.sp_Customer_List(0).ToList();
                ViewBag.ListDataCustomer = datacustomer;
                return View(context.sp_Product_List(0).FirstOrDefault());
            }
        }

        //Cách 1: 
        public ActionResult Addnew1(OrderModel objoOrder)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var dataorderid =
                    context.Database.SqlQuery<int>("exec sp_Order_Save 0,'OD+"+DateTime.Now.ToString("hh-mm-ss")+" ','Banhang',0," + objoOrder.TotalProduct + "," +
                                                      objoOrder.MoneyDiscount + "," + objoOrder.DiscountMoneyDirectly +
                                                      "," + objoOrder.TotalMoney + "," + objoOrder.CustomerId)
                        .FirstOrDefault();
                // luu detail
                foreach (var item in objoOrder.OrderDetail)
                {
                    // update bang detail
                    var sqlquery = "exec sp_OrderDetail_Save " + dataorderid + "," + item.ProductID + "," +
                                   item.Quanlity + ",0," + item.Discount + "," + item.MoneyDiscount + "," +
                                   item.TotalMoney;
                    context.Database.SqlQuery<string>(sqlquery).FirstOrDefault();

                    // cap nhat so luong ban vao san pham
                    context.Database.SqlQuery<string>("exec sp_Product_UpdateOrder " + item.ProductID + " ," +
                                                      item.Quanlity + " ").FirstOrDefault();

                }
            }
            return RedirectToAction("Index", "tbl_Order");
        }
        //Cách 2: dùng xml
        public ActionResult Addnew(string xml)
        {
            using (var context = new BANHANG_THUCTAPEntities())
            {
                var add =
                    context.Database.SqlQuery<string>("exec sp_OrderOrderDetail_xml_Save N'" + xml + "'")
                        .FirstOrDefault();
                return Json(add, JsonRequestBehavior.AllowGet);
            }
        }
    }
}