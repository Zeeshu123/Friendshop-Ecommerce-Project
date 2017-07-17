using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_Cart.admin.pages
{
    public partial class orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int pid=Convert.ToInt16(Session["Product_Id"]);
            hdnproductId.Value = pid.ToString();
        }
    }
}