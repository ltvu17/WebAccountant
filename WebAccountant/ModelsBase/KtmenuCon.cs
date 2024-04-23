using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class KtmenuCon
    {
        public string Matab { get; set; } = null!;
        public double SttMe { get; set; }
        public string? TenmenuMe { get; set; }
        public string SttCon { get; set; } = null!;
        public string? TenmenuCon { get; set; }
        public string? DanhsachUser { get; set; }
        public string? Hide { get; set; }
        public string? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
