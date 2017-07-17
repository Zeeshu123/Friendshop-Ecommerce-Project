using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.BOL;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class ReportSetup_BLL
    {
        ReportSetup_DAL objReportSetup_DAL = new ReportSetup_DAL();

        internal List<tbl_ProductInfo> GetAllProduct()
        {
            return objReportSetup_DAL.GetAllProduct();
        }

        public IEnumerable<Product_Viewer> GetAllLowProductDetails()
        {
            return objReportSetup_DAL.GetAllLowProductDetails();
        }

        public IEnumerable<Product_Viewer> GetAllStockProductDetails()
        {
            return objReportSetup_DAL.GetAllStockProductDetails();
        }

        public IEnumerable<Product_Viewer> GetAllNoStockProductDetails()
        {
            return objReportSetup_DAL.GetAllNoStockProductDetails();
        }

    }
}