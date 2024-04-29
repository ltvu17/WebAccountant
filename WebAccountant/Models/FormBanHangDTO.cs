using System.ComponentModel.DataAnnotations;

namespace WebAccountant.Models
{
    public class FormBanHangDTO
    {
        [Required(ErrorMessage = "Hãy điền khách hàng!")]
        public string Makh { get; set; }
        public DateTime NgayCtu { get; set; }
        public DateTime NgayHToan { get; set; }
        public string SoHoaDon { get; set; }
        public double PtChietKhau { get; set; }
        public string HthucThanhToan { get; set; }
        public List<KtdmDTO> ktdmDTOs { get; set; } = new List<KtdmDTO>();
    }
}
