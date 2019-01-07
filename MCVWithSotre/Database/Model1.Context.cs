﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCVWithSotre.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BANHANG_THUCTAPEntities : DbContext
    {
        public BANHANG_THUCTAPEntities()
            : base("name=BANHANG_THUCTAPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
        public virtual DbSet<tbl_GroupCustomer> tbl_GroupCustomer { get; set; }
        public virtual DbSet<tbl_GroupProduct> tbl_GroupProduct { get; set; }
        public virtual DbSet<tbl_GroupUser> tbl_GroupUser { get; set; }
        public virtual DbSet<tbl_Manager> tbl_Manager { get; set; }
        public virtual DbSet<tbl_OrderDetail> tbl_OrderDetail { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_Receipt> tbl_Receipt { get; set; }
        public virtual DbSet<tbl_Order> tbl_Order { get; set; }
    
        public virtual ObjectResult<string> sp_Product_Delete(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Product_Delete", productIdParameter);
        }
    
        public virtual ObjectResult<string> sp_Product_Save(Nullable<int> productId, string productName, Nullable<double> priceProduct, Nullable<int> createBy, Nullable<int> groupProductId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var priceProductParameter = priceProduct.HasValue ?
                new ObjectParameter("PriceProduct", priceProduct) :
                new ObjectParameter("PriceProduct", typeof(double));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var groupProductIdParameter = groupProductId.HasValue ?
                new ObjectParameter("GroupProductId", groupProductId) :
                new ObjectParameter("GroupProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Product_Save", productIdParameter, productNameParameter, priceProductParameter, createByParameter, groupProductIdParameter);
        }
    
        public virtual ObjectResult<sp_GoupProduct_List_Result> sp_GoupProduct_List(Nullable<int> groupProductId)
        {
            var groupProductIdParameter = groupProductId.HasValue ?
                new ObjectParameter("GroupProductId", groupProductId) :
                new ObjectParameter("GroupProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GoupProduct_List_Result>("sp_GoupProduct_List", groupProductIdParameter);
        }
    
        public virtual ObjectResult<sp_Employee_List_Result> sp_Employee_List(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Employee_List_Result>("sp_Employee_List", employeeIDParameter);
        }
    
        public virtual ObjectResult<sp_Customer_List_Result> sp_Customer_List(Nullable<int> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Customer_List_Result>("sp_Customer_List", customerIDParameter);
        }
    
        public virtual ObjectResult<sp_Order_List_Result> sp_Order_List(Nullable<int> orderId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Order_List_Result>("sp_Order_List", orderIdParameter);
        }
    
        public virtual ObjectResult<string> sp_Order_Save(Nullable<int> orderId, string orderCode, string orderName, Nullable<int> createBy, Nullable<int> totalProduct, Nullable<double> moneyDiscount, Nullable<double> discountMoneyDirectly, Nullable<double> totalMoney, Nullable<int> customerId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var orderCodeParameter = orderCode != null ?
                new ObjectParameter("OrderCode", orderCode) :
                new ObjectParameter("OrderCode", typeof(string));
    
            var orderNameParameter = orderName != null ?
                new ObjectParameter("OrderName", orderName) :
                new ObjectParameter("OrderName", typeof(string));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var totalProductParameter = totalProduct.HasValue ?
                new ObjectParameter("TotalProduct", totalProduct) :
                new ObjectParameter("TotalProduct", typeof(int));
    
            var moneyDiscountParameter = moneyDiscount.HasValue ?
                new ObjectParameter("MoneyDiscount", moneyDiscount) :
                new ObjectParameter("MoneyDiscount", typeof(double));
    
            var discountMoneyDirectlyParameter = discountMoneyDirectly.HasValue ?
                new ObjectParameter("DiscountMoneyDirectly", discountMoneyDirectly) :
                new ObjectParameter("DiscountMoneyDirectly", typeof(double));
    
            var totalMoneyParameter = totalMoney.HasValue ?
                new ObjectParameter("TotalMoney", totalMoney) :
                new ObjectParameter("TotalMoney", typeof(double));
    
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Order_Save", orderIdParameter, orderCodeParameter, orderNameParameter, createByParameter, totalProductParameter, moneyDiscountParameter, discountMoneyDirectlyParameter, totalMoneyParameter, customerIdParameter);
        }
    
        public virtual int sp_OrderDetail_Save(Nullable<int> orderId, Nullable<int> productId, Nullable<int> quanlity, Nullable<double> priceProduct, Nullable<double> discount, Nullable<double> moneyDiscount, Nullable<double> totalMoney)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var quanlityParameter = quanlity.HasValue ?
                new ObjectParameter("Quanlity", quanlity) :
                new ObjectParameter("Quanlity", typeof(int));
    
            var priceProductParameter = priceProduct.HasValue ?
                new ObjectParameter("PriceProduct", priceProduct) :
                new ObjectParameter("PriceProduct", typeof(double));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(double));
    
            var moneyDiscountParameter = moneyDiscount.HasValue ?
                new ObjectParameter("MoneyDiscount", moneyDiscount) :
                new ObjectParameter("MoneyDiscount", typeof(double));
    
            var totalMoneyParameter = totalMoney.HasValue ?
                new ObjectParameter("TotalMoney", totalMoney) :
                new ObjectParameter("TotalMoney", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OrderDetail_Save", orderIdParameter, productIdParameter, quanlityParameter, priceProductParameter, discountParameter, moneyDiscountParameter, totalMoneyParameter);
        }
    
        public virtual ObjectResult<sp_OrderCustomer_RP_Result> sp_OrderCustomer_RP(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_OrderCustomer_RP_Result>("sp_OrderCustomer_RP", tungayParameter, denngayParameter);
        }
    
        public virtual ObjectResult<sp_ReportCustomer_RP_Result> sp_ReportCustomer_RP(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReportCustomer_RP_Result>("sp_ReportCustomer_RP", customerIdParameter);
        }
    
        public virtual ObjectResult<string> sp_xml_Product_Save(string xmlParameter)
        {
            var xmlParameterParameter = xmlParameter != null ?
                new ObjectParameter("XmlParameter", xmlParameter) :
                new ObjectParameter("XmlParameter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_xml_Product_Save", xmlParameterParameter);
        }
    
        public virtual ObjectResult<sp_Product_List_Result> sp_Product_List(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Product_List_Result>("sp_Product_List", productIdParameter);
        }
    
        public virtual int sp_OrderDetail_xml_Save(string xmlParameter)
        {
            var xmlParameterParameter = xmlParameter != null ?
                new ObjectParameter("XmlParameter", xmlParameter) :
                new ObjectParameter("XmlParameter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OrderDetail_xml_Save", xmlParameterParameter);
        }
    
        public virtual int sp_OrderOrderDetail_xml_Save(string xmlParameter)
        {
            var xmlParameterParameter = xmlParameter != null ?
                new ObjectParameter("XmlParameter", xmlParameter) :
                new ObjectParameter("XmlParameter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OrderOrderDetail_xml_Save", xmlParameterParameter);
        }
    }
}