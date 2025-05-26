using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class SalesInvoice
{
    public int InvoiceId { get; set; }

    public string? CustomerId { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public double? TotalAmount { get; set; }

    public string? Note { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<SalesInvoiceDetail> SalesInvoiceDetails { get; set; } = new List<SalesInvoiceDetail>();
}
