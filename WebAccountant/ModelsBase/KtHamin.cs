using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtHamin
    {
        public string Lctg { get; set; } = null!;
        public string Stt { get; set; } = null!;
        public string? Haminchungtu { get; set; }
        public string? FileExcel { get; set; }
        public string? Danhdau { get; set; }
        public double Sodong { get; set; }
        public double BeronggapHd { get; set; }
        public double? Trangthai { get; set; }
        public string? Cotgap { get; set; }
    }
}
