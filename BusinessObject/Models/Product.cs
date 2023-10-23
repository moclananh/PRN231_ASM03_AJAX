using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Weight { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        public virtual Category Category { get; set; }
    }
}
