using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class OrderSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();
        internal object InsertOrder(tbl_Order atbl_Order)
        {
            //foreach (tbl_EmplyoeeAttendance atten in lsttbl_EmplyoeeAttendance)
            //{
            _context.tbl_Order.Add(atbl_Order);
            _context.SaveChanges();
            //}

            return 1;
        }

    }
}