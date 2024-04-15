using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmuser
    {
        public string MaUser { get; set; } = null!;
        public string? TenUser { get; set; }
        public double SttKy { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Chucvu { get; set; }
        public string? Kieukiemtramavach { get; set; }
    }
}
