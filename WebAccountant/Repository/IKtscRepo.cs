using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAccountant.Models;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtscRepo : IBaseRepo<Ktsc>
    {
        public Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHang();
        public Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHangTraLai();
        public Task<IEnumerable<PhieuMuaHangDTO>> GetAllDSPhieuMuaHangTraLai();
        public Task<bool> SavePhieuTraHangToDB(FormBanHangDTO item);
        public Task<IEnumerable<PhieuMuaHangDTO>> GetAllDSPhieuMuaHang();
        public Task<FormBanHangDTO> GetDetailPhieuBanHang(int id);
        public Task<AddToKTSCDTO> GetDetailPhieuMuaHang(int id);
        public Task<bool> UpdateDetailPhieuBanHang(FormBanHangDTO item);
        public Task<bool> UpdateDetailPhieuMuaHang(AddToKTSCDTO item);
        public Task<bool> RefundPackageSell(IEnumerable<double> sttSc);
        public Task<bool> DeletePhieuBanHang(int id);
        public Task<bool> DeletePhieuMuaHang(int id);
        public Task<EntityEntry<Ktsc>> AddPhieuThuTien(Ktsc entity);
        public Task<EntityEntry<Ktsc>> AddPhieuThuTienChoPhieuBan(int idPhieuBan);
    }
}
