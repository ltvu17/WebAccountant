using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktdtgt
    {
        public string Tkdd { get; set; } = null!;
        public string Madtgt { get; set; } = null!;
        public string? Tendtgt { get; set; }
        public DateTime? Ngayps { get; set; }
        public double? Trangthai { get; set; }
        public string? Danhdau { get; set; }
        public string? Donvi { get; set; }
    }
}
