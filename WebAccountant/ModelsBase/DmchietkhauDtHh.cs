using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class DmchietkhauDtHh
    {
        public double Stt { get; set; }
        public string? Id { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngaykethuc { get; set; }
        public string? Madm { get; set; }
        public string? Tendm { get; set; }
        public string? Dvt { get; set; }
        public string? Madtpn { get; set; }
        public string? Tendtpn { get; set; }
        public double PtCk1 { get; set; }
        public double PtCk2 { get; set; }
        public double TtCk1 { get; set; }
        public double TtCk2 { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
