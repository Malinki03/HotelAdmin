﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAdmin.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelEntities : DbContext
    {
        public hotelEntities()
            : base("name=hotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<calendari> calendaris { get; set; }
        public virtual DbSet<costa> costas { get; set; }
        public virtual DbSet<costaDia> costaDias { get; set; }
        public virtual DbSet<habitacio> habitacios { get; set; }
        public virtual DbSet<habitacioDia> habitacioDias { get; set; }
        public virtual DbSet<reserva> reservas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tarifa> tarifas { get; set; }
        public virtual DbSet<tipusBalco> tipusBalcoes { get; set; }
        public virtual DbSet<tipusHab> tipusHabs { get; set; }
    }
}
