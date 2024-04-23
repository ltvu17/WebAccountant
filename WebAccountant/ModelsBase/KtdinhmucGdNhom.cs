using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtdinhmucGdNhom
    {
        public double Thang { get; set; }
        public string Giaidoan { get; set; } = null!;
        public string ManhomThanhpham { get; set; } = null!;
        public string? TennhomThanhpham { get; set; }
        public string MaNvl { get; set; } = null!;
        public string? TenNvl { get; set; }
        public double Dinhmuc { get; set; }
        public string? Madtpnno { get; set; }
        public string? Madtpnco { get; set; }
        public double SlTp { get; set; }
        public double SlNvl { get; set; }
        public double DgNvl { get; set; }
        public double CpNvl { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
