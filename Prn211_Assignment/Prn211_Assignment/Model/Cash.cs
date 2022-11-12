using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class Cash
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string TransactionNo { get; set; } = null!;
        public int Cashier { get; set; }
        public double? Total { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
