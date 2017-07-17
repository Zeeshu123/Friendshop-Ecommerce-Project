using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class CartSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal object InsertCart(tbl_Cart atbl_Cart)
        {
            //foreach (tbl_EmplyoeeAttendance atten in lsttbl_EmplyoeeAttendance)
            //{
            _context.tbl_Cart.Add(atbl_Cart);
            _context.SaveChanges();
            //}

            return 1;
        }


    }
}