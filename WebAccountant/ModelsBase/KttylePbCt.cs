using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KttylePbCt
    {
        public double Thang { get; set; }
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public double Tyle { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
