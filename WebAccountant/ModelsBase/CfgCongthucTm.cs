using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class CfgCongthucTm
    {
        public double Dong { get; set; }
        public string Cot { get; set; } = null!;
        public string? Congthuc { get; set; }
        public string? Ghichu { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
