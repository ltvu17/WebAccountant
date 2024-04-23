using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z12KttyleYtcpKho
    {
        public double Thang { get; set; }
        public string Makho { get; set; } = null!;
        public string Giaidoan { get; set; } = null!;
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public string Maytcp { get; set; } = null!;
        public string? Tenytcp { get; set; }
        public double Tyle { get; set; }
        public double SlTp { get; set; }
        public double SlTpQd { get; set; }
        public double Giathanh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
