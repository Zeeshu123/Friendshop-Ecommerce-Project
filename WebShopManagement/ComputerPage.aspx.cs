﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.BLL;
using WebShopManagement.Model;

namespace WebShopManagement.Pages
{
    public partial class ComputerPage : System.Web.UI.Page
    {
        ComputerSetup_BLL objComputerSetup_BLL = new ComputerSetup_BLL();
        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (ddlLowest_Price.SelectedValue.ToString() == "Lowest_Price" && ddlHighest_Price.SelectedValue.ToString() == "5000")
            //{
            //    load_products5000();
            //}
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
            products_list = objComputerSetup_BLL.GetAllComputerProducts();
        }

        void load_products5000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer5000Products();
        }

        void load_products10000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer10000Products();
        }

        void load_products20000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer20000Products();
        }

        void load_products30000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer30000Products();
        }

        void load_products50000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer50000Products();
        }

        void load_products10000_20000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer10000_20000Products();
        }

        void load_products10000_30000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer10000_30000Products();
        }

        void load_products10000_50000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer10000_50000Products();
        }

        void load_products10000_Highest()
        {
            products_list = objComputerSetup_BLL.GetAllComputer10000_HighestProducts();
        }

        void load_products20000_30000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer20000_30000Products();
        }

        void load_products20000_50000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer20000_50000Products();
        }

        void load_products20000_Highest()
        {
            products_list = objComputerSetup_BLL.GetAllComputer20000_HighestProducts();
        }
        void load_products30000_50000()
        {
            products_list = objComputerSetup_BLL.GetAllComputer20000_50000Products();
        }
        void load_products30000_Highest()
        {
            products_list = objComputerSetup_BLL.GetAllComputer30000_HighestProducts();
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