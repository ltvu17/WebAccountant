using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAccountant.ModelsBase
{
    public partial class Ktcn
    {
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Matk { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Madtpn { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string? Tendtpn { get; set; }
        public double Vndduno { get; set; } = 0;
        public double Vndduco { get; set; } = 0;
        public double Vndpsno { get; set; } = 0;
        public double Vndpsco { get; set; } = 0;
        public double Vndckno { get; set; } = 0;
        public double Vndckco { get; set; } = 0;
        public double Usdduno { get; set; } = 0;
        public double Usdduco { get; set; } = 0;
        public double Usdpsno { get; set; } = 0;
        public double Usdpsco { get; set; } = 0;
        public double Usdckno { get; set; } = 0;
        public double Usdckco { get; set; } = 0;
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; } = 0;
        public double VndnoMax { get; set; } = 0;
        public string? Diachi { get; set; }
        public double Dientich { get; set; } = 0;
        public double Dongia { get; set; } = 0;
        public double Eurckco { get; set; } = 0;
        public double Eurckno { get; set; } = 0;
        public double Eurduco { get; set; } = 0;
        public double Eurduno { get; set; } = 0;
        public double Eurpsco { get; set; } = 0;
        public double Eurpsno { get; set; } = 0;
        public double GiatriHopdong { get; set; } = 0;
        public string? Manhom1 { get; set; }
        public string? Manhom2 { get; set; }
        public string? Manhom3 { get; set; }
        public string? Matt { get; set; }
        public DateTime? NgayHopdong { get; set; }
        public DateTime? NgayThanhly { get; set; }
        public string? SoHopdong { get; set; }
        public string? Tennhom1 { get; set; }
        public string? Tennhom2 { get; set; }
        public string? Tennhom3 { get; set; }
        public string? Tentt { get; set; }
        public string? IdUpdate { get; set; }
    }
}
