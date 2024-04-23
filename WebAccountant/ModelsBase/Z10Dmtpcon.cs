using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Z10Dmtpcon
    {
        public string Giaidoan { get; set; } = null!;
        public string Madtgt { get; set; } = null!;
        public string? Tendtgt { get; set; }
        public string Matp { get; set; } = null!;
        public string? Tentp { get; set; }
        public string? DvtTp { get; set; }
        public double SlYc { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public string? SoHopdong { get; set; }
        public string? Noidung { get; set; }
        public double GtHopdong { get; set; }
        public DateTime? Ngayht { get; set; }
        public double TylePhanbo { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public double Dgvnd { get; set; }
        public double Nam { get; set; }
        public double Thang { get; set; }
        public double Ttvnd { get; set; }
        public string? IdUpdate { get; set; }
    }
}
