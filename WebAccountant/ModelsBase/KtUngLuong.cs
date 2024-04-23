using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtUngLuong
    {
        public string? LoaiBangLuong { get; set; }
        public double Stt { get; set; }
        public double Nam { get; set; }
        public double Thang { get; set; }
        public string? TkLuong { get; set; }
        public string? TkTamung { get; set; }
        public string? MaNhanVien { get; set; }
        public string? MaVach { get; set; }
        public string? HoTenViet { get; set; }
        public string? PhongBan { get; set; }
        public string? TenPhongBan { get; set; }
        public double LuongCoBan { get; set; }
        public double TamUngLuong { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
