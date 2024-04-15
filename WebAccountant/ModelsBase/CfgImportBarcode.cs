using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class CfgImportBarcode
    {
        public string Id { get; set; } = null!;
        public string? DbNguon { get; set; }
        public string? Mauser { get; set; }
        public string? DsChungtuNguon { get; set; }
        public string? DsChungtuDich { get; set; }
        public string? TkTheoKtlctg { get; set; }
        public string? Goptheomadm { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
