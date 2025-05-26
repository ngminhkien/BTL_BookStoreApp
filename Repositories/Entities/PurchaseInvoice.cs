using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class PurchaseInvoice
{
    public int InvoiceId { get; set; }

    public string? SupplierId { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public double? TotalAmount { get; set; }

    public string? Note { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; } = new List<PurchaseInvoiceDetail>();

    public virtual Supplier? Supplier { get; set; }
}
