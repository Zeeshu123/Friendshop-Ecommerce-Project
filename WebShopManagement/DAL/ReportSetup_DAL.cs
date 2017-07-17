using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.BOL;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class ReportSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal List<tbl_ProductInfo> GetAllProduct()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Quantity <= pro.ReorderLebel
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public IEnumerable<Product_Viewer> GetAllLowProductDetails()
        {

            return (from pro in _context.tbl_ProductInfo
                    join c in _context.tbl_ProductCategory on pro.Category_Id equals c.Category_Id

                    where pro.Quantity <= pro.ReorderLebel

                    select new Product_Viewer
                    {
                        Product_Id = pro.Product_Id,
                        Product_Name = pro.Product_Name,
                        Category_Id = (int)pro.Category_Id,
                        Quantity = (int)pro.Quantity,
                        ReorderLebel = (int)pro.ReorderLebel,
                        Category_Name=c.Category_Name
                    }).ToList();
            //}
        }

        public IEnumerable<Product_Viewer> GetAllStockProductDetails()
        {

            return (from pro in _context.tbl_ProductInfo
                    join c in _context.tbl_ProductCategory on pro.Category_Id equals c.Category_Id

                    where pro.Quantity > 0

                    select new Product_Viewer
                    {
                        Product_Id = pro.Product_Id,
                        Product_Name = pro.Product_Name,
                        Category_Id = (int)pro.Category_Id,
                        Quantity = (int)pro.Quantity,
                        ReorderLebel = (int)pro.ReorderLebel,
                        Category_Name=c.Category_Name

                    }).ToList();
            //}
        }

        public IEnumerable<Product_Viewer> GetAllNoStockProductDetails()
        {

            return (from pro in _context.tbl_ProductInfo
                    join c in _context.tbl_ProductCategory on pro.Category_Id equals c.Category_Id

                    where pro.Quantity < 1

                    select new Product_Viewer
                    {
                        Product_Id = pro.Product_Id,
                        Product_Name = pro.Product_Name,
                        Category_Id = (int)pro.Category_Id,
                        Quantity = (int)pro.Quantity,
                        ReorderLebel = (int)pro.ReorderLebel,
                        Category_Name=c.Category_Name


                    }).ToList();
            //}
        }


    }
}