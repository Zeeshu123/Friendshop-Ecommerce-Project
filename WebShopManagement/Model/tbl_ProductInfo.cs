//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShopManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ProductInfo
    {
        public int Sl_Id { get; set; }
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Product_Image { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public Nullable<int> Subcategory_Id { get; set; }
        public Nullable<int> Brand_Id { get; set; }
        public Nullable<decimal> Purchase_Rate { get; set; }
        public Nullable<decimal> Sell_Rate { get; set; }
        public Nullable<int> ReorderLebel { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
        public string Edit_User { get; set; }
    }
}
