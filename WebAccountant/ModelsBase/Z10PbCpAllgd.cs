using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z10PbCpAllgd
    {
        public double Thang { get; set; }
        public string Giaidoan { get; set; } = null!;
        public string Matk { get; set; } = null!;
        public double CpAllGiaidoan { get; set; }
        public double CpPbGiaidoan { get; set; }
        public double CpRiengGiaidoan { get; set; }
        public double Tyle { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
