using System;
using System.Collections.Generic;

namespace MvcEfDemo.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCategory { get; set; }

    public int? ProductPrice { get; set; }
}
