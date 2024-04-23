using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class DmbarcodeLoi
    {
        public double Stt { get; set; }
        public string? Lctg { get; set; }
        public double SttScan { get; set; }
        public DateTime? Ngayct { get; set; }
        public string? Makh { get; set; }
        public string? Tenkh { get; set; }
        public string? Diachigiaohang { get; set; }
        public string? Barcode { get; set; }
        public string? Madtpn { get; set; }
        public string? Tendtpn { get; set; }
        public string? Matk { get; set; }
        public string? Madm { get; set; }
        public string? Tendm { get; set; }
        public string? Donvi { get; set; }
        public double Soluong { get; set; }
        public string? Mauser { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
        public double IdChungtu { get; set; }
    }
}
