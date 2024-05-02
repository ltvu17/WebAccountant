using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAccountant.Models
{
    public class AddToKTSCDTO
    {
        [Required(ErrorMessage = "Hãy điền khách hàng!")]
        public string Makh {  get; set; }
        public DateTime NgayCtu { get; set; }
        public DateTime NgayHToan {  get; set; }    
        public string SoCtu { get; set; }
        public double? PtChietKhau { get; set; }
        public string HthucThanhToan { get; set; }
        public List<KtdmDTO> ktdmDTOs { get; set; } = new List<KtdmDTO>();
    }
}
