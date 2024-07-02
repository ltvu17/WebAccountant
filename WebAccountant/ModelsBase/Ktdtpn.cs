using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAccountant.ModelsBase
{
    public partial class Ktdtpn
    {
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Madtpn { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string? Tendtpn { get; set; }
        public string? Diachi { get; set; } = " ";
        public string? DiachiGh { get; set; }
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string? MsDn { get; set; }
        public string? LienHe { get; set; }
        public string? Dienthoai { get; set; }
        public string? Tknh { get; set; }
        public string? Tentknh { get; set; }
        public string? Matt { get; set; }
        public string? Tentt { get; set; }
        public string? Manhom { get; set; }
        public string? Tennhom { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; } = 0;
        public string? Fax { get; set; }
        public string? Manhom1 { get; set; }
        public double Mucgia { get; set; } = 0;
        public double PtCk { get; set; } = 0;
        public string? Tennhom1 { get; set; }
        public string? Nguoidaidien { get; set; }
        public string? Email { get; set; }
        public string? Kieudoituong { get; set; }
        public string? Nhomck { get; set; }
        public string? Manhomdt1 { get; set; }
        public string? Tennhomdt1 { get; set; }
        public double NoMax { get; set; } = 0;
        public double Songaythanhtoan { get; set; } = 0;
        public string? Tkco { get; set; }
        public string? Tkno { get; set; }
        public string? Emailcc { get; set; }
        public string? Mactyme { get; set; }
        public string? Tenctyme { get; set; }
        public string? Lctg { get; set; }
        public string? MacosoDqg { get; set; }
        public string? MaVung { get; set; }
        public string? Tenvung { get; set; }
        public string? IdUpdate { get; set; }
    }
}
