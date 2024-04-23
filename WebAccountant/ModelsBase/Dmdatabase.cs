using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmdatabase
    {
        public string Tendatabase { get; set; } = null!;
        public double Namhachtoan { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
    }
}
