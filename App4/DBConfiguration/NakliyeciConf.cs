using App4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.DBConfiguration
{
    public class NakliyeciConf : IEntityTypeConfiguration<Nakliyeci>
    {
        public void Configure(EntityTypeBuilder<Nakliyeci> builder)
        {
            builder.ToTable("Shippers"); // Shippers tablosu..
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).HasColumnName("ShipperId");
            builder.Property(c => c.Adi).HasColumnName("CompanyName");
            builder.Property(c => c.TelNo).HasColumnName("Phone");
        }
    }
}