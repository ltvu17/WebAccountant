using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class Ktcp
    {
        public string Matk { get; set; } = null!;
        public string Madtpn { get; set; } = null!;
        public string Maytcp { get; set; } = null!;
        public string? Tentk { get; set; }
        public string? Tendtpn { get; set; }
        public string? Tenytcp { get; set; }
        public double Vndduno { get; set; }
        public double Vndduco { get; set; }
        public double Vndpsno { get; set; }
        public double Vndpsco { get; set; }
        public double Vndckno { get; set; }
        public double Vndckco { get; set; }
        public double VndpsnoLk { get; set; }
        public double VndpscoLk { get; set; }
        public double Usdduno { get; set; }
        public double Usdduco { get; set; }
        public double Usdpsno { get; set; }
        public double Usdpsco { get; set; }
        public double Usdckno { get; set; }
        public double Usdckco { get; set; }
        public double UsdpsnoLk { get; set; }
        public double UsdpscoLk { get; set; }
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
