using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmkheuoc
    {
        public string SoHopdong { get; set; } = null!;
        public string Sokheuoc { get; set; } = null!;
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string? Tendtpn { get; set; }
        public string? Noidung { get; set; }
        public double GtKheuocVnd { get; set; }
        public double GtKheuocUsd { get; set; }
        public DateTime? Ngaykheuoc { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public DateTime? NgayDaoHan { get; set; }
        public double HanmucVnd { get; set; }
        public double HanmucUsd { get; set; }
        public double LaiSuatVay { get; set; }
        public string? DsLaiSuat { get; set; }
        public double GtHdVnd { get; set; }
        public double GtHdUsd { get; set; }
        public string? Ghichu { get; set; }
        public string? TkCpVay { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? IdUpdate { get; set; }
    }
}
