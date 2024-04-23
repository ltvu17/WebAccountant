using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmtstk
    {
        public double Stt { get; set; }
        public string Mats { get; set; } = null!;
        public string? Tents { get; set; }
        public string Tkcp { get; set; } = null!;
        public double Ttkh { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
