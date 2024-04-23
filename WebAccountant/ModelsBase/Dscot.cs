using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dscot
    {
        public double Stt { get; set; }
        public string Tenbang { get; set; } = null!;
        public string Macot { get; set; } = null!;
        public string? Tencot { get; set; }
        public string? Berong { get; set; }
        public string? Kieudulieu { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
