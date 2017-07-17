using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.DAL;
using WebShopManagement.Model;

namespace WebShopManagement.BLL
{
    public class CustomerSetup_BLL
    {
        CustomerSetup_DAL objCustomerSetup_DAL = new CustomerSetup_DAL();

        internal int SaveUnsignCustomer(tbl_UnsignCustomer atbl_UnsignCustomer)
        {
            return objCustomerSetup_DAL.SaveUnsignCustomer(atbl_UnsignCustomer);
        }

        internal int SaveSignCustomer(tbl_CustomerInfo atbl_CustomerInfo)
        {
            return objCustomerSetup_DAL.SaveSignCustomer(atbl_CustomerInfo);
        }

        internal List<tbl_CustomerInfo> GetSingleCustomerInfo(string username, string password)
        {
            return objCustomerSetup_DAL.GetSingleCustomerInfo(username, password);
        }

    }
}