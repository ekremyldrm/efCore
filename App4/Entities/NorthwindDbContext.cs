using App4.DBConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Entities
{
    public class NorthwindDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Northwind;uid=sa;pwd=321;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region " fluent api 1"



            //modelBuilder.Entity<Kategori>().ToTable("Categories"); // Kat2 entitymiz Kategori tablosu ile ilişkilendirilir...
            //modelBuilder.Entity<Kategori>().HasKey(c => c.Id); // PK'miz CatId alanıdır...
            //modelBuilder.Entity<Kategori>().Property(c => c.Id).HasColumnName("CategoryId");
            //modelBuilder.Entity<Kategori>().Property(c => c.Adi).HasColumnName("CategoryName");


            //modelBuilder.Entity<Nakliyeci>().ToTable("Shippers"); // Kat2 entitymiz Kategori tablosu ile ilişkilendirilir...
            //modelBuilder.Entity<Nakliyeci>().HasKey(c => c.ID); // PK'miz CatId alanıdır...
            //modelBuilder.Entity<Nakliyeci>().Property(c => c.Adi).HasColumnName("CompanyName");
            //modelBuilder.Entity<Nakliyeci>().Property(c => c.TelNo).HasColumnName("Description");
            #endregion

            // fleuntApiii 2
            modelBuilder.ApplyConfiguration(new NakliyeciConf());
            modelBuilder.ApplyConfiguration(new KategoriConf());
        }

        public DbSet<Nakliyeci> Nakliyecis { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
    }
}
