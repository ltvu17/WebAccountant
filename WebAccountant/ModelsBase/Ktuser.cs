using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktuser
    {
        public string MaUser { get; set; } = null!;
        public string? TenUser { get; set; }
        public string? Matkhau { get; set; }
        public string? MatkhauMoi { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
