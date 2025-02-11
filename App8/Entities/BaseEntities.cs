using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entities
{
    public class BaseEntities
    {
        public DateTime CreDate { get; set; }
        public string CreUser { get; set; }
        public Nullable<DateTime> ModDate { get; set; }
        public string? ModUser { get; set; }
        public bool? IsActive { get; set; }
    }
}
