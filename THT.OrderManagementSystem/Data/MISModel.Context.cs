﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PTC_MIS_DBEntities : DbContext
    {
        public PTC_MIS_DBEntities()
            : base("name=PTC_MIS_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionTypes> ActionTypes { get; set; }
        public virtual DbSet<BrandBank> BrandBank { get; set; }
        public virtual DbSet<InvDetails> InvDetails { get; set; }
        public virtual DbSet<InvHeader> InvHeader { get; set; }
        public virtual DbSet<LocationLogs> LocationLogs { get; set; }
        public virtual DbSet<ProductPictures> ProductPictures { get; set; }
        public virtual DbSet<ProductPicturesDevice> ProductPicturesDevice { get; set; }
        public virtual DbSet<ShopScan> ShopScan { get; set; }
        public virtual DbSet<WebServiceLog> WebServiceLog { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VisitLog> VisitLog { get; set; }
        public virtual DbSet<DeviceMap> DeviceMap { get; set; }
    }
}
