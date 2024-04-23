using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Kttyle
    {
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public double Tyle { get; set; }
        public double SlTp { get; set; }
        public double SlTpQd { get; set; }
        public double Giathanh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
