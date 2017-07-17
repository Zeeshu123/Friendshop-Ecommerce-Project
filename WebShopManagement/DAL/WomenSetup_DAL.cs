using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class WomenSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        internal List<tbl_ProductInfo> GetAllWomenProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomen1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //////////////////////////////////////////////////////////////////////////--Jwellery Products--************

        internal List<tbl_ProductInfo> GetAllWomenJwelleryProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenJwellery1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 25 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //////////////////////////////////////////////////////////////////////////--Shoe Products--************

        internal List<tbl_ProductInfo> GetAllWomenShoeProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenShoe1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //////////////////////////////////////////////////////////////////////////--BATA Shoe Products--************

        internal List<tbl_ProductInfo> GetAllWomenBataShoeProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenBataShoe1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 4 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //////////////////////////////////////////////////////////////////////////--Apex Shoe Products--************

        internal List<tbl_ProductInfo> GetAllWomenApexShoeProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllWomenApexShoe1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 8 && pro.Subcategory_Id == 27 && pro.Brand_Id == 5 && pro.Sell_Rate >= 1000
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