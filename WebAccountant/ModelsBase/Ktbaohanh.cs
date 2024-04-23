using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktbaohanh
    {
        public string Imei { get; set; } = null!;
        public string? Machinhanh { get; set; }
        public string? Tinhtrang { get; set; }
        public string? Madm { get; set; }
        public string? Tendm { get; set; }
        public string? Dvt { get; set; }
        public string? SoHd { get; set; }
        public DateTime? Ngayban { get; set; }
        public DateTime? Ngayhhbh { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public string? Dienthoai { get; set; }
        public string? Diachi { get; set; }
        public string? MsDn { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public DateTime? Ngayxuat { get; set; }
        public string? Noidungbh { get; set; }
        public string? Tkhh { get; set; }
        public double TonDk { get; set; }
        public double NhapTk { get; set; }
        public double XuatTk { get; set; }
        public double TonCk { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
