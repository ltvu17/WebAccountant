using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtpqFormUser
    {
        public string IdForm { get; set; } = null!;
        public string MaUser { get; set; } = null!;
        public string? TenUser { get; set; }
        public string? Tenform { get; set; }
        public string? KhaibaoJson { get; set; }
        public string? ChoSudung { get; set; }
        public string? ChoGiatri { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
