using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtHd
    {
        public string SoHopdong { get; set; } = null!;
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public DateTime? NgayHopdong { get; set; }
        public DateTime? NgayDaoHan { get; set; }
        public string? Noidung { get; set; }
        public string? Tendtpn { get; set; }
        public double GtVnd { get; set; }
        public double GtUsd { get; set; }
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
        public string? Tylelaivay { get; set; }
        public double Hanmuc { get; set; }
        public double Hanmucusd { get; set; }
        public string? IdUpdate { get; set; }
        public string? SoHopdongGoc { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
    }
}
