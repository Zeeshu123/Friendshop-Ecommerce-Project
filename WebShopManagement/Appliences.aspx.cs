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
    public partial class Appliences : System.Web.UI.Page
    {
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();
        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price" && ddlHighest_Price.SelectedValue.ToString() == "10000")
            {
                load_products10000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price" && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products20000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price" && ddlHighest_Price.SelectedValue.ToString() == "50000")
            {
                load_products50000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products10000_20000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products10000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "50000")
            {
                load_products10000_50000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products10000_Highest();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "20000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products20000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "20000" && ddlHighest_Price.SelectedValue.ToString() == "50000")
            {
                load_products20000_50000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "20000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products20000_Highest();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "30000" && ddlHighest_Price.SelectedValue.ToString() == "50000")
            {
                load_products30000_50000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "30000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products30000_Highest();
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
            products_list = objProductSetup_BLL.GetAllAppliancesProducts();
        }

        void load_products10000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances10000Products();
        }

        void load_products20000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances20000Products();
        }

        void load_products30000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances30000Products();
        }

        void load_products50000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances50000Products();
        }

        void load_products10000_20000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances10000_20000Products();
        }

        void load_products10000_30000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances10000_30000Products();
        }

        void load_products10000_50000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances10000_50000Products();
        }

        void load_products10000_Highest()
        {
            products_list = objProductSetup_BLL.GetAllAppliances10000_HighestProducts();
        }

        void load_products20000_30000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances20000_30000Products();
        }

        void load_products20000_50000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances20000_50000Products();
        }

        void load_products20000_Highest()
        {
            products_list = objProductSetup_BLL.GetAllAppliances20000_HighestProducts();
        }
        void load_products30000_50000()
        {
            products_list = objProductSetup_BLL.GetAllAppliances20000_50000Products();
        }
        void load_products30000_Highest()
        {
            products_list = objProductSetup_BLL.GetAllAppliances30000_HighestProducts();
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