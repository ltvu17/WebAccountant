using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Kttscd
    {
        public double Thang { get; set; }
        public double Nam { get; set; }
        public double Stt { get; set; }
        public string Mats { get; set; } = null!;
        public string? Tents { get; set; }
        public string? CoKh { get; set; }
        public string? Tkts { get; set; }
        public string? Tkcp { get; set; }
        public string? Tkhm { get; set; }
        public string? Dtsudung { get; set; }
        public double Nguyengia { get; set; }
        public DateTime? Ngaymua { get; set; }
        public DateTime? Ngayban { get; set; }
        public DateTime? Ngaytrichkh { get; set; }
        public double Thoigiankh { get; set; }
        public double Kh1thang { get; set; }
        public double KhThangnay { get; set; }
        public double Gtconlai { get; set; }
        public double LuykeKh { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public string? Madtpnno { get; set; }
        public string? Madtpnco { get; set; }
        public string? MaCt { get; set; }
        public string? Maytcpno { get; set; }
        public double GtconlaiUsd { get; set; }
        public double KhThangnayUsd { get; set; }
        public double Kh1thangUsd { get; set; }
        public double LuykeKhUsd { get; set; }
        public string? Manhom { get; set; }
        public double NguyengiaUsd { get; set; }
        public double Tygia { get; set; }
        public double GtconlaiDk { get; set; }
        public double LuykeKhDk { get; set; }
        public double Vndtangnguyengia { get; set; }
        public string? Kyhieu { get; set; }
        public double NguyengiaDk { get; set; }
        public double LuykeKhThangcuoi { get; set; }
    }
}
