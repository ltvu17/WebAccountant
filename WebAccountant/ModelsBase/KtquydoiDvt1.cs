using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtquydoiDvt1
    {
        public string Id { get; set; } = null!;
        public string? Noidung { get; set; }
        public string Madm { get; set; } = null!;
        public string? Tendm { get; set; }
        public string? Dvt1 { get; set; }
        public string? DvtNhapps { get; set; }
        public double Hesoquydoi { get; set; }
        public double? Trangthai { get; set; }
        public double Danhdau { get; set; }
    }
}
