using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6.Entites
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Northwind;uid=sa;pwd=321;TrustServerCertificate=true")
                .UseLazyLoadingProxies(); // lazy loding enable edilir...
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DAtaAnnotation yöntemi kullandığımız için fuent api yöntemini yorum satırı yaptık...

            // relation sağlanıyor...
            //modelBuilder.Entity<Shipper>()
            //    .HasMany(c => c.OrderList)
            //    .WithOne(c => c.Shipper)
            //    .HasForeignKey(c=> c.ShipVia);

            //IEntityTypeConfiguration interfacesinden türeyen sınıf ile yukarıda configrasyonu sağlayabilirdik....Bakınız App5 TedarikciConf sınıfı...
          //  modelBuilder.ApplyConfiguration
        }

     

        public  DbSet<Shipper> Shippers { get; set; }
       public DbSet<Order> Orders { get; set; }
    }
}
