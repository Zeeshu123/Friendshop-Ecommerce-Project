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
    
    public partial class tbl_Sale
    {
        public int Sale_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public Nullable<int> Sale_Quantity { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
        public string Edit_User { get; set; }
    }
}
