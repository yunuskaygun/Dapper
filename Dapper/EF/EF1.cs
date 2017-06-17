namespace Dapper.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EF1 : DbContext
    {
        public EF1()
            : base("name=EF1")
        {
        }

        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<Ogretmen> Ogretmen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<Ogrenci>()
                .Property(e => e.ADRES)
                .IsUnicode(false);

            modelBuilder.Entity<Ogretmen>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);
        }
    }
}
