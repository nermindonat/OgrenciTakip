﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OgrenciTakipEntities : DbContext
    {
        public OgrenciTakipEntities()
            : base("name=OgrenciTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branslar> Branslar { get; set; }
        public virtual DbSet<DevamsizlikBilgi> DevamsizlikBilgi { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<KullaniciTurleri> KullaniciTurleri { get; set; }
        public virtual DbSet<Menuler> Menuler { get; set; }
        public virtual DbSet<Notlar> Notlar { get; set; }
        public virtual DbSet<OgrBilgi> OgrBilgi { get; set; }
        public virtual DbSet<Ogretmenler> Ogretmenler { get; set; }
        public virtual DbSet<OgretmenSinif> OgretmenSinif { get; set; }
        public virtual DbSet<OkulBilgi> OkulBilgi { get; set; }
        public virtual DbSet<Siniflar> Siniflar { get; set; }
    }
}
