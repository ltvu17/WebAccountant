using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class CfgImportTuServerKhac
    {
        public string Id { get; set; } = null!;
        public string? Noidung { get; set; }
        public string? ServerNguon { get; set; }
        public string? DatabaseNguon { get; set; }
        public string? Username { get; set; }
        public string? Matkhau { get; set; }
        public string? TenbangNguon { get; set; }
        public string? Dieukien { get; set; }
        public string? Bieuthucgop { get; set; }
        public string? Coxoacu { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
        public string? Coxulygiaban { get; set; }
    }
}
