using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Kategori
    {
        //EF Core default olarak SinifIsmiID veya ID (tabloda bu isim ile eşleşirse) isimli propertyleri primarykey olarak algılar.
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string? Aciklama { get; set; } // nullable... 
        //public byte? Sira { get; set; }
        public Nullable<byte> Sira { get; set; }
    }
}