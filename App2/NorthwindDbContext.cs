using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{

    // DbContext =>veri tabanı ile bağlantı kurmamızı sağlayan, insert,update,delete,select sorgularını oluşturan, objelerimiz ile tablolar arasındaki ilişkilendirmeyi sağlayan sınıftır..
    public class NorthwindDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Northwind;uid=sa;pwd=321; TrustServerCertificate=true");
        }

        public DbSet<Kategori> Kategori  { get; set; }
    }
}
