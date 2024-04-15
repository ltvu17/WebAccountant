using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class TblDmdtcongtrinh
    {
        public string Idc { get; set; } = null!;
        public double SttBt { get; set; }
        public double SttSs { get; set; }
        public string? MaCt { get; set; }
        public string? Tenct { get; set; }
        public string? MaHm { get; set; }
        public string? Tenhm { get; set; }
        public string? Maytcp { get; set; }
        public string? Tenytcp { get; set; }
        public string? Manvl { get; set; }
        public string? Tennvl { get; set; }
        public string? Noidung { get; set; }
        public double Sldt { get; set; }
        public double Dgdt { get; set; }
        public double Ttdt { get; set; }
        public string? Ghichu { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
