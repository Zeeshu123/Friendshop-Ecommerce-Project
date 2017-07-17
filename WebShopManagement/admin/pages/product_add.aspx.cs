using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WebShopManagement.Model;
using WebShopManagement.BLL;

namespace Shopping_Cart.admin.pages
{
    public partial class product_add : System.Web.UI.Page
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        ProductSetup_BLL objProductSetup_BLL = new ProductSetup_BLL();

        CategorySetup_BLL aCategorySetup_BLL = new CategorySetup_BLL();

        List<tbl_ProductCategory> lsttbl_CategoryInfo = new List<tbl_ProductCategory>();

        List<tbl_ProductSubcategory> lsttbl_SubCategoryInfo = new List<tbl_ProductSubcategory>();

        List<tbl_ProductBrand> lsttbl_BrandInfo = new List<tbl_ProductBrand>();
          
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack!=true)
            {
                BindAllCategory();
                BindAllBrand();
            }
        }

        private void BindAllCategory()
        {
            lsttbl_CategoryInfo = aCategorySetup_BLL.GetAllCategory().ToList();

            ddlCategory.DataSource = lsttbl_CategoryInfo;
            ddlCategory.DataTextField = "Category_Name";
            ddlCategory.DataValueField = "Category_Id";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "--select--");
        }

        private void BindAllSubCategory()
        {
            lsttbl_SubCategoryInfo = aCategorySetup_BLL.GetAllSubCategory(Convert.ToInt32(ddlCategory.SelectedValue)).ToList();

            ddlSubCategory.DataSource = lsttbl_SubCategoryInfo;
            ddlSubCategory.DataTextField = "Subcategory_Name";
            ddlSubCategory.DataValueField = "Subcategory_Id";
            ddlSubCategory.DataBind();
            ddlSubCategory.Items.Insert(0, "--select--");
        }

        private void BindAllBrand()
        {
            lsttbl_BrandInfo = aCategorySetup_BLL.GetAllBrand().ToList();

            ddlBrand.DataSource = lsttbl_BrandInfo;
            ddlBrand.DataTextField = "Brand_Name";
            ddlBrand.DataValueField = "Brand_Id";
            ddlBrand.DataBind();
            ddlBrand.Items.Insert(0, "--select--");
        }
        
        protected void add_btn_Click(object sender, EventArgs e)
        {
            tbl_ProductInfo atbl_ProductInfo = new tbl_ProductInfo();
            atbl_ProductInfo.Product_Id = txtProductId.Text;
            atbl_ProductInfo.Product_Name = txtProductName.Text;
            atbl_ProductInfo.Category_Id = Convert.ToInt16(ddlCategory.SelectedValue);
            atbl_ProductInfo.Purchase_Rate = Convert.ToInt16(txtPurchase.Text);
            atbl_ProductInfo.Sell_Rate = Convert.ToInt16(txtSell.Text);
            atbl_ProductInfo.Brand_Id = Convert.ToInt16(ddlBrand.SelectedValue);
            atbl_ProductInfo.Quantity = Convert.ToInt32(txtQuantity.Text);
            atbl_ProductInfo.ReorderLebel = Convert.ToInt16(ddlReorder.Text);
            atbl_ProductInfo.Product_Image = txtImage.Text;
            atbl_ProductInfo.Product_Description = txtDescription.Text;


            int count = (from emp in _context.tbl_ProductInfo
                         where emp.Product_Name == atbl_ProductInfo.Product_Name
                         && emp.Category_Id == atbl_ProductInfo.Category_Id
                         select emp.Product_Name).Count();
           
                if (count > 0)
                {
                    msg_lbl.Visible = true;
                    msg_lbl.Text = "E-ID already exists!";
                    return;
                }
                objProductSetup_BLL.SaveProduct(atbl_ProductInfo);
                msg_lbl.Visible = true;
                msg_lbl.Text = "Data Save Successfully";

                txtDescription.Text = "";
                txtImage.Text = "";
                txtPurchase.Text = "";
                txtSell.Text = "";
                txtProductName.Text = "";
                ddlReorder.SelectedIndex = 0;
                ddlCategory.SelectedIndex = -1;
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindAllSubCategory();
        }
    }
}