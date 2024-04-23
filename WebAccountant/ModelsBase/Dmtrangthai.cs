using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmtrangthai
    {
        public string Matrangthai { get; set; } = null!;
        public string? Tentrangthai { get; set; }
        public string Nhomtrangthai { get; set; } = null!;
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string Mauser { get; set; } = null!;
    }
}
