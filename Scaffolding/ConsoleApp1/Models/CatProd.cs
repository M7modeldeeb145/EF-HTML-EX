using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class CatProd
{
    public string CategoryName { get; set; } = null!;

    public int? NumOfProducts { get; set; }

    public string? Rate { get; set; }
}
