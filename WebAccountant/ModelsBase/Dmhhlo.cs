using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Dmhhlo
    {
        public string Lo { get; set; } = null!;
        public string? Tenlo { get; set; }
        public DateTime? Ngaylo { get; set; }
        public DateTime? Hansudung { get; set; }
        public string? Nhasanxuat { get; set; }
        public string? Nhacungcap { get; set; }
        public string? Mavitri { get; set; }
        public string? Tenvitri { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
