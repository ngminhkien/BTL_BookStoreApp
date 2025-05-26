using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Supplier
{
    public string SupplierId { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
}
