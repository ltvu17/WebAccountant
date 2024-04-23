using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z10NhapDd
    {
        public double Thang { get; set; }
        public string Giaidoan { get; set; } = null!;
        public string Madtgt { get; set; } = null!;
        public string? Tendtgt { get; set; }
        public double SlTp { get; set; }
        public double DkNl { get; set; }
        public double DkNc { get; set; }
        public double DkSxc { get; set; }
        public double DkTong { get; set; }
        public double No154Nl { get; set; }
        public double No154Nc { get; set; }
        public double No154Sxc { get; set; }
        public double No154Tong { get; set; }
        public double Co154Nl { get; set; }
        public double Co154Nc { get; set; }
        public double Co154Sxc { get; set; }
        public double Co154Tong { get; set; }
        public double CkNl { get; set; }
        public double CkNc { get; set; }
        public double CkSxc { get; set; }
        public double CkTong { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
