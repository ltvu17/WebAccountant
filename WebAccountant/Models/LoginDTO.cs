using System.ComponentModel.DataAnnotations;

namespace WebAccountant.Models
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string UserName { get; set; }
		[Required(ErrorMessage = "Trường bắt buộc nhập")]
		public string Password { get; set; }
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string DatabaseYear { get; set; } = "2024";
    }
}
