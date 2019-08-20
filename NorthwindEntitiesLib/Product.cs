using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindEntitiesLib
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsInOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discounted { get; set; } = false;
    }
}
