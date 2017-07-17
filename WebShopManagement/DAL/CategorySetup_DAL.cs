using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class CategorySetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal List<tbl_ProductCategory> GetAllCategory()
        {
            try
            {
                var query = (from off in _context.tbl_ProductCategory
                             select off).OrderBy(x => x.Category_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductSubcategory> GetAllSubCategory(int CategoryId)
        {
            try
            {
                var query = (from off in _context.tbl_ProductSubcategory
                             where off.Category_Id == CategoryId
                             select off).OrderBy(x => x.Subcategory_Name).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductBrand> GetAllBrand()
        {
            try
            {
                var query = (from off in _context.tbl_ProductBrand
                             select off).OrderBy(x => x.Brand_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}