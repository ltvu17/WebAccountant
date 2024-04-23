using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtBophanUser
    {
        public string Mabophan { get; set; } = null!;
        public string Mauser { get; set; } = null!;
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
