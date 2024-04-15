using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmhopdong
    {
        public string Mahopdong { get; set; } = null!;
        public string? Matk { get; set; }
        public string? Madtpn { get; set; }
        public string? SoHopdongGoc { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public DateTime? NgayDaoHan { get; set; }
        public string? Noidung { get; set; }
        public string? Tendtpn { get; set; }
        public double GtVnd { get; set; }
        public double GtUsd { get; set; }
        public string? Tylelaivay { get; set; }
        public double HanmucVnd { get; set; }
        public double HanmucUsd { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
    }
}
