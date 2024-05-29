using System;
using System.Collections.Generic;

namespace Module2.EFCoreDatabaseFirstApproach.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public double? CustomerAmount { get; set; }
}
