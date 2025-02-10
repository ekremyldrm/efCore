using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7.Entities
{
    public class Urun
    {
        public int UrunId { get; set; }
        public short? Stok { get; set; }
        public decimal? Fiyat { get; set; }
        public decimal? IndirimliFiyat { get; set; }

        public int? KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        // Default Olarak NavtigationPropertyName'in ile foreing Key ismin eşlirse foregin key attribute kullanmana gerek yok...

    }
}
