using WebAccountant.Models;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtscRepo : IBaseRepo<Ktsc>
    {
        public Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHang();
        public Task<IEnumerable<PhieuMuaHangDTO>> GetAllDSPhieuMuaHang();
    }
}
