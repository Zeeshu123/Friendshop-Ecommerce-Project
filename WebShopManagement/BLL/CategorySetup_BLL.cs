using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class CategorySetup_BLL
    {
        CategorySetup_DAL objCategorySetup_DAL = new CategorySetup_DAL();

        internal List<tbl_ProductCategory> GetAllCategory()
        {
            return objCategorySetup_DAL.GetAllCategory();
        }

        internal List<tbl_ProductBrand> GetAllBrand()
        {
            return objCategorySetup_DAL.GetAllBrand();
        }

        internal List<tbl_ProductSubcategory> GetAllSubCategory(int CategoryId)
        {
            return objCategorySetup_DAL.GetAllSubCategory(CategoryId);
        }
    }
}