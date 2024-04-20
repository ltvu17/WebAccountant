using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAccountant.Models;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtdmRepo : IBaseRepo<Ktdm>
    {
        public Task<IEnumerable<KtdmDTO>> GetAllKtdmDTO();
        public Task<IEnumerable<KtdmDTO>> UpdateKtdmDTO(string key, string values, List<KtdmDTO> oldCart);
        public Task<string> ExportPDF(IEnumerable<KtdmDTO> items);
    }
}
