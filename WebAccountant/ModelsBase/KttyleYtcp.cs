using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KttyleYtcp
    {
        public double Thang { get; set; }
        public string Maytcp { get; set; } = null!;
        public string? Tenytcp { get; set; }
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public double Tyle { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Donvi { get; set; }
        public double SlTp { get; set; }
    }
}
