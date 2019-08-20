using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindEntitiesLib
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public Shipper Shipper { get; set; }
        public decimal? Freight { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
