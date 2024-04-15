using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtpqForm
    {
        public string IdForm { get; set; } = null!;
        public string? Tenform { get; set; }
        public string? KhaibaoJson { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
