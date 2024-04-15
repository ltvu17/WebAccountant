using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmkyhachtoan
    {
        public string Kyhachtoan { get; set; } = null!;
        public double Thang { get; set; }
        public double Nam { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
        public double Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
