using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtcnCtu
    {
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string? Tendtpn { get; set; }
        public string SoctU { get; set; } = null!;
        public DateTime? Ngayct { get; set; }
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
        public string? Cnee { get; set; }
        public string? Invoice { get; set; }
        public string MaCt { get; set; } = null!;
        public string? Shipper { get; set; }
        public string? SoBillVc { get; set; }
        public string SoHopdong { get; set; } = null!;
        public string? SochungtuVc { get; set; }
        public string? Sovandon { get; set; }
        public string? Type { get; set; }
        public string? Vsl { get; set; }
    }
}
