﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockBDWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StockBDContext : DbContext
    {
        public StockBDContext()
            : base("name=StockBDContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AudFinance> AudFinances { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<DailyData> DailyDatas { get; set; }
        public virtual DbSet<EPS_Perf> EPS_Perf { get; set; }
        public virtual DbSet<Holding> Holdings { get; set; }
        public virtual DbSet<MF_Perf> MF_Perf { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Recent> Recents { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<ShareCat> ShareCats { get; set; }
        public virtual DbSet<ShareType> ShareTypes { get; set; }
    }
}
