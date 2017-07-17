using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopManagement.Models
{
    public class Products
    {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Sell_Rate { get; set; }
        public string Product_Image { get; set; }

        public Products(string id, string name, string price, string img)
        {
            this.Product_Id = id;
            this.Product_Name = name;
            this.Sell_Rate = price;
            this.Product_Image = img;
        }
    }
}