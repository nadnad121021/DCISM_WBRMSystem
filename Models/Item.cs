//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DCISM_WBRMSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int Id_Item { get; set; }
        public Nullable<int> Id_Category { get; set; }
        public string Category { get; set; }
        public Nullable<int> Id_SubCategory { get; set; }
        public string SubCategory { get; set; }
        public Nullable<int> Id_Barcode { get; set; }
        public string Str_Code { get; set; }
        public string Str_Code_Display { get; set; }
        public string Item_Name { get; set; }
        public string Brand_Model { get; set; }
        public string Year_Acquired { get; set; }
        public string Custodian { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Serial_Number { get; set; }
        public Nullable<int> On_Hold_Period { get; set; }
        public string Remarks { get; set; }
        public string Room_No { get; set; }
        public Nullable<int> Id_Condition { get; set; }
        public string Condition { get; set; }
        public Nullable<int> Id_Status { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date_Added { get; set; }
        public Nullable<System.DateTime> Date_Acquisition { get; set; }
        public Nullable<bool> Is_Assign { get; set; }
        public Nullable<bool> Is_Verify { get; set; }
        public Nullable<bool> Is_Generated_Barcode { get; set; }
    }
}
