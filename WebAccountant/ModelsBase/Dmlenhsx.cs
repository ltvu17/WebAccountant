using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmlenhsx
    {
        public string MaLenh { get; set; } = null!;
        public DateTime? NgayLenh { get; set; }
        public string? TenLenh { get; set; }
        public string? Noidung { get; set; }
        public string? Madtpn { get; set; }
        public string? Tendtpn { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Mauser { get; set; }
    }
}
