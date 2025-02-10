using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6.Entites
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public int ShipVia { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }


        // DataAnnotation attribute ile ilişkiyi sağlıyoruz..
        [ForeignKey("ShipVia")] // navigation property'nin alanın ShipVia olduğpunu belirtiriyoruz..
        public virtual Shipper Shipper { get; set; }
        // NavigationPropertyName'li foreignKer arar..

    }
}
