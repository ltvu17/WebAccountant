namespace WebAccountant.Models
{
    public class AddToKTSCDTO
    {
       public string Makh {  get; set; }
        public List<KtdmDTO> ktdmDTOs { get; set; } = new List<KtdmDTO>();
    }
}
