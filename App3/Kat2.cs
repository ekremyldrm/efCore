using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    // Configurasyon fleuntApi yöntemi ile dbContext sınıf içerisinde yapılır
    public class Kat2
    {
        public int CatID { get; set; }
        public string Name { get; set; }
        public string? Desc { get; set; }
        public byte? Ord { get; set; }
    }
}
