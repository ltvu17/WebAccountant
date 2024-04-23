using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z12KtdmncKho
    {
        public double Thang { get; set; }
        public string Makho { get; set; } = null!;
        public string Giaidoan { get; set; } = null!;
        public string MaThanhpham { get; set; } = null!;
        public string? TenThanhpham { get; set; }
        public double Dinhmuc { get; set; }
        public double SlTp { get; set; }
        public double CpNc { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
