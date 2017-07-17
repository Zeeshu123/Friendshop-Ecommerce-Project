using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class ProductSetup_BLL
    {
        ProductSetup_DAL objProductSetup_DAL = new ProductSetup_DAL();
        internal int SaveProduct(tbl_ProductInfo atbl_ProductInfo)
        {
            return objProductSetup_DAL.SaveProduct(atbl_ProductInfo);
        }

        internal object InsertOrderProduct(tbl_Order atbl_Order)
        {
            return objProductSetup_DAL.InsertOrderProduct(atbl_Order);
        }

        internal object InsertCustomerInfo(tbl_Order atbl_Order)
        {
            return objProductSetup_DAL.InsertCustomerInfo(atbl_Order);
        }

        internal List<tbl_ProductInfo> GetSingleProductInfo(string id)
        {
            return objProductSetup_DAL.GetSingleProductInfo(id);
        }


        internal List<tbl_ProductInfo> GetAllProductInfo()
        {
            return objProductSetup_DAL.GetAllProductInfo();
        }

        internal List<tbl_ProductInfo> GetAllProductBtnFiveHundred()
        {
            return objProductSetup_DAL.GetAllProductBtnFiveHundred();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////--TV Products--////////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllTVCameraProducts()
        {
            return objProductSetup_DAL.GetAllTVCameraProducts();
        }

        internal List<tbl_ProductInfo> GetAllTV10000Products()
        {
            return objProductSetup_DAL.GetAllTV10000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV20000Products()
        {
            return objProductSetup_DAL.GetAllTV20000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV30000Products()
        {
            return objProductSetup_DAL.GetAllTV30000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV50000Products()
        {
            return objProductSetup_DAL.GetAllTV50000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV10000_20000Products()
        {
            return objProductSetup_DAL.GetAllTV10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV10000_30000Products()
        {
            return objProductSetup_DAL.GetAllTV10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV10000_50000Products()
        {
            return objProductSetup_DAL.GetAllTV10000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV10000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllTV10000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllTV20000_30000Products()
        {
            return objProductSetup_DAL.GetAllTV20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV20000_50000Products()
        {
            return objProductSetup_DAL.GetAllTV20000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV20000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllTV20000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllTV30000_50000Products()
        {
            return objProductSetup_DAL.GetAllTV30000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllTV30000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllTV30000_HighestProducts();
        }

        

        /// <summary>
        /// //////////////////////////////////////////////////////////////--MOBILE PRODUCTS--///////////////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllMobileProducts()
        {
            return objProductSetup_DAL.GetAllMobileProducts();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile3000Products()
        {
            return objProductSetup_DAL.GetAllMobile3000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile5000Products()
        {
            return objProductSetup_DAL.GetAllMobile5000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile10000Products()
        {
            return objProductSetup_DAL.GetAllMobile10000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile20000Products()
        {
            return objProductSetup_DAL.GetAllMobile20000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile30000Products()
        {
            return objProductSetup_DAL.GetAllMobile30000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_3000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_5000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000_5000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_10000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_20000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_30000Products()
        {
            return objProductSetup_DAL.GetAllMobile2000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_10000Products()
        {
            return objProductSetup_DAL.GetAllMobile5000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_20000Products()
        {
            return objProductSetup_DAL.GetAllMobile5000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_30000Products()
        {
            return objProductSetup_DAL.GetAllMobile5000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_20000Products()
        {
            return objProductSetup_DAL.GetAllMobile10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_30000Products()
        {
            return objProductSetup_DAL.GetAllMobile10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile20000_30000Products()
        {
            return objProductSetup_DAL.GetAllMobile20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllMobile2000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllMobile2000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllMobile5000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllMobile5000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllMobile10000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllMobile10000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllMobile20000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllMobile20000_Highest_Price();
        }

        //***********************************************************************--OPPO Mobile--**************

        internal List<tbl_ProductInfo> GetAllOppoMobileProducts()
        {
            return objProductSetup_DAL.GetAllOppoMobileProducts();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile5000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile10000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile20000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile30000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile30000Products();
        }       

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_10000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile5000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_20000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile5000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_30000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile5000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_20000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_30000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000_30000Products()
        {
            return objProductSetup_DAL.GetAllOppoMobile20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile5000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllOppoMobile5000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile10000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllOppoMobile10000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllOppoMobile20000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllOppoMobile20000_Highest_Price();
        }


        //*********************************************************************--Symphony Mobile-- ***************************

        internal List<tbl_ProductInfo> GetAllSymphonyMobileProducts()
        {
            return objProductSetup_DAL.GetAllSymphonyMobileProducts();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile3000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile5000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile30000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_3000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_5000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_5000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_10000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_20000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_30000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_10000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile5000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_20000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile5000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_30000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile5000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_20000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_30000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000_30000Products()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile2000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile2000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile5000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile5000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile10000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile10000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSymphonyMobile20000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSymphonyMobile20000_Highest_Price();
        }



        //*********************************************************************--SAMSUNG MOBILE--**********

        internal List<tbl_ProductInfo> GetAllSamsungMobileProducts()
        {
            return objProductSetup_DAL.GetAllSamsungMobileProducts();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile3000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile5000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile30000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_3000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_5000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_5000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_10000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_20000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_30000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_10000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile5000_10000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_20000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile5000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_30000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile5000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_20000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_30000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000_30000Products()
        {
            return objProductSetup_DAL.GetAllSamsungMobile20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile2000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSamsungMobile2000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile5000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSamsungMobile5000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile10000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSamsungMobile10000_Highest_Price();
        }

        internal List<tbl_ProductInfo> GetAllSamsungMobile20000_Highest_Price()
        {
            return objProductSetup_DAL.GetAllSamsungMobile20000_Highest_Price();
        }


        ////////////////////////////////////////////////////////////////////--APLIANCES PRODUCTS--//////////

        //Code For Appliances Products

        internal List<tbl_ProductInfo> GetAllAppliancesProducts()
        {
            return objProductSetup_DAL.GetAllAppliancesProducts();
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000Products()
        {
            return objProductSetup_DAL.GetAllAppliances10000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000Products()
        {
            return objProductSetup_DAL.GetAllAppliances20000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000Products()
        {
            return objProductSetup_DAL.GetAllAppliances30000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances50000Products()
        {
            return objProductSetup_DAL.GetAllAppliances50000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_20000Products()
        {
            return objProductSetup_DAL.GetAllAppliances10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_30000Products()
        {
            return objProductSetup_DAL.GetAllAppliances10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_50000Products()
        {
            return objProductSetup_DAL.GetAllAppliances10000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances10000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllAppliances10000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_30000Products()
        {
            return objProductSetup_DAL.GetAllAppliances20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_50000Products()
        {
            return objProductSetup_DAL.GetAllAppliances20000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances20000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllAppliances20000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000_50000Products()
        {
            return objProductSetup_DAL.GetAllAppliances30000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllAppliances30000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllAppliances30000_HighestProducts();
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////--FLOWER PRODUCTS--/////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllFlowerProducts()
        {
            return objProductSetup_DAL.GetAllFlowerProducts();
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////--GIFT PRODUCTS--///////////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllGiftProducts()
        {
            return objProductSetup_DAL.GetAllGiftProducts();
        }

        internal List<tbl_ProductInfo> GetAllGift500Products()
        {
            return objProductSetup_DAL.GetAllGift500Products();
        }

        internal List<tbl_ProductInfo> GetAllGift1000Products()
        {
            return objProductSetup_DAL.GetAllGift1000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift2000Products()
        {
            return objProductSetup_DAL.GetAllGift2000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift3000Products()
        {
            return objProductSetup_DAL.GetAllGift3000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift500_1000Products()
        {
            return objProductSetup_DAL.GetAllGift500_1000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift500_2000Products()
        {
            return objProductSetup_DAL.GetAllGift500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift500_3000Products()
        {
            return objProductSetup_DAL.GetAllGift500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllGift500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllGift1000_2000Products()
        {
            return objProductSetup_DAL.GetAllGift1000_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift1000_3000Products()
        {
            return objProductSetup_DAL.GetAllGift1000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift1500_2000Products()
        {
            return objProductSetup_DAL.GetAllGift1500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift1500_3000Products()
        {
            return objProductSetup_DAL.GetAllGift1500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllGift1500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllGift1500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllGift1000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllGift1000_HighestProducts();
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////--HOMELIVING PRODUCTS--/////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllHomeLivingProducts()
        {
            return objProductSetup_DAL.GetAllHomeLivingProducts();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving10000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving20000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving30000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving50000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving50000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_20000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving10000_20000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_30000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving10000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_50000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving10000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving10000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllHomeLiving10000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_30000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving20000_30000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_50000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving20000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving20000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllHomeLiving20000_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000_50000Products()
        {
            return objProductSetup_DAL.GetAllHomeLiving30000_50000Products();
        }

        internal List<tbl_ProductInfo> GetAllHomeLiving30000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllHomeLiving30000_HighestProducts();
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////--SPROTS PRODUCTS--/////////////////
        /// </summary>
        /// <returns></returns>

        internal List<tbl_ProductInfo> GetAllSportProducts()
        {
            return objProductSetup_DAL.GetAllSportProducts();
        }

        internal List<tbl_ProductInfo> GetAllSport500Products()
        {
            return objProductSetup_DAL.GetAllSport500Products();
        }

        internal List<tbl_ProductInfo> GetAllSport1000Products()
        {
            return objProductSetup_DAL.GetAllSport1000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport2000Products()
        {
            return objProductSetup_DAL.GetAllSport2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport3000Products()
        {
            return objProductSetup_DAL.GetAllSport3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport500_1000Products()
        {
            return objProductSetup_DAL.GetAllSport500_1000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport500_2000Products()
        {
            return objProductSetup_DAL.GetAllSport500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport500_3000Products()
        {
            return objProductSetup_DAL.GetAllSport500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllSport500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllSport1000_2000Products()
        {
            return objProductSetup_DAL.GetAllSport1000_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport1000_3000Products()
        {
            return objProductSetup_DAL.GetAllSport1000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport1500_2000Products()
        {
            return objProductSetup_DAL.GetAllSport1500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport1500_3000Products()
        {
            return objProductSetup_DAL.GetAllSport1500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllSport1500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllSport1500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllSport1000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllSport1000_HighestProducts();
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////--KIDS PRODUCTS--///////////////////
        /// </summary>
        /// <returns></returns>
        internal List<tbl_ProductInfo> GetAllKidsProducts()
        {
            return objProductSetup_DAL.GetAllKidsProducts();
        }

        internal List<tbl_ProductInfo> GetAllKids500Products()
        {
            return objProductSetup_DAL.GetAllKids500Products();
        }

        internal List<tbl_ProductInfo> GetAllKids1000Products()
        {
            return objProductSetup_DAL.GetAllKids1000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids2000Products()
        {
            return objProductSetup_DAL.GetAllKids2000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids3000Products()
        {
            return objProductSetup_DAL.GetAllKids3000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids500_1000Products()
        {
            return objProductSetup_DAL.GetAllKids500_1000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids500_2000Products()
        {
            return objProductSetup_DAL.GetAllKids500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids500_3000Products()
        {
            return objProductSetup_DAL.GetAllKids500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllKids500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllKids1000_2000Products()
        {
            return objProductSetup_DAL.GetAllKids1000_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids1000_3000Products()
        {
            return objProductSetup_DAL.GetAllKids1000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids1500_2000Products()
        {
            return objProductSetup_DAL.GetAllKids1500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids1500_3000Products()
        {
            return objProductSetup_DAL.GetAllKids1500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllKids1500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllKids1500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllKids1000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllKids1000_HighestProducts();
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////--BEAUTY PRODUCTS--/////////////////
        /// </summary>
        /// <returns></returns>
        internal List<tbl_ProductInfo> GetAllBeautyProducts()
        {
            return objProductSetup_DAL.GetAllBeautyProducts();
        }

        internal List<tbl_ProductInfo> GetAllBeauty500Products()
        {
            return objProductSetup_DAL.GetAllBeauty1000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000Products()
        {
            return objProductSetup_DAL.GetAllBeauty1000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty2000Products()
        {
            return objProductSetup_DAL.GetAllBeauty2000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty3000Products()
        {
            return objProductSetup_DAL.GetAllBeauty3000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_1000Products()
        {
            return objProductSetup_DAL.GetAllBeauty500_1000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_2000Products()
        {
            return objProductSetup_DAL.GetAllBeauty500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_3000Products()
        {
            return objProductSetup_DAL.GetAllBeauty500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllBeauty500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_2000Products()
        {
            return objProductSetup_DAL.GetAllBeauty1000_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_3000Products()
        {
            return objProductSetup_DAL.GetAllBeauty1000_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_2000Products()
        {
            return objProductSetup_DAL.GetAllBeauty1500_2000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_3000Products()
        {
            return objProductSetup_DAL.GetAllBeauty1500_3000Products();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1500_HighestProducts()
        {
            return objProductSetup_DAL.GetAllBeauty1500_HighestProducts();
        }

        internal List<tbl_ProductInfo> GetAllBeauty1000_HighestProducts()
        {
            return objProductSetup_DAL.GetAllBeauty1000_HighestProducts();
        }

    }
}