﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restorant.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestorantDBEntities : DbContext
    {
        public RestorantDBEntities()
            : base("name=RestorantDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artikl> Artikls { get; set; }
        public virtual DbSet<Klienti> Klientis { get; set; }
        public virtual DbSet<TipNaNaplata> TipNaNaplatas { get; set; }
        public virtual DbSet<Transakcija> Transakcijas { get; set; }
        public virtual DbSet<DetaliNaracka> DetaliNarackas { get; set; }
        public virtual DbSet<Naracka> Narackas { get; set; }
    }
}
