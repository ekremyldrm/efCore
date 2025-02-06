using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.Entites
{
    public class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string TedarikciName { get; set; }
        public string Yetkili  { get; set; }  
        public string Unvan { get; set; }
        public string Ulke { get; set; }
        public string City { get; set; }

        public virtual List<Product> Urunler { get; set; }
    }
}