using App5.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.DbConiguration
{
    public class TedarikciConf : IEntityTypeConfiguration<Tedarikci>
    {
        public void Configure(EntityTypeBuilder<Tedarikci> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(c => c.TedarikciId);
            builder.Property(c => c.TedarikciId).HasColumnName("SupplierId");
            builder.Property(c => c.TedarikciName).HasColumnName("CompanyName");
            builder.Property(c => c.Yetkili).HasColumnName("ContactName");
            builder.Property(c => c.Unvan).HasColumnName("ContactTitle");
            builder.Property(c => c.Ulke).HasColumnName("Country");

            // birçok relation
            builder.HasMany(c => c.Urunler)
                    .WithOne(c => c.Tedarikci)
                    .HasForeignKey(c => c.SupplierId);
        }
    }
}

//Northind veritabanında customer,order,Shipper,Employee modellemesini codefirs ile yapıp, ilişkilerini fulentapi yöntemi ile sağlayınız... entity sınıflarınızda tablonun alanlarının hepsini almanıza gerek yok. birkaç alan almanuız yeterli örneğinn;
// configurasyon sınıfları kullanılın 
// Employee tablosu için Calisan Classi
// customer tablosu için musteri clasi
// order için siparis classi
// Shipper için Gemi clasi oluşturun...
// Employee(EmployeeId,FirstName,Title) alanları yeterli...