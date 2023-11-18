using System;
using System.Collections.Generic;

namespace EntityFrameworkCore8Samples.DataAccessLayer.Entities;

public partial class Invoice
{
    public Guid Id { get; set; }

    public DateOnly Date { get; set; }

    public decimal Total { get; set; }
}
