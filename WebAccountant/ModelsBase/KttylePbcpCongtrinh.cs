using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KttylePbcpCongtrinh
    {
        public double Thang { get; set; }
        public string Matk { get; set; } = null!;
        public string? Tentk { get; set; }
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public string Maytcp { get; set; } = null!;
        public string? Tenytcp { get; set; }
        public string Mabpsx { get; set; } = null!;
        public string? Tenbpsx { get; set; }
        public double Tyle { get; set; }
        public string? IdUpdate { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
