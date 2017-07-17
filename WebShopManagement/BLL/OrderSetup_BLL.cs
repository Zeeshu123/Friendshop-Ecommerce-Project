using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class OrderSetup_BLL
    {
        OrderSetup_DAL objOrderSetup_DAL = new OrderSetup_DAL();
        internal object InsertOrder(tbl_Order atbl_Order)
        {
            return objOrderSetup_DAL.InsertOrder(atbl_Order);
        }

    }
}