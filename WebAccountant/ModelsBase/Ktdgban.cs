using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktdgban
    {
        public double SttDg { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string Manhom { get; set; } = null!;
        public string Tennhom { get; set; } = null!;
        public string? Madm { get; set; }
        public string? Tendm { get; set; }
        public string? Donvi { get; set; }
        public double Cong { get; set; }
        public double Dgvnd { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
