using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class TonghopLtv
    {
        public double Id { get; set; }
        public string? Tt { get; set; }
        public string? Thang { get; set; }
        public string? Ct { get; set; }
        public string? TenCongtrinh { get; set; }
        public string? MaNhanvien { get; set; }
        public string? TenNhanvien { get; set; }
        public string? CongViec { get; set; }
        public double LuongCanban { get; set; }
        public double Ngaycong { get; set; }
        public double LuongThucNhan { get; set; }
        public string? KyNhan { get; set; }
        public DateTime? Vao { get; set; }
        public DateTime? Ra { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
