using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.BOL;
using WebShopManagement.Model;

namespace WebShopManagement.admin.pages
{
    public partial class ReportPage : System.Web.UI.Page
    {
        ReportSetup_BLL objReportSetup_BLL = new ReportSetup_BLL();
        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnStockLowProduct_Click(object sender, EventArgs e)
        {
            GetAllStockLowProductDetails();
        }

        private void GetAllStockLowProductDetails()
        {
            List<Product_Viewer> lstLowProduct_Viewer = objReportSetup_BLL.GetAllLowProductDetails().ToList();

            if (lstLowProduct_Viewer.Count > 0)
            {
                dgvEmployee.DataSource = lstLowProduct_Viewer;
                dgvEmployee.DataBind();
            }
        }

        private void GetAllStockProductDetails()
        {
            List<Product_Viewer> lstLowProduct_Viewer = objReportSetup_BLL.GetAllStockProductDetails().ToList();

            if (lstLowProduct_Viewer.Count > 0)
            {
                dgvEmployee.DataSource = lstLowProduct_Viewer;
                dgvEmployee.DataBind();
            }
        }

        private void GetAllNoStockProductDetails()
        {
            List<Product_Viewer> lstLowProduct_Viewer = objReportSetup_BLL.GetAllNoStockProductDetails().ToList();

            if (lstLowProduct_Viewer.Count > 0)
            {
                dgvEmployee.DataSource = lstLowProduct_Viewer;
                dgvEmployee.DataBind();
            }
        }

        protected void btnStockFullProduct_Click(object sender, EventArgs e)
        {
            GetAllStockProductDetails();
        }

        protected void btnNoStockProduct_Click(object sender, EventArgs e)
        {
            GetAllNoStockProductDetails();
        }

    }
}