using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    // Entity sınıflarımızın tablo isimleri ile ve üyelerinini alan isimleri ile eşleşmesinde default olarak aynı isimleri bulursa ilişkilendirir...
    // varsayılan yapıpının dışıan çıkarak entity sınıflarımızı tablolarımaza uyarlayabiliriz. Bunun için 2 yöntem kullanılır

    // 1: DataAnnotation yöntemi : Attribute denilen c# ifadeleri ile konfigurasyon yapılır

    // 2: FleuntApi yöntemi  : DbContext sınıfı içerisinde OnModelCreating metodu içerisinde
    [Table("Kategori")]  // Entity sınıfımız Kategori tablosu ile eşleştirilsin...
    public class Kat1
    {
        [Key] // Bu alanın primary key olduğunu belirtiyoruz...
        [Column("KategoriId")]
        public int CatID { get; set; }

        [Column("KategoriAdi")]
        public string Name { get; set; }

        [Column("Aciklama")]
        public string? Desc { get; set; }

        [Column("Sira")]
        public byte? Ord { get; set; }
    }
}
