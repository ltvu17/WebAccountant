using System.ComponentModel.DataAnnotations.Schema;

namespace WebAccountant.ModelsLogin
{
    public class UserKTDMColumn
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("KTDMColumn")]
        public int KTDMColumnId { get; set; }
        public KTDMColumn KTDMColumn { get; set; }
        public int Width { get; set; } = 0;
    }
}
