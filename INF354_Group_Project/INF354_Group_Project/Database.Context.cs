﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF354_Group_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class INF354Entities2 : DbContext
    {
        public INF354Entities2()
            : base("name=INF354Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblClient> tblClients { get; set; }
        public virtual DbSet<tblFurniture> tblFurnitures { get; set; }
        public virtual DbSet<tblFurnitureType> tblFurnitureTypes { get; set; }
        public virtual DbSet<tblTitle> tblTitles { get; set; }
        public virtual DbSet<tblClientFurniture> tblClientFurnitures { get; set; }
    }
}
