﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aerolinea.Models.Domain.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AerolineaEntities : DbContext
    {
        public AerolineaEntities()
            : base("name=AerolineaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aeropuerto> Aeropuerto { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Destino> Destino { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Itinerario> Itinerario { get; set; }
        public virtual DbSet<Origen> Origen { get; set; }
        public virtual DbSet<Pasaje> Pasaje { get; set; }
        public virtual DbSet<Vuelo> Vuelo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}