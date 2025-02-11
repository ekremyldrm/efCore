using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entities
{
    public class Siparis : BaseEntities
    {
        public int Id { get; set; }

        [Column(Order =2)]
        public string OrderNumber { get; set; }

        [Column(Order = 3)]
        public string SiparisTarihi { get; set; }

        [Column(Order = 4)]
        public DateTime TahminiGonderimTarihi { get; set; }

        [Column(Order = 5)]
        public int KullaniciId { get; set; }

        [Column(Order = 6)]
        public int TasiyanId { get; set; }

        [ForeignKey("TasiyanId")]
        public virtual Kargo Kargo { get; set; }
    }
}
