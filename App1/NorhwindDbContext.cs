using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class NorhwindDbContext : DbContext
    {
        //db ile bağlantının yapılması

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Microsoft.EntityFrameworkCore.SqlServer kütüphanesi indiriyoruz...
            optionsBuilder.UseSqlServer("Server=.;Database=Northwind;uid=sa;pwd=321;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }

        // sınıfın veritabanı objesi olduğunu belirtiyoruz.
        public DbSet<Categories> Categories { get; set; }

    }
}
