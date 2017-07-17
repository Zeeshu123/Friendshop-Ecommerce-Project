using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.Model;

namespace WebShopManagement
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=SOJIB;Initial Catalog=WebshopManagement;User ID=sa;Password=sa987;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name,Password from tbl_CustomerInfo where Name = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                Session["username"] = txtUserName.Text;
                Session["password"] = txtPassword.Text;
                Response.Redirect("Home.aspx");
                 
            }
            else if (count > 0)
            {
                litStatus.Visible = true;
                litStatus.Text = "Duplicate Data Is Entry";
            }
            else
            {
                litStatus.Text = "Please Enter Valid UserName And Password";
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            
        }
    }
}