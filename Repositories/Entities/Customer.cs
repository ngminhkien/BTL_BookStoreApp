using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<SalesInvoice> SalesInvoices { get; set; } = new List<SalesInvoice>();
}
