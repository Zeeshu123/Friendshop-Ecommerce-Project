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
    public partial class Sign_Up : System.Web.UI.Page
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        CustomerSetup_BLL objCustomerSetup_BLL = new CustomerSetup_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            tbl_CustomerInfo atbl_CustomerInfo = new tbl_CustomerInfo();
            atbl_CustomerInfo.Name = txtName.Text;
            atbl_CustomerInfo.Password = txtPassword.Text;
            atbl_CustomerInfo.Email = txtEmail.Text;
            atbl_CustomerInfo.Address = txtAddress.Text;
            atbl_CustomerInfo.Phone = txtPhone.Text;


            int count = (from emp in _context.tbl_CustomerInfo
                         where emp.Name == atbl_CustomerInfo.Name
                         && emp.Password == atbl_CustomerInfo.Password
                         select emp.Name).Count();

            if (count > 0)
            {
                msg_lbl.Visible = true;
                msg_lbl.Text = "User already exists!";
                return;
            }
            objCustomerSetup_BLL.SaveSignCustomer(atbl_CustomerInfo);
            msg_lbl.Visible = true;
            msg_lbl.Text = "SignUp Successfully";

            txtName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
    }
}