using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtmenuNadopo
    {
        public string MaMenuMe { get; set; } = null!;
        public string? TenMenuMe { get; set; }
        public string MaMenuCon { get; set; } = null!;
        public string? TenMenuCon { get; set; }
        public string? DsUser { get; set; }
        public string? SdLoaitru { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
