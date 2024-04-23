using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Khaibaocdkt
    {
        public string Chitieu { get; set; } = null!;
        public string? Tenct1 { get; set; }
        public string? Tenct2 { get; set; }
        public string? Maso { get; set; }
        public string? Tm { get; set; }
        public double TtusdDk { get; set; }
        public double TtusdCk { get; set; }
        public double TtvndDk { get; set; }
        public double TtvndCk { get; set; }
        public string? Taikhoan { get; set; }
        public string? Sodu { get; set; }
        public string? KieuIn { get; set; }
        public string? CoIn { get; set; }
        public string? Nhom1 { get; set; }
        public string? Nhom2 { get; set; }
        public string? Nhom3 { get; set; }
        public string? Nhom4 { get; set; }
        public string? Nhom0 { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public double TtusdNt { get; set; }
        public double TtvndNt { get; set; }
    }
}
