using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class ComputerSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal List<tbl_ProductInfo> GetAllComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //*********************************************************--HP Computer--*******

        internal List<tbl_ProductInfo> GetAllHPComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHPComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 18 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //*********************************************************************--ASUS Computer--**********************
        internal List<tbl_ProductInfo> GetAllASUSComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllASUSComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 19 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
         

        //*******************************************************************--SONY COmputer--****************************

        internal List<tbl_ProductInfo> GetAllSONYComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSONYComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 21 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //************************************************************************--Accer Computer--*****************

        internal List<tbl_ProductInfo> GetAllACCERComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllACCERComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 20 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //*************************************************************************--SAmSUng Computer--**********************

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSAMSUNGComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 23 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //*********************************************************************--OTHERS COMPUTER--*****************

        internal List<tbl_ProductInfo> GetAllOthersComputerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthersComputer30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 2 && pro.Subcategory_Id == 24 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}