using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Quyensd
    {
        public string Mauser { get; set; } = null!;
        public string Tenbang { get; set; } = null!;
        public string? Dscot { get; set; }
        public string? Dieukien { get; set; }
        public string? Sddatauserkhac { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? DscotAn { get; set; }
        public string? CoAncot { get; set; }
        public string? TenUser { get; set; }
    }
}
