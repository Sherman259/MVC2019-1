﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebShopEntities : DbContext
    {
        public WebShopEntities()
            : base("name=WebShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kategorije> Kategorijes { get; set; }
        public virtual DbSet<KategorijeProizvodi> KategorijeProizvodis { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<MjereProizvoda> MjereProizvodas { get; set; }
        public virtual DbSet<Narudzbe> Narudzbes { get; set; }
        public virtual DbSet<NarudzbeDetalji> NarudzbeDetaljis { get; set; }
        public virtual DbSet<Proizvodi> Proizvodis { get; set; }
    }
}
