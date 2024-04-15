using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktcomputer
    {
        public string Hddid { get; set; } = null!;
        public string? Computer { get; set; }
        public string? Mauser { get; set; }
        public string? TgVao { get; set; }
        public string? TgRa { get; set; }
        public string? Khoadangnhap { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
