using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtcnCtTt
    {
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string? Tendtpn { get; set; }
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public string? SoHopdong { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public double SttTt { get; set; }
        public DateTime? NgayTt { get; set; }
        public double VndTt { get; set; }
        public double UsdTt { get; set; }
        public double Vndduno { get; set; }
        public double Vndduco { get; set; }
        public double Vndpsno { get; set; }
        public double Vndpsco { get; set; }
        public double Vndckno { get; set; }
        public double Vndckco { get; set; }
        public double Usdduno { get; set; }
        public double Usdduco { get; set; }
        public double Usdpsno { get; set; }
        public double Usdpsco { get; set; }
        public double Usdckno { get; set; }
        public double Usdckco { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? KyTt { get; set; }
    }
}
