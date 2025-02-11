using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entities
{
    public class Kullanici : BaseEntities
    {
        [Column(Order = 1)]
        [Key]
        public int Id { get; set; }

        [Column(Order = 2)]
        public string KullaniciAdi { get; set; }

        [Column(Order = 3)]
        public string Sifre { get; set; }

        public virtual KullaniciDetay KullaniciDetay { get; set; }
    }
}
