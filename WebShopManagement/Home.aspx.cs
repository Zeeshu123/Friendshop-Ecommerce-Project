using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopManagement.Models;
using System.Data.SqlClient;
using WebShopManagement.Model;
using WebShopManagement.BLL;

namespace WebShopManagement
{
    public partial class Default : System.Web.UI.Page
    {
       
        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();
        ComputerSetup_BLL objComputerSetup_BLL = new ComputerSetup_BLL();
        MenSetup_BLL objMenSetup_BLL = new MenSetup_BLL();
        WomenSetup_BLL objWomenSetup_BLL = new WomenSetup_BLL();

        public List<tbl_ProductInfo> products_list = new List<tbl_ProductInfo>();

        public List<tbl_ProductInfo> wmproducts_list = new List<tbl_ProductInfo>();

        public List<tbl_ProductInfo> cmproducts_list = new List<tbl_ProductInfo>();

        public List<tbl_ProductInfo> mbproducts_list = new List<tbl_ProductInfo>();

        public List<tbl_ProductInfo> tvproducts_list = new List<tbl_ProductInfo>();

        public List<tbl_ProductInfo> approducts_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> cart_list = new List<tbl_ProductInfo>();

        static List<tbl_ProductInfo> SingleProduct_Info = new List<tbl_ProductInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            load_products();
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
            products_list = objProductSetup_BLL.GetAllProductInfo();
            cmproducts_list = objComputerSetup_BLL.GetAllComputerProducts();
            mbproducts_list = objProductSetup_BLL.GetAllMobileProducts();
            tvproducts_list = objProductSetup_BLL.GetAllTVCameraProducts();
            approducts_list = objProductSetup_BLL.GetAllAppliancesProducts();
            wmproducts_list = objWomenSetup_BLL.GetAllWomenProducts();
        }



        void add_to_cart(string id)
        {
            var product = products_list.Where(x => x.Product_Id == id);
           var mbproduct = mbproducts_list.Where(x => x.Product_Id == id);
           var cmproduct = cmproducts_list.Where(x => x.Product_Id == id);
           var tvproduct = tvproducts_list.Where(x => x.Product_Id == id);
           var approduct = approducts_list.Where(x => x.Product_Id == id);
           var wmproduct = wmproducts_list.Where(x => x.Product_Id == id);

            foreach(var data in product)
            {
                cart_list.Add(data);
                
            }
            foreach (var data in mbproduct)
            {
                cart_list.Add(data);
                
            }
            foreach (var data in wmproduct)
            {
                cart_list.Add(data);
            }

            foreach (var data in cmproduct)
            {
                cart_list.Add(data);
            }

            foreach (var data in tvproduct)
            {
                cart_list.Add(data);
            }

            foreach (var data in approduct)
            {
                cart_list.Add(data);
            }

            Session["cart"] = cart_list;
            
        }
    }
}