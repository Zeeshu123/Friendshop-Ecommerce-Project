using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class MenSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal List<tbl_ProductInfo> GetAllMenProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMen1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //***********************************************************--T-SHIRT Products--******************

        internal List<tbl_ProductInfo> GetAllTshirtProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTshirt1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 1 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        //***********************************************************--SHIRT Products--******************

        internal List<tbl_ProductInfo> GetAllshirtProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllshirt1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 3 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        // ********************************************--JEANS PRODUCT-- ****************      

        internal List<tbl_ProductInfo> GetAllJeansProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        internal List<tbl_ProductInfo> GetAllJeans500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllJeans1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 4 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //**********************************************************-- panjabi -- ****************
        internal List<tbl_ProductInfo> GetAllPanjabiProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPanjabi1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 9 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        //***********************************************************--Foemal dress--**************
        internal List<tbl_ProductInfo> GetAllFormaldressProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllFormaldress1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 6 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //*********************************************************--Men POLO-SHIRT--************
        internal List<tbl_ProductInfo> GetAllPoloshirtProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 2
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //********************************************************--MEN SHOES--*******************

        internal List<tbl_ProductInfo> GetAllMenSHOEProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMenSHOE1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 5 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //**************************************************--EASY PRODUCTS--**********

        internal List<tbl_ProductInfo> GetAllEASYProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllEASY1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 1 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        //**************************************************--REX PRODUCTS--**********

        internal List<tbl_ProductInfo> GetAllREXProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllREX1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 2 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //**************************************************--Plus Point PRODUCTS--**********

        internal List<tbl_ProductInfo> GetAllPlusPointProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllPlusPoint1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Brand_Id == 3 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //***********************************************************--SHIRT Products--******************

        internal List<tbl_ProductInfo> GetAllOthersProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOthers1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1 && pro.Subcategory_Id == 10 && pro.Sell_Rate >= 1000
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