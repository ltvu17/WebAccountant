using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAccountant.Models;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtdmRepo : IBaseRepo<Ktdm>
    {
        public Task<IEnumerable<KtdmDTO>> GetAllKtdmDTO();
        public Task<bool> UpdateKTDM(Ktdm ktdm);
        public Task<Ktdm> GetKTDMByKey(string madm);
        public Task<IEnumerable<KtdmDTO>> UpdateKtdmDTO(string key, string values, List<KtdmDTO> oldCart);
        public Task<string> ExportPDF(AddToKTSCDTO item);
        public Task<string> ExportPDFPhieuBanHang(IEnumerable<PhieuBanHangDTO> items);
        public Task<string> ExportPDFPhieuMuaHang(IEnumerable<PhieuMuaHangDTO> items);
        public Task<bool> SaveCartToDB(FormBanHangDTO item);
        public Task<bool> SaveBuyingCartToDB(AddToKTSCDTO item);
    }
}
