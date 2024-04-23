using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtUserTable
    {
        public string Tenbang { get; set; } = null!;
        public string MaUser { get; set; } = null!;
        public string? ChoSua { get; set; }
        public string? ChoXoa { get; set; }
        public string? ChoThem { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
