using System.ComponentModel.DataAnnotations;

namespace WebAccountant.Models
{
    public class KtdmDTO
    {
        public string Matk { get; set; } = null!;
        public string Madm { get; set; } = null!;
        [Required(ErrorMessage = "The FirstName field is required"), StringLength(maximumLength: 200, MinimumLength = 4, ErrorMessage = "Không đủ kí tự")]
        public string? Tendm { get; set; }
        public string? Donvi { get; set; }
        [Range(0, int.MaxValue)]
        public int Soluong { get; set; }
        public double Dgban { get; set; }
        public double PtChietKhau { get; set; }
        public double PtThue { get; set; }
        public double TonTDv1 { get; set; }
        public int eId { get; set; }
    }
}
