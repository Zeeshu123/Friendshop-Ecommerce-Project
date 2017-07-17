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
    public partial class SamsungPage : System.Web.UI.Page
    {
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();
        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "2000")
            {
                load_products2000();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "3000")
            {
                load_products3000();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "5000")
            {
                load_products5000();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "10000")
            {
                load_products10000();
            }
            else if ((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products20000();
            }
            else if (((ddlLowest_Price.SelectedValue.ToString() == "0" || ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price") && (ddlHighest_Price.SelectedValue.ToString() == "30000")))
            {
                load_products30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "3000")
            {
                load_products2000_3000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "5000")
            {
                load_products2000_5000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "10000")
            {
                load_products2000_10000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products2000_20000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products2000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "5000" && ddlHighest_Price.SelectedValue.ToString() == "10000")
            {
                load_products5000_10000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "5000" && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products5000_20000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "5000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products5000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "20000")
            {
                load_products10000_20000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products10000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "20000" && ddlHighest_Price.SelectedValue.ToString() == "30000")
            {
                load_products20000_30000();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "2000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products2000_Highest_Price();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "5000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products5000_Highest_Price();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "10000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products10000_Highest_Price();
            }
            else if (ddlLowest_Price.SelectedValue.ToString() == "20000" && ddlHighest_Price.SelectedValue.ToString() == "Highest_Price")
            {
                load_products20000_Highest_Price();
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
            products_list = objProductSetup_BLL.GetAllSamsungMobileProducts();
        }

        void load_products2000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000Products();
        }

        void load_products3000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile3000Products();
        }

        void load_products5000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile5000Products();
        }

        void load_products10000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile10000Products();
        }
        void load_products20000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile20000Products();
        }
        void load_products30000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile30000Products();
        }
        void load_products2000_3000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_3000Products();
        }
        void load_products2000_5000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_5000Products();
        }
        void load_products2000_10000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_10000Products();
        }

        void load_products2000_20000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_20000Products();
        }

        void load_products2000_30000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_30000Products();
        }

        void load_products5000_10000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile5000_10000Products();
        }

        void load_products5000_20000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile5000_20000Products();
        }

        void load_products5000_30000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile5000_30000Products();
        }

        void load_products10000_20000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile10000_20000Products();
        }

        void load_products10000_30000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile10000_30000Products();
        }

        void load_products20000_30000()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile20000_30000Products();
        }

        void load_products2000_Highest_Price()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile2000_Highest_Price();
        }

        void load_products5000_Highest_Price()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile5000_Highest_Price();
        }

        void load_products10000_Highest_Price()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile10000_Highest_Price();
        }

        void load_products20000_Highest_Price()
        {
            products_list = objProductSetup_BLL.GetAllSamsungMobile20000_Highest_Price();
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