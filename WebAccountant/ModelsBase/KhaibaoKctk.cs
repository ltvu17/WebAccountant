using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KhaibaoKctk
    {
        public string TkKc { get; set; } = null!;
        public string SoduKc { get; set; } = null!;
        public string? Tkno { get; set; }
        public string? Tkco { get; set; }
        public string? Diengiai { get; set; }
        public double Ttvnd { get; set; }
        public double Ttusd { get; set; }
        public double? Trangthai { get; set; }
        public double TtKc { get; set; }
        public string? Danhdau { get; set; }
    }
}
