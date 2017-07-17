using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopManagement.Model;

namespace WebShopManagement.DAL
{
    public class CustomerSetup_DAL
    {
        private WebshopManagementEntities _context = new WebshopManagementEntities();

        internal int SaveUnsignCustomer(tbl_UnsignCustomer atbl_UnsignCustomer)
        {
            _context.tbl_UnsignCustomer.Add(atbl_UnsignCustomer);
            _context.SaveChanges();
            return 1;
        }

        internal int SaveSignCustomer(tbl_CustomerInfo atbl_CustomerInfo)
        {
            _context.tbl_CustomerInfo.Add(atbl_CustomerInfo);
            _context.SaveChanges();
            return 1;
        }

        internal List<tbl_CustomerInfo> GetSingleCustomerInfo(string username, string password)
        {
            try
            {
                var query = (from cus in _context.tbl_CustomerInfo
                             where cus.Name == username && cus.Password == password
                             select cus).ToList();

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}