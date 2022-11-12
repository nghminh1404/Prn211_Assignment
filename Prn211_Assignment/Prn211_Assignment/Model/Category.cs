using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class Category
    {
        public Category()
        {
            ProductsNavigation = new HashSet<Product>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> ProductsNavigation { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
