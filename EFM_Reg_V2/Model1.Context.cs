﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFM_Reg_V2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestion_videothequeEntities : DbContext
    {
        public gestion_videothequeEntities()
            : base("name=gestion_videothequeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adherents> adherents { get; set; }
        public virtual DbSet<Emprunts> Emprunts { get; set; }
        public virtual DbSet<Films> Films { get; set; }
    }
}
