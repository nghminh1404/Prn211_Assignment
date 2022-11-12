using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models;

public partial class Cash
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string Cashier { get; set; } = null!;

    public double? Total { get; set; }

    public virtual Product Product { get; set; } = null!;
}
