using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtMaTt
    {
        public string Kyhieu { get; set; } = null!;
        public string? Diengiai { get; set; }
        public string? Ghichu { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
