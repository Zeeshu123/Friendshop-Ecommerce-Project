using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;

namespace WebShopManagement
{
    public partial class checkout : System.Web.UI.Page
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();

        CartSetup_BLL objCartSetup_BLL = new CartSetup_BLL();

        OrderSetup_BLL objOrderSetup_BLL = new OrderSetup_BLL();

        CustomerSetup_BLL objCustomerSetup_BLL = new CustomerSetup_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            tbl_CustomerInfo atbl_CustomerInfo = new tbl_CustomerInfo();
            
            if (Session["username"]!=null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=SOJIB;Initial Catalog=WebshopManagement;User ID=sa;Password=sa987;MultipleActiveResultSets=True;Application Name=EntityFramework");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_CustomerInfo where Name = '" + Session["username"].ToString() + "' and Password = '" + Session["password"].ToString() + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                con.Close();
                //Binding TextBox From dataTable
                txtName.Text = Session["username"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();

                msg_Notice.Visible = true;

                msg_Notice.Text = "You can change your personal Info...";

            }


            lblAmount.Text = Session["Amount"].ToString();
        }


        void add_cart(string product_id, string session_id)
        {
            tbl_Cart atbl_Cart = new tbl_Cart();

            atbl_Cart.Product_Id = product_id;
            atbl_Cart.Session_Id = session_id;

            objCartSetup_BLL.InsertCart(atbl_Cart);
        }




        protected void btn_Checkout_Click(object sender, EventArgs e)
        {
            tbl_Order atbl_Order = new tbl_Order();

            string Session_id =Convert.ToBase64String(Guid.NewGuid().ToByteArray());

            if(Session["cart"] != null)
            {
                List<tbl_ProductInfo> cart = Session["cart"] as List<tbl_ProductInfo>;

                foreach(var item in cart)
                {
                    add_cart(item.Product_Id, Session_id);
                }

                atbl_Order.Session_Id = Session_id;

                atbl_Order.Customer_Name = txtName.Text;
                atbl_Order.Customer_Email = txtEmail.Text;
                atbl_Order.Customer_Phone = txtPhone.Text;
                atbl_Order.Customer_Address = txtAddress.Text;
                atbl_Order.Order_Price = lblAmount.Text;
                atbl_Order.Edit_Date = DateTime.Now;


                objOrderSetup_BLL.InsertOrder(atbl_Order);


                lbl_msg.Visible = true;
                lbl_msg.Text = "Thank you "+ txtName.Text +". Your Order is successfully Placed. We will Contact with you very soon...";
                txtName.Text = "";

            }
        }
    }
}