using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class Bill
    {
        public Bill()
        {
            Customers = new HashSet<User>();
        }

        public int Id { get; set; }
        public string CreatebyUser { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public int? ProdcutId { get; set; }
        public double? TotalPrice { get; set; }
        public int? TotalQuantity { get; set; }
        public string? BillNumber { get; set; }

        public virtual ICollection<User> Customers { get; set; }
    }
}
