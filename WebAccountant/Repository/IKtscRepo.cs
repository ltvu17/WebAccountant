﻿using WebAccountant.Models;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtscRepo : IBaseRepo<Ktsc>
    {
        public Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHang();
        public Task<IEnumerable<PhieuMuaHangDTO>> GetAllDSPhieuMuaHang();
        public Task<FormBanHangDTO> GetDetailPhieuBanHang(int id);
        public Task<bool> UpdateDetailPhieuBanHang(FormBanHangDTO item);
    }
}
