using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktlenhsx
    {
        public string MaLenh { get; set; } = null!;
        public DateTime? NgayLenh { get; set; }
        public double SttLenh { get; set; }
        public string? TenLenh { get; set; }
        public string? Noidung { get; set; }
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string Madm { get; set; } = null!;
        public string? Tendm { get; set; }
        public string? Donvi { get; set; }
        public double TonT { get; set; }
        public double NhapT { get; set; }
        public double XuatT { get; set; }
        public double TonCk { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
