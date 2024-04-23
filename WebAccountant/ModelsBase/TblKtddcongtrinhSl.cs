using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class TblKtddcongtrinhSl
    {
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public string Matk { get; set; } = null!;
        public string Maytcp { get; set; } = null!;
        public string Madm { get; set; } = null!;
        public string? Tendm { get; set; }
        public string? Kyhieu { get; set; }
        public string? Quycach { get; set; }
        public string? Donvi { get; set; }
        public double Dgxuat { get; set; }
        public double LkDkSl { get; set; }
        public double LkDkGt { get; set; }
        public double TonT { get; set; }
        public double VndtonT { get; set; }
        public double NhapT { get; set; }
        public double VndnhapT { get; set; }
        public double XuatT { get; set; }
        public double VndxuatT { get; set; }
        public double TonCk { get; set; }
        public double VndtonCk { get; set; }
        public double LkCkSl { get; set; }
        public double LkCkGt { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? IdUpdate { get; set; }
        public string TkChiphi { get; set; } = null!;
    }
}
