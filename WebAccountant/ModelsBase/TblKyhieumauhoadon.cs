using System;
using System.Collections.Generic;

namespace WebAccountant.ModelsBase
{
    public partial class TblKyhieumauhoadon
    {
        public string Id { get; set; } = null!;
        public string? Danhdau { get; set; }
        public double? Trangthai { get; set; }
    }
}
