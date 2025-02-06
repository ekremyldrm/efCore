using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.Entites
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        // Navigator Property => ilişkili objeleri tanımlamk için kullanılır...
        public virtual List<Product> Products { get; set; }
    }
}
