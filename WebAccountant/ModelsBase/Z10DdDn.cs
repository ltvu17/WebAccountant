using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z10DdDn
    {
        public string Giaidoan { get; set; } = null!;
        public string Madtgt { get; set; } = null!;
        public string? Tendtgt { get; set; }
        public double DkNl { get; set; }
        public double DkNc { get; set; }
        public double DkSxc { get; set; }
        public double DkTong { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
