using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Promotion
{
    public int PromotionId { get; set; }

    public string PromotionName { get; set; } = null!;

    public decimal? Discount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime ExpiredDate { get; set; }
}
