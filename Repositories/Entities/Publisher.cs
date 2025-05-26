using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Publisher
{
    public string PublisherId { get; set; } = null!;

    public string? PublisherName { get; set; }

    public string? PublisherAddress { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
