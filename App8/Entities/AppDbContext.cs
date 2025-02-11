using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entities
{
    public class AppDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BizimDB;uid=sa;pwd=321;TrustServerCertificate=true");
        }

        public DbSet<Kargo> Kargos { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<KullaniciDetay> KullaniciDetays { get; set; }
    }
}
