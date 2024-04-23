using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class TblTangt
    {
        public double Stt { get; set; }
        public double Nam { get; set; }
        public double Thang { get; set; }
        public string? Mats { get; set; }
        public string? Tents { get; set; }
        public string? Lctg { get; set; }
        public DateTime? Ngayct { get; set; }
        public string? Soct { get; set; }
        public double Kh1thangVnd { get; set; }
        public double Kh1thangUsd { get; set; }
        public double NguyengiatangVnd { get; set; }
        public double NguyengiatangUsd { get; set; }
        public double Danhdau { get; set; }
        public double Trangdau { get; set; }
        public double Kh1thangUsdCu { get; set; }
        public double Kh1thangVndCu { get; set; }
        public string? NgayHd { get; set; }
        public double NguyengiatangUsdCu { get; set; }
        public double NguyengiatangVndCu { get; set; }
        public string? SoHd { get; set; }
        public string? SrHd { get; set; }
        public double Ttvnd { get; set; }
    }
}
