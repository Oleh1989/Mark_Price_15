﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindEntitiesLib
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}