using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktkheuoc
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
        public string? TkCpVay { get; set; }
        public string? DsLaiSuat { get; set; }
        public double GtHdVnd { get; set; }
        public double GtHdUsd { get; set; }
        public double VndLthDk { get; set; }
        public double UsdLthDk { get; set; }
        public double VndLthTk { get; set; }
        public double UsdLthTk { get; set; }
        public double VndLthCk { get; set; }
        public double UsdLthCk { get; set; }
        public double VndLqhDk { get; set; }
        public double UsdLqhDk { get; set; }
        public double VndLqhTk { get; set; }
        public double UsdLqhTk { get; set; }
        public double VndLqhCk { get; set; }
        public double UsdLqhCk { get; set; }
        public double VndTongLai { get; set; }
        public double UsdTongLai { get; set; }
        public double SongayTong { get; set; }
        public double SongayTh { get; set; }
        public double SongayQh { get; set; }
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
        public double TuoiNo { get; set; }
        public double VndNo30 { get; set; }
        public double VndNo3060 { get; set; }
        public double VndNo6090 { get; set; }
        public double VndNo90 { get; set; }
        public double UsdNo30 { get; set; }
        public double UsdNo3060 { get; set; }
        public double UsdNo6090 { get; set; }
        public double UsdNo90 { get; set; }
        public double TygiaNo { get; set; }
        public double TygiaCo { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? IdUpdate { get; set; }
    }
}
