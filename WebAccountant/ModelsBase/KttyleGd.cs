using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KttyleGd
    {
        public string Giaidoan { get; set; } = null!;
        public string MaThanhpham { get; set; } = null!;
        public double Thang { get; set; }
        public string? TenThanhpham { get; set; }
        public double Tyle { get; set; }
        public double SlTp { get; set; }
        public double SlTpQd { get; set; }
        public double Giathanh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
