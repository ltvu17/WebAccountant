using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtddnlGd
    {
        public double Thang { get; set; }
        public string Giaidoan { get; set; } = null!;
        public string MaNguyenlieu { get; set; } = null!;
        public string? TkDd { get; set; }
        public string? TkNl { get; set; }
        public string? TenNguyenlieu { get; set; }
        public string? Donvi { get; set; }
        public double SlNl { get; set; }
        public double DgNl { get; set; }
        public double TtNl { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
