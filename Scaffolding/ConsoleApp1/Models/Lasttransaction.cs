using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Lasttransaction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Value { get; set; }
}
