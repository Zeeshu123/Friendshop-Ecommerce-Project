using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;
using WebShopManagement.Models;

namespace WebShopManagement
{
    public partial class Product : System.Web.UI.Page
    {
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();
        List<tbl_ProductInfo> product_list = new List<tbl_ProductInfo>();
        //private int Product_Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //private void FillPage()
        //{
        //    if (!String.IsNullOrWhiteSpace(Request.QueryString["Product_Id"]))
        //    {
        //        int id = Convert.ToInt32(Request.QueryString["Product_Id"]);
        //        Product product = ProductModel.GetProduct(product_id);
        //    }
        //}
    }
}