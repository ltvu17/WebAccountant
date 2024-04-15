using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class DmtscdTkcp
    {
        public double Thang { get; set; }
        public string Mats { get; set; } = null!;
        public string Tkcp { get; set; } = null!;
        public string? Tents { get; set; }
        public double Ptpb { get; set; }
        public double TtvndKh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
