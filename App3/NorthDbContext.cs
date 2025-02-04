using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class NorthDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Northwind; uid=sa;pwd=321; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kat2>().ToTable("Kategori"); // Kat2 entitymiz Kategori tablosu ile ilişkilendirilir...
            modelBuilder.Entity<Kat2>().HasKey(c => c.CatID); // PK'miz CatId alanıdır...
            modelBuilder.Entity<Kat2>().Property(c => c.CatID).HasColumnName("KategoriId");
            modelBuilder.Entity<Kat2>().Property(c=> c.Name).HasColumnName("KategoriAdi");
            modelBuilder.Entity<Kat2>().Property(c => c.Desc).HasColumnName("Aciklama");
            modelBuilder.Entity<Kat2>().Property(c => c.Ord).HasColumnName("Sira");
        }

      //  public DbSet<Kat1> Kats1 { get; set; }
        public DbSet<Kat2> Kats2 { get; set; }


        //tablo isimleri ile DBSet tipindeki üyemizin ismini eşleştiriyor...

    }
}
