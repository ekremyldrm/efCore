using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Categories
    {
        [Key] // Alanın primarykey olduğunu söylüyoruz...
        public int CategoryID { get; set; }

        public string CategoryName { get;set; }
        public string? Description { get;set; } // Alanın nullable olduığunu belirtiyoruz...
    }
}
