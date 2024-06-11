using System.ComponentModel.DataAnnotations.Schema;

namespace WebAccountant.ModelsLogin
{
    public class UserKTSCColumn
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("KTSCColumn")]
        public int KTSCColumnId { get; set; }
        public KTSCColumn KTSCColumn { get; set; }
    }
}
