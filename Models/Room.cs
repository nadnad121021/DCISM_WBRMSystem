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
    
    public partial class Room
    {
        public int Id_Room { get; set; }
        public string Room_No { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Room_Type { get; set; }
        public int Id_Condition { get; set; }
        public Nullable<bool> Is_Available { get; set; }
    }
}
