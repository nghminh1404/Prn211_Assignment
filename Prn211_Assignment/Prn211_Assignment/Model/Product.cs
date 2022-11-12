using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class Product
    {
        public Product()
        {
            Cashes = new HashSet<Cash>();
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Cash> Cashes { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
