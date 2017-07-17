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
    public partial class OthersMenPage : System.Web.UI.Page
    {
        MenSetup_BLL objMenSetup_BLL = new MenSetup_BLL();
        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "500")
            {
                load_products500();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "1000")
            {
                load_products1000();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "2000")
            {
                load_products2000();
            }
            else if (((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "3000"))
            {
                load_products3000();
            }

            else if (ddlLowest_Price.SelectedValue.ToString() == "500" && ddlHighest_Price.SelectedValue.ToString() == "1000")
            {
                load_products500_1000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "500" && ddlHighest_Price.SelectedValue.ToString() == "2000")
            {
                load_products500_2000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "500" && ddlHighest_Price.SelectedValue.ToString() == "3000")
            {
                load_products500_3000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "500" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products500_Highest();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1000" && ddlHighest_Price.SelectedValue.ToString() == "2000")
            {
                load_products1000_2000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1000" && ddlHighest_Price.SelectedValue.ToString() == "3000")
            {
                load_products1000_3000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products1000_Highest();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1500" && ddlHighest_Price.SelectedValue.ToString() == "2000")
            {
                load_products1500_2000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1500" && ddlHighest_Price.SelectedValue.ToString() == "3000")
            {
                load_products1500_3000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "1500" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products1500_Highest();
            }
            else
            {
                load_products();
            }
            if (Request.QueryString.AllKeys.Contains("pro_id") && Request.QueryString.AllKeys.Contains("action"))
            {
                string pro_id = Request.QueryString["pro_id"];
                string action = Request.QueryString["action"];

                if (action.Equals("add"))
                {
                    add_to_cart(pro_id);
                }
            }
        }

        void load_products()
        {
            products_list = objMenSetup_BLL.GetAllOthersProducts();
        }

        void load_products500()
        {
            products_list = objMenSetup_BLL.GetAllOthers500Products();
        }

        void load_products1000()
        {
            products_list = objMenSetup_BLL.GetAllOthers1000Products();
        }

        void load_products2000()
        {
            products_list = objMenSetup_BLL.GetAllOthers2000Products();
        }

        void load_products3000()
        {
            products_list = objMenSetup_BLL.GetAllOthers3000Products();
        }
        void load_products500_1000()
        {
            products_list = objMenSetup_BLL.GetAllOthers500_1000Products();
        }
        void load_products500_2000()
        {
            products_list = objMenSetup_BLL.GetAllOthers500_2000Products();
        }
        void load_products500_3000()
        {
            products_list = objMenSetup_BLL.GetAllOthers500_3000Products();
        }

        void load_products500_Highest()
        {
            products_list = objMenSetup_BLL.GetAllOthers500_HighestProducts();
        }

        void load_products1000_2000()
        {
            products_list = objMenSetup_BLL.GetAllOthers1000_2000Products();
        }

        void load_products1000_3000()
        {
            products_list = objMenSetup_BLL.GetAllOthers1000_3000Products();
        }

        void load_products1000_Highest()
        {
            products_list = objMenSetup_BLL.GetAllOthers1000_HighestProducts();
        }

        void load_products1500_2000()
        {
            products_list = objMenSetup_BLL.GetAllOthers1500_2000Products();
        }

        void load_products1500_3000()
        {
            products_list = objMenSetup_BLL.GetAllOthers1500_3000Products();
        }

        void load_products1500_Highest()
        {
            products_list = objMenSetup_BLL.GetAllOthers1500_HighestProducts();
        }

        void add_to_cart(string id)
        {
            var product = products_list.Where(x => x.Product_Id == id);

            foreach (var data in product)
            {
                cart_list.Add(data);
            }

            Session["cart"] = cart_list;

        }

    }
}