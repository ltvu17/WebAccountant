using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KttylePb
    {
        public double Thang { get; set; }
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public double Tyle { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Donvi { get; set; }
    }
}
