using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtMaCong
    {
        public string MaCong { get; set; } = null!;
        public string? TenCong { get; set; }
        public double SoNgayCong { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
