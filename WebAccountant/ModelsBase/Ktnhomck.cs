using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktnhomck
    {
        public string Id { get; set; } = null!;
        public double Stt { get; set; }
        public DateTime? Ngayad { get; set; }
        public DateTime? Ngaykethuc { get; set; }
        public string? Manhomhh { get; set; }
        public string? Tennhomhh { get; set; }
        public string? Manhomdt { get; set; }
        public string? Tennhomdt { get; set; }
        public double PtCk { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
