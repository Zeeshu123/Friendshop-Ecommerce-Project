using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;

namespace WebShopManagement.Pages
{
    public partial class WomenPage : System.Web.UI.Page
    {
        WomenSetup_BLL objWomenSetup_BLL = new WomenSetup_BLL();
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
            products_list = objWomenSetup_BLL.GetAllWomenProducts();
        }

        void load_products500()
        {
            products_list = objWomenSetup_BLL.GetAllWomen500Products();
        }

        void load_products1000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1000Products();
        }

        void load_products2000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen2000Products();
        }

        void load_products3000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen3000Products();
        }
        void load_products500_1000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen500_1000Products();
        }
        void load_products500_2000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen500_2000Products();
        }
        void load_products500_3000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen500_3000Products();
        }

        void load_products500_Highest()
        {
            products_list = objWomenSetup_BLL.GetAllWomen500_HighestProducts();
        }

        void load_products1000_2000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1000_2000Products();
        }

        void load_products1000_3000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1000_3000Products();
        }

        void load_products1000_Highest()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1000_HighestProducts();
        }

        void load_products1500_2000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1500_2000Products();
        }

        void load_products1500_3000()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1500_3000Products();
        }

        void load_products1500_Highest()
        {
            products_list = objWomenSetup_BLL.GetAllWomen1500_HighestProducts();
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