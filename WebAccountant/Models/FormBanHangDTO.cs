using System.ComponentModel.DataAnnotations;
using WebAccountant.ModelsBase;

namespace WebAccountant.Models
{
    public class FormBanHangDTO
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Hãy điền khách hàng!")]
        public string Makh { get; set; }
        public DateTime NgayCtu { get; set; }
        public Ktdtpn KhachHang { get; set; }
        public DateTime NgayHToan { get; set; }
        public string SoHoaDon { get; set; }
        public double PtChietKhau { get; set; }
        public string HthucThanhToan { get; set; }
        public List<KtdmDTO> ktdmDTOs { get; set; } = new List<KtdmDTO>();
    }
}
