using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.Model;
using WebShopManagement.Models;

namespace WebShopManagement
{
    public partial class Web : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] !=null)
            {
                lblUserName.Text = Session["username"].ToString();
                LnkLogin.Visible = false;                
                LnkSignup.Visible = false;
                lnkLogout.Visible = true;
                lblOr.Visible = false;
            }
            else
            {
                lblUserName.Text = "Empty Cart";
                lnkLogout.Visible = false;
                LnkLogin.Visible = true;
                LnkSignup.Visible = true;
                lblOr.Visible = true;
                count_lbl.Text = "";
            }
            
            if (Session["cart"] != null)
            {
                List<tbl_ProductInfo> cart_list = Session["cart"] as List<tbl_ProductInfo>;

                count_lbl.Text = cart_list.Count.ToString();
                count_lbl.Visible = true;
            } 
            else
            {
                count_lbl.Text = "";
            }
            

        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if ((txtSearch.Text == "tshirt") || (txtSearch.Text == "Tshirt") || (txtSearch.Text == "T-shirt") || (txtSearch.Text == "T-Shirt") || (txtSearch.Text == "TSHIRT") || (txtSearch.Text == "T-SHIRT"))
                {                                     
                        Response.Redirect("tShirt.aspx");                   
                }

                if ((txtSearch.Text == "shirt") || (txtSearch.Text == "SHIRT") || (txtSearch.Text == "Shirt"))
                {
                    Response.Redirect("ShirtMenPage.aspx");
                }

                else if ((txtSearch.Text == "Jeans") || (txtSearch.Text == "Pent") || (txtSearch.Text == "pant") || (txtSearch.Text == "Pant") || (txtSearch.Text == "pent") || (txtSearch.Text == "jeans") || (txtSearch.Text == "JEANS") || (txtSearch.Text == "Jins") || (txtSearch.Text == "Jens"))
                {
                        Response.Redirect("JeansPage.aspx");
                }

                else if ((txtSearch.Text == "Panjabi") || (txtSearch.Text == "panjabi") || (txtSearch.Text == "PANJABI") || (txtSearch.Text == "Punjabi") || (txtSearch.Text == "PUNJABI"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }

                else if ((txtSearch.Text == "Shoes") || (txtSearch.Text == "shoes") || (txtSearch.Text == "SHOE") || (txtSearch.Text == "shoe") || (txtSearch.Text == "SHOES"))
                {
                    Response.Redirect("MenShoePage.aspx");
                }

                else if ((txtSearch.Text == "Formal Dress") || (txtSearch.Text == "formal shirt") || (txtSearch.Text == "formal Pant") || (txtSearch.Text == "formal Pent") || (txtSearch.Text == "formal dress") || (txtSearch.Text == "formaldress"))
                {
                    Response.Redirect("FormaldressPage.aspx");
                }

                else if ((txtSearch.Text == "OPPO") || (txtSearch.Text == "oppo") || (txtSearch.Text == "oppo mobile") || (txtSearch.Text == "OPPO MOBILE") || (txtSearch.Text == "OPPOMOBILE") || (txtSearch.Text == "oppomobile") || (txtSearch.Text == "Oppo"))
                {
                    Response.Redirect("OppoPage.aspx");
                }

                else if ((txtSearch.Text == "Symphony") || (txtSearch.Text == "symphony") || (txtSearch.Text == "SYMPHONY") || (txtSearch.Text == "SYMPHONYMOBILE") || (txtSearch.Text == "sysmphonymobile"))
                {
                    Response.Redirect("SymphonyPage.aspx");
                }

                else if ((txtSearch.Text == "Samsung") || (txtSearch.Text == "samsung") || (txtSearch.Text == "SAMSUNG") || (txtSearch.Text == "SAMSUNG MOBILE") || (txtSearch.Text == "samsung mobile"))
                {
                    Response.Redirect("SamsungPage.aspx");
                }
            }
        }
        protected void Searchbtn_Click(object sender, ImageClickEventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if ((txtSearch.Text == "tshirt") || (txtSearch.Text == "Tshirt") || (txtSearch.Text == "T-shirt") || (txtSearch.Text == "T-Shirt") || (txtSearch.Text == "TSHIRT") || (txtSearch.Text == "T-SHIRT"))
                {
                    Response.Redirect("tShirt.aspx");
                }

                else if ((txtSearch.Text == "Jeans") || (txtSearch.Text == "jeans") || (txtSearch.Text == "JEANS"))
                {
                    Response.Redirect("JeansBtnFive.aspx");
                }

                else if ((txtSearch.Text == "Panjabi") || (txtSearch.Text == "panjabi") || (txtSearch.Text == "PANJABI") || (txtSearch.Text == "Punjabi") || (txtSearch.Text == "PUNJABI"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }

                else if ((txtSearch.Text == "PoloShirt") || (txtSearch.Text == "poloshirt") || (txtSearch.Text == "Polo Shirt") || (txtSearch.Text == "polo shirt") || (txtSearch.Text == "POLOSHIRT") || (txtSearch.Text == "POLO SHIRT"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }

                else if ((txtSearch.Text == "Shoes") || (txtSearch.Text == "shoes") || (txtSearch.Text == "SHOE") || (txtSearch.Text == "shoe") || (txtSearch.Text == "SHOES"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }

                else if ((txtSearch.Text == "WATCH") || (txtSearch.Text == "watch") || (txtSearch.Text == "Clock") || (txtSearch.Text == "clock") || (txtSearch.Text == "wristwatch") || (txtSearch.Text == "Wristwatch"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }

                else if ((txtSearch.Text == "Formal Dress") || (txtSearch.Text == "formal shirt") || (txtSearch.Text == "formal Pant") || (txtSearch.Text == "formal Pent") || (txtSearch.Text == "formal dress"))
                {
                    Response.Redirect("panjabiPage.aspx");
                }           
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Home.aspx");
            Session["cart"] = "";

        }

        //protected void btnLogout_Click(object sender, EventArgs e)
        //{
        //    
        //}
    }
}