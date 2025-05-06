using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string BookName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public int Quantity { get; set; }

    public double ImportPrince { get; set; }

    public double SelltPrince { get; set; }

    public string? PublisherId { get; set; }

    public string? AuthorId { get; set; }

    public int? BookCategoryId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual BookCategory? BookCategory { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; } = new List<PurchaseInvoiceDetail>();

    public virtual ICollection<SalesInvoiceDetail> SalesInvoiceDetails { get; set; } = new List<SalesInvoiceDetail>();
}
