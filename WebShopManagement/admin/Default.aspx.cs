using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_Cart.admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        void login(string email,string password)
        {
            //string query = "Select Count (*) from admins where username='"+email+"' AND password = '"+password+"'";

            //int count = db.get_scalar(query);
            //if (count==1)
            //{
            //    Response.Redirect("pages/Default.aspx");
            //}
            //else
            //{
            //    msg_lbl.Text = "Failed to Log in. Please Try Again";
            //}
        }
        protected void signin_btn_Click(object sender, EventArgs e)
        {
            //login(email_box.Value, password.Value);
        }
    }
}