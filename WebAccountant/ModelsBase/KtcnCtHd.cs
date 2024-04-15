using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtcnCtHd
    {
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string? Tendtpn { get; set; }
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public string Maduan { get; set; } = null!;
        public string? Tenduan { get; set; }
        public string Mahopdong { get; set; } = null!;
        public string? Sohopdong { get; set; }
        public string? Noidung { get; set; }
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
        public double TuoiNo { get; set; }
        public double UsdNo30 { get; set; }
        public double UsdNo3060 { get; set; }
        public double UsdNo6090 { get; set; }
        public double UsdNo90 { get; set; }
        public double VndNo30 { get; set; }
        public double VndNo3060 { get; set; }
        public double VndNo6090 { get; set; }
        public double VndNo90 { get; set; }
        public double VndpscoLk { get; set; }
        public double VndpsnoLk { get; set; }
        public string? IdUpdate { get; set; }
        public DateTime? Ngayhopdong { get; set; }
    }
}
