using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Author
{
    public string AuthorId { get; set; } = null!;

    public string? AuthorName { get; set; }

    public DateTime BirthOfDate { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
