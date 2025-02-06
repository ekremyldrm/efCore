using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
    }
}