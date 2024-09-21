using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime DateOrder { get; set; }

        public DateTime DateRequired { get; set; }

        public DateTime DateShipped { get; set; }

        public int ShipperId { get; set; }

        public decimal Freight { get; set; }

        public string ShipName { get; set; } = string.Empty;

        public string ShipAddress { get; set; } = string.Empty;

        public string ShipCity { get; set; } = string.Empty;

        public string ShipRegion { get; set; } = string.Empty;

        public int ShipPostalCode { get; set; }

        public string ShipCountry { get; set; } = string.Empty;

    }
}
