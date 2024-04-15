using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmbarcode
    {
        public string Barcode { get; set; } = null!;
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string Madm { get; set; } = null!;
        public string Lo { get; set; } = null!;
        public DateTime? Ngaylo { get; set; }
        public string? Tendtpn { get; set; }
        public string? Tendm { get; set; }
        public string? Kyhieu { get; set; }
        public string? Donvi { get; set; }
        public string? Donvi1 { get; set; }
        public string? Donvi2 { get; set; }
        public double Dgvnd { get; set; }
        public double Dgusd { get; set; }
        public double TonT { get; set; }
        public double VndtonT { get; set; }
        public double UsdtonT { get; set; }
        public DateTime? Hansudung { get; set; }
        public string? Nhasanxuat { get; set; }
        public string? Nhacungcap { get; set; }
        public double TonTDv1 { get; set; }
        public double TonTDv2 { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public DateTime? Ngaynhapkho { get; set; }
        public string? IdUpdate { get; set; }
        public double SttIn { get; set; }
    }
}
