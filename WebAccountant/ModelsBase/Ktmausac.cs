using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktmausac
    {
        public string Mamausac { get; set; } = null!;
        public string? Tenmausac { get; set; }
        public string Madm { get; set; } = null!;
        public string? Tendm { get; set; }
        public double Dgmausac { get; set; }
        public double PtThanhtien { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
