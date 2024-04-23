using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Danhmucthuoc
    {
        public string Matk { get; set; } = null!;
        public string Madm { get; set; } = null!;
        public string? Mathuoc { get; set; }
        public string? Tendm { get; set; }
        public string? DonViTinh { get; set; }
        public string? SoDangKy { get; set; }
        public string? TenHoatChat { get; set; }
        public string? NongDoHamLuong { get; set; }
        public string? QuyCachDongGoi { get; set; }
        public string? HangSanXuat { get; set; }
        public string? NuocSanXuat { get; set; }
        public string? DangBaoChe { get; set; }
        public string? DonViDongGoiNn { get; set; }
        public string? NhaNhapKhau { get; set; }
        public double GiaKeKhai { get; set; }
        public double GiaBanBuon { get; set; }
        public string? SoDklh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? IdUpdate { get; set; }
    }
}
