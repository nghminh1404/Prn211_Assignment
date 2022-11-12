using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> ProductsNavigation { get; } = new List<Product>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
