//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THT.OrderManagementSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShopScan
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Memo { get; set; }
        public string WorkingBrands { get; set; }
        public Nullable<int> VisitorCode { get; set; }
        public string SaveTime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Nullable<int> AgentVisitorCode { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}