using WebAccountant.ModelsBase;

namespace WebAccountant.Models
{
    public class PhieuMuaHangDTO
    {
        public int id { get; set; }
        public DateTime NgayCtu { get; set; }
        public string Soctu { get; set; }
        public string HTThanhToan { get; set; }
        public string ThanhTien { get; set; }
        public string ckPhanTram { get; set; }
        public string CkThanhTien { get; set; }
        public string TongTien { get; set; }
        public string KhTraTien { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string MsThue { get; set; }
        public string Diachi { get; set; }
        public string GhiChu { get; set; }
        public string NhanVienBan { get; set; }
        public List<Ktsc> ktscs { get; set; } = new List<Ktsc>();

    }
}
