using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entities
{
    public class KullaniciDetay : BaseEntities
    {
        [Column(Order = 1)]
        [Key]
       
        public int Id { get; set; }

        [Column(Order = 2)]
        public string Adi { get; set; }

        [Column(Order = 3)]
        public string SoyAdi { get; set; }

        [Column(Order = 4)]
        public string Cinsiyet { get; set; }

        [ForeignKey("Id")]
        public virtual Kullanici Kullanici { get; set; }
    }
}