using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Kttsdh
    {
        public double Stt { get; set; }
        public string Kybaocao { get; set; } = null!;
        public string? Lctg { get; set; }
        public string? Soct { get; set; }
        public DateTime? Ngayct { get; set; }
        public string? SrHd { get; set; }
        public string? SoHd { get; set; }
        public DateTime? NgayHd { get; set; }
        public string? Matk { get; set; }
        public string? Madtpn { get; set; }
        public string? Tendtpn { get; set; }
        public double Vndckno { get; set; }
        public double Vndckco { get; set; }
        public DateTime? NgayDaoHan { get; set; }
        public double TuoiNo { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
