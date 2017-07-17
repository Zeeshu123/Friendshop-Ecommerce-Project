using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;

namespace WebShopManagement
{
    public partial class Product_ViewPage : System.Web.UI.Page
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();

        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.AllKeys.Contains("pro_id"))
            {
                load_data();
            }
            
        }
        void load_data()
        {
            id = Request.QueryString["pro_id"].ToString();
            products_list = objProductSetup_BLL.GetSingleProductInfo(id).ToList();
        }
    }
}