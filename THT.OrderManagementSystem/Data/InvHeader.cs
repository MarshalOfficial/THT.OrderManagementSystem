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
    
    public partial class InvHeader
    {
        public int ID { get; set; }
        public string PInv_Code { get; set; }
        public Nullable<int> PInvID { get; set; }
        public string THesabcode { get; set; }
        public string THesabName { get; set; }
        public Nullable<short> invmode { get; set; }
        public string InvMemo { get; set; }
        public Nullable<short> VisitorCode { get; set; }
        public string InputPInvDate { get; set; }
        public string InputUserName { get; set; }
        public Nullable<System.DateTime> VisitOrderSaveDate { get; set; }
        public Nullable<bool> IsSended { get; set; }
        public Nullable<short> DueKind { get; set; }
    }
}
