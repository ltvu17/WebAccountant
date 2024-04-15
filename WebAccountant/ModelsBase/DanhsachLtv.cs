using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class DanhsachLtv
    {
        public double Id { get; set; }
        public double Stt { get; set; }
        public string? MaNv { get; set; }
        public string? Ten { get; set; }
        public string? SoCm { get; set; }
        public string? Namsinh { get; set; }
        public string? Thangsinh { get; set; }
        public string? Ngaysinh { get; set; }
        public string? Nghenghiep { get; set; }
        public string? NguyenQuan { get; set; }
        public string? ThuongTru { get; set; }
        public DateTime? Ngaycap { get; set; }
        public string? Noicap { get; set; }
        public string? Chucdanh { get; set; }
        public string? Chucvu { get; set; }
        public string? Congviec { get; set; }
        public double Tienluong { get; set; }
        public DateTime? Tu { get; set; }
        public DateTime? Den { get; set; }
        public string? Congtrinh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
