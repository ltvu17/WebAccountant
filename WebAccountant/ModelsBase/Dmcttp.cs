using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmcttp
    {
        public string MaCt { get; set; } = null!;
        public string? Tenct { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public string? SoHopdong { get; set; }
        public string Matp { get; set; } = null!;
        public string? Tentp { get; set; }
        public string? Dvt { get; set; }
        public double SlDh { get; set; }
        public double DgDh { get; set; }
        public double TtDh { get; set; }
        public double TylePb { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
    }
}
