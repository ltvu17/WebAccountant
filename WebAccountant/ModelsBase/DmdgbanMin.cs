using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class DmdgbanMin
    {
        public string Id { get; set; } = null!;
        public double Stt { get; set; }
        public DateTime? Ngayad { get; set; }
        public DateTime? Ngaykethuc { get; set; }
        public string? Madm { get; set; }
        public string? Tendm { get; set; }
        public double Dgbanchuan { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
