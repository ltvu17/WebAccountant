using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAccountant.ModelsBase
{
    public partial class Kttk
    {
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Matk { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string? Tentk { get; set; }
        public string? MatkE { get; set; }
        public string? TentkE { get; set; }
        public string? Loaitien { get; set; }
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public double Vndduno { get; set; }
        public double Vndduco { get; set; } = 0;
        public double Vndpsno { get; set; } = 0;
        public double Vndpsco { get; set; } = 0;
        public double VndpsnoLk { get; set; } = 0;
        public double VndpscoLk { get; set; } = 0;
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
        public double Eurckco { get; set; } = 0;
        public double Eurckno { get; set; } = 0;
        public double Eurduco { get; set; } = 0;
        public double Eurduno { get; set; } = 0;
        public double Eurpsco { get; set; } = 0;
        public double Eurpsno { get; set; } = 0;
        public string? MatkKc { get; set; }
        public double UsdpscoLk { get; set; } = 0;
        public double UsdpsnoLk { get; set; } = 0;
        public string? MatkMoi { get; set; }
        public string? TkChietkhau { get; set; }
        public string? TkGiavon { get; set; }
        public string? TkTralai { get; set; }
    }
}
