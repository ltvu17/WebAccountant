using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAccountant.ModelsBase
{
    public partial class Ktdm
    {
        [Required(ErrorMessage ="Trường bắt buộc nhập")]
        public string Matk { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Madm { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập"), StringLength(maximumLength:200,MinimumLength = 4, ErrorMessage = "Không đủ kí tự")]
        public string? Tendm { get; set; }
        public string? Manhom { get; set; }
        public string? Tennhom { get; set; }
        public string? Kyhieu { get; set; }
        public string? Donvi { get; set; }
        public string? Lo { get; set; }
        public DateTime? Ngaylo { get; set; }
        public DateTime? Hansudung { get; set; }
        public string? Nhacungcap { get; set; }
        public string? Nhasanxuat { get; set; }
        public double Ptchietkhau { get; set; } = 0;
        public double Thuesuat { get; set; } = 0;
        public double Dgxuat { get; set; } = 0;
        public double TonT { get; set; } = 0;
        public double VndtonT { get; set; } = 0;
        public double NhapT { get; set; } = 0;
        public double VndnhapT { get; set; } = 0;
        public double XuatT { get; set; } = 0;
        public double VndxuatT { get; set; } = 0;
        public double TonCk { get; set; } = 0;
        public double VndtonCk { get; set; } = 0;
        public string? Danhdau { get; set; }
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Dgban { get; set; }
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Dgban1 { get; set; } = 0;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Dgban2 { get; set; } = 0;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Dgban3 { get; set; } = 0;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Dgban4 { get; set; } = 0;
        public string? Donvi1 { get; set; }
        public string? Donvi2 { get; set; }
        public string? Donvi3 { get; set; }
        public double Hsqd1 { get; set; } = 0;
        public double Hsqd2 { get; set; } = 0;
        public double Hsqd3 { get; set; } = 0;
        public double UsdtonT { get; set; } = 0;
        public double UsdnhapT { get; set; } = 0;
        public double UsdxuatT { get; set; } = 0;
        public double UsdtonCk { get; set; } = 0;
        public double Dgusd { get; set; } = 0;
        public double Dgnhap1 { get; set; } = 0;
        public double Dgnhap2 { get; set; } = 0;
        public double Dgnhap3 { get; set; } = 0;
        public double Dgnhap4 { get; set; } = 0;
        public double Dgnhap5 { get; set; } = 0;
        public double? Trangthai { get; set; }
        public double Dgnhap { get; set; } = 0;
        public double DgChuyenkho { get; set; } = 0;
        public string? DgCktm { get; set; }
        public double DgVc { get; set; } = 0;
        public string? DmCktm { get; set; }
        public double Gioihanton { get; set; } = 0;
        public string? MadmMe { get; set; }
        public string? Manhom1 { get; set; }
        public string? Manhom2 { get; set; }
        public string? Manhomtp { get; set; }
        public string? Model { get; set; }
        public string? SoDdh { get; set; }
        public string? TenDdh { get; set; }
        public string? TendmMe { get; set; }
        public string? Tennhom1 { get; set; }
        public string? Tennhom2 { get; set; }
        public string? Tennhomtp { get; set; }
        public string? TgCktm { get; set; }
        public string? TkChietkhau { get; set; }
        public string? TkDoanhthu { get; set; }
        public string? TkGiavon { get; set; }
        public string? TkTralai { get; set; }
        public double TyleOfNhom { get; set; } = 0;
        public double NhapTDv1 { get; set; } = 0;
        public double NhapTDv2 { get; set; } = 0;
        public double TonCkDv1 { get; set; } = 0;
        public double TonCkDv2 { get; set; } = 0;
        public double TonTDv1 { get; set; } = 0;
        public double TonTDv2 { get; set; } = 0;
        public double XuatTDv1 { get; set; } = 0;
        public double XuatTDv2 { get; set; } = 0;
        public string? Nhomck { get; set; }
        public string? Makho { get; set; }
        public string? Mavach { get; set; }
        public double GioihantonMax { get; set; } = 0;
        public string? IdUpdate { get; set; }
        public string? Tendm2 { get; set; }
        public double DgbanGanNhat { get; set; } = 0;
        public double DgmuaGanNhat { get; set; } = 0;
        public string? Ghichu { get; set; }
        public DateTime? NgaybanGanNhat { get; set; }
        public DateTime? NgaymuaGanNhat { get; set; }
        public string? Quycach { get; set; }
        public double Songaysudung { get; set; } = 0;
    }
}
