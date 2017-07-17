using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;

namespace WebShopManagement
{
    public partial class Cart_View : System.Web.UI.Page
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();
        int total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            load_data();

            var footlbl = Products_gw.FooterRow.FindControl("totalAmount") as Label;
            if (footlbl != null)
            {
                footlbl.Text = total.ToString();
            }

        }

        void load_data()
        {
            List<tbl_ProductInfo> prods = Session["cart"] as List<tbl_ProductInfo>;

            Products_gw.DataSource = prods;
            Products_gw.DataBind();
        }

        protected void Products_gw_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var amountlbl = e.Row.FindControl("lblAmount") as Label;
                if (amountlbl != null)
                {
                    total += int.Parse(amountlbl.Text);
                    Session["Amount"] = total;
                }
            }

        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
                Response.Redirect("checkout.aspx");
        }

        protected void Products_gw_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<tbl_ProductInfo> prods = Session["cart"] as List<tbl_ProductInfo>;
            if (e.CommandName == "Delete") // Archive a chosen SOC by the SOCID and HandSetID.
            {
                prods.RemoveAt(Convert.ToInt16(e.CommandArgument));
                Products_gw.DataSource = prods;
                Products_gw.DataBind();
                Response.Redirect("Cart_View.aspx");
            }
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{

        //}

        //protected void Products_gw_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{

        //}

        //lsttbl_EmplyoeeAttendance.Add(atbl_EmplyoeeAttendance);

        //lblMessage.Visible = true;
        //lblMessage.Text = "Data Save Successfully";
    }

}