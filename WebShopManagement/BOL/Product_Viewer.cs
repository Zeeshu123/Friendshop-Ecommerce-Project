using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopManagement.BOL
{
    public class Product_Viewer
    {        
            public string Product_Id { get; set; }
            public string Product_Name { get; set; }
            public int Category_Id { get; set; }
            public string Category_Name { get; set; }
            public int Quantity { get; set; }
            public int ReorderLebel { get; set; }
    }
}