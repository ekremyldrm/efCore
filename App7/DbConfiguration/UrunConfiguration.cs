using App7.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7.DbConfiguration
{
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {

            builder.Property(c => c.Fiyat).HasPrecision(5, 2); // decimal tipin basamak sayısını belirliyoruz...

            builder.Property(c => c.IndirimliFiyat).HasColumnType("money"); //tipi decmal değil money olsun..

            builder.Property(c => c.Fiyat).IsRequired(false); // nullable
            builder.Property(c => c.IndirimliFiyat).IsRequired(false); // nullable


        }
    }
}
