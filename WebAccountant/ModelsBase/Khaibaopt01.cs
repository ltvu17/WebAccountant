using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Khaibaopt01
    {
        public string Chitieu { get; set; } = null!;
        public string? Tenct1 { get; set; }
        public string? Tkno { get; set; }
        public string? Tkco { get; set; }
        public string? Tenct2 { get; set; }
        public string? Maso { get; set; }
        public double TtvndKt { get; set; }
        public double TtvndKn { get; set; }
        public double TtusdKt { get; set; }
        public double TtusdKn { get; set; }
        public double NhanVoi { get; set; }
        public string? CoIn { get; set; }
        public string? ThuyetMinh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
