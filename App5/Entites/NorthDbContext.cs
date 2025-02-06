using App5.DbConiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.Entites
{
    public class NorthDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Northwind; uid=sa;pwd=321;TrustServerCertificate=true") // Microsoft.EntityFrameworkCore.SqlServer packagesini dahil etmek gerekir
                .UseLazyLoadingProxies(); // bu metodu çağırabilmek için Nuget Manage Package penceresinden Microsoft.EntityFrameworkCore.Proxies packagesini dahil etmemiz gerekiyor...
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api configurationini uyguluyoruz...
            modelBuilder.ApplyConfiguration(new TedarikciConf());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
    }
}
