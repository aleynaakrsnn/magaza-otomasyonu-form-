//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4tablo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class M07Entities : DbContext
    {
        public M07Entities()
            : base("name=M07Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Markalar> Markalar { get; set; }
        public virtual DbSet<Siparis1> Siparis1 { get; set; }
        public virtual DbSet<Urun1> Urun1 { get; set; }
    }
}
