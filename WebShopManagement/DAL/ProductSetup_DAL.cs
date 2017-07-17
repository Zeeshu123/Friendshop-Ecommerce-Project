using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class ProductSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        internal int SaveProduct(tbl_ProductInfo atbl_ProductInfo)
        {
            _context.tbl_ProductInfo.Add(atbl_ProductInfo);
            _context.SaveChanges();
            return 1;
        }

        internal object InsertOrderProduct(tbl_Order atbl_Order)
        {
            //foreach (tbl_EmplyoeeAttendance atten in lsttbl_EmplyoeeAttendance)
            //{
            _context.tbl_Order.Add(atbl_Order);
            _context.SaveChanges();
            //}

            return 1;
        }

        internal object InsertCustomerInfo(tbl_Order atbl_Order)
        {           
            _context.tbl_Order.Add(atbl_Order);
            _context.SaveChanges();
            return 1;
        }



        internal List<tbl_ProductInfo> GetSingleProductInfo(string id)
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Product_Id==id
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //ALL Products code Here...

        internal List<tbl_ProductInfo> GetAllProductInfo()
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

        internal List<tbl_ProductInfo> GetAllProductBtnFiveHundred()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////-- TV,Camera PRODUCTS --//

        //Only TV , Camera & Audio Products Code Here...

        internal List<tbl_ProductInfo> GetAllTVCameraProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllTV30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 6 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////-- MOBILE PRODUCTS --//

        //Only Mobile Products Code Here...

        internal List<tbl_ProductInfo> GetAllMobileProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllMobile20000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //***************************************************************----OPPO MOBILE----******************
        internal List<tbl_ProductInfo> GetAllOppoMobileProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        internal List<tbl_ProductInfo> GetAllOppoMobile5000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        internal List<tbl_ProductInfo> GetAllOppoMobile5000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Subcategory_Id == 12 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //*********************************************************************--Symphony Mobile-- ***************************

        internal List<tbl_ProductInfo> GetAllSymphonyMobileProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 15 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 &&pro.Sell_Rate == 15 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //*********************************************************************--Samsung Mobile-- ***************************

        internal List<tbl_ProductInfo> GetAllSamsungMobileProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_5000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 5000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 5000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000_Highest_Price()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 3 && pro.Sell_Rate == 13 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Only Aplliances Products Code Here...

        internal List<tbl_ProductInfo> GetAllAppliancesProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 4 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //Only Flower Products Code Here...

        internal List<tbl_ProductInfo> GetAllFlowerProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 5
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //Only Gift Products Code Here...

        internal List<tbl_ProductInfo> GetAllGiftProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllGift1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1011 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //Only HomeLiving Products Code Here...

        internal List<tbl_ProductInfo> GetAllHomeLivingProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate <= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_20000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 10000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 10000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_30000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 20000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 20000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000_50000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 30000 && pro.Sell_Rate <= 50000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1009 && pro.Sell_Rate >= 30000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //Only Sport&Fitness Products Code Here...

        internal List<tbl_ProductInfo> GetAllSportProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllSport1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1010 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //Only Kids Products Code Here...

        internal List<tbl_ProductInfo> GetAllKidsProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllKids1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 7 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //Beauty & Health Products Code here...

        internal List<tbl_ProductInfo> GetAllBeautyProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty500Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate <= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_1000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1000 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_2000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 2000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_3000Products()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1500 && pro.Sell_Rate <= 3000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1500
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_HighestProducts()
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Category_Id == 1012 && pro.Sell_Rate >= 1000
                             select pro).OrderBy(x => x.Product_Id).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //Oters Code Here...

        internal List<tbl_ProductInfo> GetProductDetails(string Product_Id)
        {
            try
            {
                var query = (from pro in _context.tbl_ProductInfo
                             where pro.Product_Id == Product_Id
                             select pro).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}