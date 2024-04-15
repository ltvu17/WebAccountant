using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class CfgKhac
    {
        public string Idv { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Giatri { get; set; }
        public string? Ghichu { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
