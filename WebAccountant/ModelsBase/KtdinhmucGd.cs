using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtdinhmucGd
    {
        public double Thang { get; set; }
        public string Giaidoan { get; set; } = null!;
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public string MaNvl { get; set; } = null!;
        public string? TenNvl { get; set; }
        public double Dinhmuc { get; set; }
        public double SlTp { get; set; }
        public double SlNvl { get; set; }
        public double DgNvl { get; set; }
        public double CpNvl { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Madtpnco { get; set; }
        public string? Madtpnno { get; set; }
        public string? Ghichu { get; set; }
    }
}
