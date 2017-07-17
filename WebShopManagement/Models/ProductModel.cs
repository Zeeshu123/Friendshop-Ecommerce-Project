using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.Models
{
    public class ProductModel
    {
        public tbl_ProductInfo GetProduct(int product_id)
        {
            try
            {
                using(WebshopManagementEntities db = new WebshopManagementEntities())
                {
                    tbl_ProductInfo product = db.tbl_ProductInfo.Find(product_id);
                    return product;
                }
            }
            catch(Exception)
            {
                return null;
            }
        }

        private List<tbl_ProductInfo> GetAllProducts(int product_id)
        {
            try
            {
                using (WebshopManagementEntities db = new WebshopManagementEntities())
                {
                    List<tbl_ProductInfo> products = (from x in db.tbl_ProductInfo
                                                      select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}