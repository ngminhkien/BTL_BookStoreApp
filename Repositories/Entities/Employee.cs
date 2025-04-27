using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();

    public virtual ICollection<SalesInvoice> SalesInvoices { get; set; } = new List<SalesInvoice>();

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
