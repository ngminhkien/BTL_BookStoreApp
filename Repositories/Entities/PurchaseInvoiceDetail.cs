using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class PurchaseInvoiceDetail
{
    public int InvoiceId { get; set; }

    public string BookId { get; set; } = null!;

    public int? Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual PurchaseInvoice Invoice { get; set; } = null!;
}
