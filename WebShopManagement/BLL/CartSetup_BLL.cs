using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class CartSetup_BLL
    {
        CartSetup_DAL objCartSetup_DAL = new CartSetup_DAL();
        internal object InsertCart(tbl_Cart atbl_Cart)
        {
            return objCartSetup_DAL.InsertCart(atbl_Cart);
        }


    }
}