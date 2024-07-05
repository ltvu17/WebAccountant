using DevExpress.Data;
using DevExpress.Pdf.Native.BouncyCastle.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using WebAccountant.DAOs;
using WebAccountant.Models;
using WebAccountant.ModelsBase;
using static System.Net.WebRequestMethods;

namespace WebAccountant.Repository.Implement
{
    public class KtscRepo : IKtscRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public KtscRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<EntityEntry<Ktsc>> AddNew(Ktsc entity)
        {
            var result = await _unitOfWork.KTSCDAO.Add(entity);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task<EntityEntry<Ktsc>> AddPhieuThuTien(Ktsc entity)
        {
            var idChungTu = (await _unitOfWork.KTSCDAO.GetAll()).OrderBy(s => s.SttSapxep).LastOrDefault().IdChungtu + 1;
            entity.Lctg = "PTT";
            entity.SttSc = (await _unitOfWork.KTSCDAO.GetAll()).LastOrDefault().SttSc + 1;
            entity.SttBt = (await _unitOfWork.KTSCDAO.GetAll()).LastOrDefault().SttBt + 1;
            entity.IdChungtu = idChungTu;
            entity.SttSapxep = (await _unitOfWork.KTSCDAO.GetAll()).OrderBy(s => s.SttSapxep).LastOrDefault().SttSapxep + 1;
            entity.SoctN = idChungTu;
            entity.SoHd = "0000" + idChungTu;
            entity.Soct = "00000" + idChungTu;
            var result = await _unitOfWork.KTSCDAO.Add(entity);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task<EntityEntry<Ktsc>> AddPhieuThuTienChoPhieuBan(int idPhieuBan)
        {
            var phieuBan = (await GetAllDSPhieuBanHang()).Where(s=>s.id == idPhieuBan).FirstOrDefault();
            var ktsc = new Ktsc
            {
                Lctg = "PTT",
                SrHd = DateTime.UtcNow.Year.ToString(),
                SoHd = phieuBan.Soctu,
                Soct = phieuBan.Soctu,
                NgayHd = phieuBan.NgayCtu,
                Ngayct = phieuBan.NgayCtu,
                Diengiai = "Thu Tiền Khách Hàng",
                Tkno = "131",
                Madtpnno = phieuBan.MaKh,
                Madtpnco = "",
                Tkco = "5111",
                MaCt = "",
                LuongCtu = 0,
                Ttvnd = Double.Parse(phieuBan.ThanhTien),
                Hdvat = "R",
                Tkthue = "33311",
                Makh = phieuBan.MaKh,
                Tenkh = phieuBan.TenKh,
                MsDn = phieuBan.MsThue,
                Diachi = phieuBan.Diachi,
                DiachiNgd = phieuBan.Diachi,
                Dgvon = 0,
                Gtvon = 0,
                Tygia = 0,
                Ttusd = 0,
                Thueusd = 0,
                TtusdTt = 0,
                Ngayctgs = DateTime.UtcNow,
                SttSc = phieuBan.ktscs.LastOrDefault().SttSc+ 0.00001,
                Thang = DateTime.UtcNow.Month,
                Mauser = "QUANLY",
                Dgusd = 0,
                Tienhang = 0,
                Dontrong = 0,
                Col11 = 0,
                Col12 = 0,
                Col13 = 0,
                Trangthai = 0,
                ChietkhauUsd = 0,
                DgVc = 0,
                Model = "T",
                SlGc = 0,
                SttTt = 0,
                ThangN = DateTime.UtcNow.Month,
                Thueeur = 0,
                TkChietkhau = "5211",
                TkXuatkho = "1561",
                TnkUsd = 0,
                TnkVnd = 0,
                TsNk = 0,
                TtGc = 0,
                TtVc = 0,
                Tteur = 0,
                Mangd = phieuBan.MaKh,
                Luong1 = 0,
                Luong2 = 0,
                SttBt = phieuBan.ktscs.LastOrDefault().SttBt + 0.00001,
                Httt = phieuBan.ktscs.LastOrDefault().Httt,
                Chietkhau2 = 0,
                Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                PtCk2 = 0,
                IdNghiepvu = "TIENHANG",
                SttSapxep = phieuBan.ktscs.LastOrDefault().SttBt + 0.00001,
                Guid = Guid.NewGuid().ToString(),
                SoctN = phieuBan.ktscs.LastOrDefault().IdChungtu,
                Dgmausac = 0,
                Ttmausac = 0,
                MaNvBan = phieuBan.NhanVienBan,
            };
            var result = await _unitOfWork.KTSCDAO.Add(ktsc);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task Delete(string key)
        {
            var keyParse = Double.TryParse(key, out var valueParse);
            var model = new Ktsc();
            if (keyParse)
            {
                model = (await _unitOfWork.KTSCDAO.GetAll()).FirstOrDefault(item => item.SttSc == valueParse);
            }
            else
            {
                return;
            }
            if (model == null)
                return;
            await _unitOfWork.KTSCDAO.RemoveEntity(model);
            await _unitOfWork.SaveChangesAsync();
        }


        public async Task<bool> DeletePhieuBanHang(int id)
        {
            var list = new List<PhieuBanHangDTO>();
            var items = (await _unitOfWork.KTSCDAO.GetAll()).Where(s => s.Lctg == "HDBR" || s.Lctg == "PXK").OrderByDescending(s => s.Ngayct).GroupBy(i => new
            {
                i.SoHd,
                i.Tenkh,
                i.Ngayct
            }).ToList();
            var t = 0;
            foreach (var item in items)
            {
                var insertItem = new PhieuBanHangDTO();
                double tongtien = 0;
                double thanhTien = 0;
                double chietKhau = 0;
                double tongCk = 0;
                double khTratien = 0;
                var hthucthanhtoan = "Nợ";
                foreach (var i in item)
                {
                    tongtien += i.TtvndTt;
                    thanhTien += i.Ttvnd;
                    chietKhau += i.PtCk;
                    tongCk += i.Chietkhau;
                    hthucthanhtoan = i.Httt;
                    insertItem.ktscs.Add(i);
                }
                var key = item.FirstOrDefault();
                insertItem.id = t;
                insertItem.TongTien = tongtien.ToString();
                insertItem.HTThanhToan = hthucthanhtoan;
                insertItem.NgayCtu = (DateTime)key.Ngayct;
                insertItem.Soctu = key.Soct;
                insertItem.ThanhTien = thanhTien.ToString();
                insertItem.ckPhanTram = key.PtCk.ToString();
                insertItem.CkThanhTien = tongCk.ToString();
                insertItem.KhTraTien = khTratien.ToString();
                insertItem.MaKh = key.Makh;
                insertItem.TenKh = key.Tenkh;
                insertItem.Diachi = key.Diachi;
                list.Add(insertItem);
                t++;
            }
            var itemD = list.Where(s => s.id == id).FirstOrDefault();
            var ktscs = itemD.ktscs;
            foreach(var ktsc in ktscs)
            {
                await _unitOfWork.KTSCDAO.RemoveEntity(ktsc);
            }
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePhieuMuaHang(int id)
        {
            var list = new List<PhieuMuaHangDTO>();
            var items = (await _unitOfWork.KTSCDAO.GetAll()).Where(s => s.Lctg == "PNK").OrderByDescending(s => s.Ngayct).GroupBy(i => new
            {
                i.SoHd,
                i.Tenkh,
                i.Ngayct
            }).ToList();
            var t = 1;
            foreach (var item in items)
            {
                var insertItem = new PhieuMuaHangDTO();
                double tongtien = 0;
                double thanhTien = 0;
                double chietKhau = 0;
                double tongCk = 0;
                double khTratien = 0;
                var hthucthanhtoan = "Nợ";
                foreach (var i in item)
                {
                    tongtien += i.Ttvnd - i.Chietkhau + i.Thuevnd;
                    thanhTien += i.Ttvnd;
                    chietKhau += i.PtCk;
                    tongCk += i.Chietkhau;
                    hthucthanhtoan = i.Httt;
                    insertItem.ktscs.Add(i);
                }
                var key = item.FirstOrDefault();
                insertItem.id = t;
                insertItem.TongTien = tongtien.ToString();
                insertItem.NgayCtu = (DateTime)key.Ngayct;
                insertItem.Soctu = key.Soct;
                insertItem.HTThanhToan = hthucthanhtoan;
                insertItem.ThanhTien = thanhTien.ToString();
                insertItem.ckPhanTram = key.PtCk.ToString();
                insertItem.CkThanhTien = tongCk.ToString();
                insertItem.KhTraTien = khTratien.ToString();
                insertItem.MaKh = key.Makh;
                insertItem.TenKh = key.Tenkh;
                insertItem.Diachi = key.Diachi;
                list.Add(insertItem);
                t++;
            }

            var itemD = list.Where(s => s.id == id).FirstOrDefault();
            var ktscs = itemD.ktscs;
            foreach (var ktsc in ktscs)
            {
                await _unitOfWork.KTSCDAO.RemoveEntity(ktsc);
            }
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Ktsc>> GetAllAsync()
        {
            return await _unitOfWork.KTSCDAO.GetAll();
        }

        public async Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHang()
        {
            var list = new List<PhieuBanHangDTO>();
            var items = (await _unitOfWork.KTSCDAO.GetAll()).Where(s => s.Lctg == "HDBR" && !s.IdNghiepvu.Contains("GIAVON") && !s.IdNghiepvu.Contains("CHIETKHAU_HDBR") && !s.IdNghiepvu.Contains("VAT_RA")).OrderByDescending(s => s.Ngayct).GroupBy(i => new
            {
                i.SoHd,
                i.Tenkh,
                i.Ngayct
            }).ToList();
            var t = 0;
            foreach (var item in items)
            {
                var groupItem = item.Where(s => s.Lctg == "HDBR" && !s.Diengiai.Contains("Thuế GTGT đầu ra HĐ") && !s.IdNghiepvu.Contains("GIAVON") && !s.IdNghiepvu.Contains("CHIETKHAU_HDBR") && !s.IdNghiepvu.Contains("VAT_RA")
                                            && !s.Diengiai.Contains("Chiết khấu theo chứng từ")).ToList();
                var insertItem = new PhieuBanHangDTO();
                double tongtien = 0;
                double thanhTien = 0;
                double chietKhau = 0;
                double tongCk = 0;
                double khTratien = 0;
                var hthucthanhtoan = "Nợ";
                foreach (var i in groupItem)
                {
                    tongtien += i.TtvndTt;
                    thanhTien += i.Ttvnd;
                    chietKhau += i.PtCk;
                    tongCk += i.Chietkhau;
                    hthucthanhtoan = i.Httt;
                    insertItem.ktscs.Add(i);
                }
                var key = item.FirstOrDefault();
                insertItem.id = t;
                insertItem.TongTien = tongtien.ToString();
                insertItem.HTThanhToan = hthucthanhtoan;
                insertItem.NgayCtu = (DateTime)key.Ngayct;
                insertItem.Soctu = key.Soct;
                insertItem.ThanhTien = thanhTien.ToString();
                insertItem.ckPhanTram = key.PtCk.ToString();
                insertItem.CkThanhTien = tongCk.ToString();
                insertItem.KhTraTien = khTratien.ToString();
                insertItem.MaKh = key.Makh;
                insertItem.TenKh = key.Tenkh;
                insertItem.Diachi = key.Diachi;
                list.Add(insertItem);
                t++;
            }
            return list;
        }

        public async Task<IEnumerable<PhieuBanHangDTO>> GetAllDSPhieuBanHangTraLai()
        {
            var list = new List<PhieuBanHangDTO>();
            var items = (await _unitOfWork.KTSCDAO.GetAll()).Where(s => s.Lctg == "HTL").OrderByDescending(s => s.Ngayct).GroupBy(i => new
            {
                i.SoHd,
                i.Tenkh,
                i.Ngayct
            }).ToList();
            var t = 0;
            foreach (var item in items)
            {
                var groupItem = item.Where(s => s.Lctg == "HTL" && !s.Diengiai.Contains("Thuế GTGT đầu ra HĐ") && !s.IdNghiepvu.Contains("GIAVON") && !s.IdNghiepvu.Contains("CHIETKHAU_HDBR") && !s.IdNghiepvu.Contains("VAT_RA")
                                            && !s.Diengiai.Contains("Chiết khấu theo chứng từ")).ToList();
                var insertItem = new PhieuBanHangDTO();
                double tongtien = 0;
                double thanhTien = 0;
                double chietKhau = 0;
                double tongCk = 0;
                double khTratien = 0;
                var hthucthanhtoan = "Nợ";
                foreach (var i in groupItem)
                {
                    tongtien += i.TtvndTt;
                    thanhTien += i.Ttvnd;
                    chietKhau += i.PtCk;
                    tongCk += i.Chietkhau;
                    hthucthanhtoan = i.Httt;
                    insertItem.ktscs.Add(i);
                }
                var key = item.FirstOrDefault();
                insertItem.id = t;
                insertItem.TongTien = tongtien.ToString();
                insertItem.HTThanhToan = hthucthanhtoan;
                insertItem.NgayCtu = (DateTime)key.Ngayct;
                insertItem.Soctu = key.Soct;
                insertItem.ThanhTien = thanhTien.ToString();
                insertItem.ckPhanTram = key.PtCk.ToString();
                insertItem.CkThanhTien = tongCk.ToString();
                insertItem.KhTraTien = khTratien.ToString();
                insertItem.MaKh = key.Makh;
                insertItem.TenKh = key.Tenkh;
                insertItem.Diachi = key.Diachi;
                list.Add(insertItem);
                t++;
            }
            return list;
        }

        public async Task<IEnumerable<PhieuMuaHangDTO>> GetAllDSPhieuMuaHang()
        {
            var list = new List<PhieuMuaHangDTO>();
            var items = (await _unitOfWork.KTSCDAO.GetAll()).Where(s=>s.Lctg == "PNK").OrderByDescending(s => s.Ngayct).GroupBy(i => new
            {
                i.SoHd,
                i.Tenkh,
                i.Ngayct
            }).ToList();
            var t = 1;
            foreach (var item in items)
            {
                var groupItem = item.Where(s => s.Lctg == "PNK" && !s.Diengiai.Contains("Thuế GTGT mua vào HĐ") && !s.IdNghiepvu.Contains("CHIETKHAU") && !s.IdNghiepvu.Contains("VAT_PNK_PC")
                                            && !s.Diengiai.Contains("Chiết khấu theo chứng từ")).ToList();
                var insertItem = new PhieuMuaHangDTO();
                double tongtien = 0;
                double thanhTien = 0;
                double chietKhau = 0;
                double tongCk = 0;
                double khTratien = 0;
                var hthucthanhtoan = "Nợ";
                foreach (var i in groupItem)
                {
                    tongtien += i.Ttvnd - i.Chietkhau + i.Thuevnd;
                    thanhTien += i.Ttvnd;
                    chietKhau += i.PtCk;
                    tongCk += i.Chietkhau;
                    hthucthanhtoan = i.Httt;
                    insertItem.ktscs.Add(i);
                }
                var key = item.FirstOrDefault();
                insertItem.id = t;
                insertItem.TongTien = tongtien.ToString();
                insertItem.NgayCtu = (DateTime)key.Ngayct;
                insertItem.Soctu = key.Soct;
                insertItem.HTThanhToan = hthucthanhtoan;
                insertItem.ThanhTien = thanhTien.ToString();
                insertItem.ckPhanTram = key.PtCk.ToString();
                insertItem.CkThanhTien = tongCk.ToString();
                insertItem.KhTraTien = khTratien.ToString();
                insertItem.MaKh = key.Makh;
                insertItem.TenKh = key.Tenkh;
                insertItem.Diachi = key.Diachi;
                list.Add(insertItem);
                t++;
            }
            return list;
        }

        public async Task<FormBanHangDTO> GetDetailPhieuBanHang(int id)
        {
            var item = (await GetAllDSPhieuBanHang()).Where(s => s.id == id).FirstOrDefault();
            var ktscs = item.ktscs;
            var ktdmDTOs = new List<KtdmDTO>();
            var count = 1;
            foreach (var ktp in ktscs)
            {
                var ktdm = (await _unitOfWork.KTDMDao.Find(s => s.Madm == ktp.Madmco, 1, 1)).FirstOrDefault();
                ktdmDTOs.Add(new KtdmDTO()
                {
                    Madm = ktdm.Madm,
                    Matk = ktdm.Matk,
                    Dgban = ktp.Dgvnd,
                    Donvi = ktp.Donvi,
                    PtChietKhau = ktp.PtCk,
                    PtThue = Double.Parse(ktp.TsGtgt),
                    Soluong = (int)ktp.Luong,
                    Tendm = ktdm.Tendm,
                    TonTDv1 = ktdm.TonTDv1,
                    eId = count,
                });
                count++;
            }
            if (item == null) return new FormBanHangDTO();
            var returnForm = new FormBanHangDTO()
            {
                KhachHang = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.MaKh, 1, 1)).FirstOrDefault(),
                ktdmDTOs = ktdmDTOs,
                HthucThanhToan = ktscs.FirstOrDefault().Httt == "Nợ" ? "2" : "1",
                NgayCtu = (DateTime)ktscs.FirstOrDefault().Ngayct,
                NgayHToan = (DateTime)ktscs.FirstOrDefault().NgayHd,
                id = id,
                SoHoaDon = ktscs.FirstOrDefault().SoHd
            };
            return returnForm;
        }
        public async Task<AddToKTSCDTO> GetDetailPhieuMuaHang(int id)
        {
            var item = (await GetAllDSPhieuMuaHang()).Where(s => s.id == id).FirstOrDefault();
            var ktscs = item.ktscs;
            var ktdmDTOs = new List<KtdmDTO>();
            var count = 1;
            foreach (var ktp in ktscs)
            {
                var ktdm = (await _unitOfWork.KTDMDao.Find(s => s.Madm == ktp.Madmno, 1, 1)).FirstOrDefault();
                ktdmDTOs.Add(new KtdmDTO()
                {
                    Madm = ktdm.Madm,
                    Matk = ktdm.Matk,
                    Dgban = ktp.Dgvnd,
                    Donvi = ktp.Donvi,
                    PtChietKhau = ktp.PtCk,
                    PtThue = Double.Parse(ktp.TsGtgt),
                    Soluong = (int)ktp.Luong,
                    Tendm = ktdm.Tendm,
                    TonTDv1 = ktdm.TonTDv1,
                    eId = count,
                });
                count++;
            }
            if (item == null) return new AddToKTSCDTO();
            var returnForm = new AddToKTSCDTO()
            {
                KhachHang = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.MaKh, 1, 1)).FirstOrDefault(),
                ktdmDTOs = ktdmDTOs,
                HthucThanhToan = ktscs.FirstOrDefault().Httt == "Nợ" ? "2" : "1",
                NgayCtu = (DateTime)ktscs.FirstOrDefault().Ngayct,
                NgayHToan = (DateTime)ktscs.FirstOrDefault().NgayHd,
                id = id,
                SoCtu = ktscs.FirstOrDefault().SoHd
            };
            return returnForm;
        }

        public async Task<bool> RefundPackageSell(IEnumerable<double> sttSc)
        {
            var ktdms = new List<KtdmDTO>();
            var hinhthuctt = "Tiền Mặt";
            var makh = "";
            var manv = "";
            var newGuid = Guid.NewGuid();
            foreach (var item in sttSc)
            {
                var ktsc = (await _unitOfWork.KTSCDAO.Find(s => s.SttSc == item, 1, 1)).FirstOrDefault();
                if (ktsc == null) continue;
                var ktdmDTO = new KtdmDTO
                {
                    PtChietKhau = ktsc.PtCk,
                    ChietKhauThanhTien = ktsc.Chietkhau,
                    Dgban = ktsc.Dgvnd,
                    Soluong = Int32.Parse(ktsc.Luong.ToString()),
                    Donvi = ktsc.Donvi,
                    Madm = ktsc.Madmco,
                    PtThue = Double.Parse(ktsc.TsGtgt),
                    ThueThanhTien = ktsc.Thuevnd,
                    Tendm = ktsc.Tendm,
                    Matk = (await _unitOfWork.KTDMDao.Find(s=>s.Madm == ktsc.Madmco,1 ,1)).FirstOrDefault().Matk,
                    TonTDv1 = 0,
                    eId = 0
                };
                makh = ktsc.Makh;
                manv = ktsc.MaNvBan;
                hinhthuctt = ktsc.Httt;
                ktdms.Add(ktdmDTO);
            };
            if(ktdms.Count() > 0)
            {
                var formBanHangDTO = new FormBanHangDTO
                {
                    HthucThanhToan = hinhthuctt == "Tiền Mặt" ? "1" : "0",
                    NgayCtu = DateTime.Now,
                    NgayHToan = DateTime.Now,
                    Makh = makh,
                    MaNhanVien = manv,
                    
                    ktdmDTOs = ktdms,
                };
                await SavePhieuTraHangToDB(formBanHangDTO);
            }
            return true;
        }

        public async Task<bool> SavePhieuTraHangToDB(FormBanHangDTO item)
        {
            var items = item.ktdmDTOs.ToList();
            var newGuid = Guid.NewGuid();
            var customer = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.Makh, 1, 1)).FirstOrDefault();
            var models = (await _unitOfWork.KTDMDao.GetAll()).IntersectBy(items
                .Select(x => new { madm = x.Madm, matk = x.Matk }), y => new { madm = y.Madm, matk = y.Matk });
            if (customer != null && models.Count() > 0)
            {
                var modelForId = (await _unitOfWork.KTSCDAO.GetAll()).OrderBy(s => s.SttSapxep).LastOrDefault();
                var modelForSTT = (await _unitOfWork.KTSCDAO.GetAll()).OrderBy(x => x.SttSc).LastOrDefault();
                double IdChungtu = 1;
                double SttSapXep = 0;
                double stt = 0;
                if (modelForId != null)
                {
                    IdChungtu = modelForId.IdChungtu + 1;
                }
                var i = 1;
                var t = 1;
                double tongCK = 0;
                double tongThue = 0;
                foreach (var model in models)
                {
                    var modelDTO = items.FirstOrDefault(
                            x => x.Madm == model.Madm && x.Matk == x.Matk);
                    var Ttvnd = -(modelDTO.Soluong * modelDTO.Dgban);
                    var Giavon = -(modelDTO.Soluong * model.Dgban);
                    var Chietkhau = -(modelDTO.ChietKhauThanhTien);
                    var Thuevnd = -(modelDTO.ThueThanhTien);
                    tongCK += Chietkhau;
                    tongThue += Thuevnd;
                    if (modelForId != null)
                    {
                        SttSapXep = modelForId.SttSapxep + t;
                    }
                    else
                    {
                        SttSapXep = 1 + t;
                    }
                    if (modelForSTT != null)
                    {
                        stt = modelForSTT.SttSc + i;
                    }
                    else
                    {
                        stt = 1 + i;
                    }
                    var insertPhieuHang = new Ktsc()
                    {
                        Lctg = "HTL",
                        SrHd = DateTime.UtcNow.Year.ToString(),
                        SoHd = "0000" + IdChungtu,
                        Soct = "00000" + IdChungtu,
                        NgayHd = item.NgayHToan,
                        Ngayct = item.NgayCtu,
                        Diengiai = "DOANH THU",
                        Tkno = "131",
                        Madtpnno = customer.Madtpn,
                        Madtpnco = "",
                        Tkco = "5111",
                        MaCt = "",
                        Madmco = model.Madm,
                        Tendm = model.Tendm,
                        Donvi = model.Donvi,
                        LuongCtu = 0,
                        Luong = modelDTO.Soluong,
                        Dgvnd = modelDTO.Dgban,
                        Ttvnd = Ttvnd,
                        PtCk = modelDTO.PtChietKhau,
                        Chietkhau = Chietkhau,
                        Hdvat = "R",
                        Tkthue = "33311",
                        TsGtgt = modelDTO.PtThue.ToString(),
                        Thuevnd = Thuevnd,
                        TtvndTt = Ttvnd - Chietkhau + Thuevnd,
                        Makh = customer.Madtpn,
                        Tenkh = customer.Tendtpn,
                        MsDn = customer.MsDn,
                        Diachi = customer.Diachi,
                        DiachiNgd = customer.Diachi,
                        Dgvon = 0,
                        Gtvon = 0,
                        LaiGop = modelDTO.Soluong * modelDTO.Dgban,
                        Tygia = 0,
                        Ttusd = 0,
                        Thueusd = 0,
                        TtusdTt = 0,
                        Ngayctgs = DateTime.UtcNow,
                        SttSc = stt,
                        Thang = DateTime.UtcNow.Month,
                        Mauser = "QUANLY",
                        Dgusd = 0,
                        Tienhang = 0,
                        Dontrong = 0,
                        Col11 = 0,
                        Col12 = 0,
                        Col13 = 0,
                        Trangthai = 0,
                        ChietkhauUsd = 0,
                        DgGc = modelDTO.Soluong * modelDTO.Dgban,
                        DgVc = 0,
                        IdChungtu = IdChungtu,
                        Model = "T",
                        SlGc = 0,
                        SttTt = 0,
                        ThangN = DateTime.UtcNow.Month,
                        Thueeur = 0,
                        TkChietkhau = "5211",
                        TkXuatkho = "1561",
                        TnkUsd = 0,
                        TnkVnd = 0,
                        TsNk = 0,
                        TtGc = 0,
                        TtVc = 0,
                        Tteur = 0,
                        Mangd = customer.Madtpn,
                        HsqdDvt = modelDTO.Soluong,
                        Luong1 = 0,
                        Luong2 = 0,
                        SttBt = t,
                        Httt = item.HthucThanhToan == 1.ToString() ? "Tiền mặt" : "Nợ",
                        Chietkhau2 = 0,
                        Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                        PtCk2 = 0,
                        IdNghiepvu = "TIENHANG",
                        SttSapxep = stt,
                        Guid = newGuid.ToString(),
                        SoctN = IdChungtu,
                        Dgmausac = 0,
                        Ttmausac = 0,
                        MaNvBan = item.MaNhanVien
                    };
                    var insertPhieuXuat = new Ktsc()
                    {
                        Lctg = "PXK_TL",
                        SrHd = DateTime.UtcNow.Year.ToString(),
                        SoHd = "0000" + IdChungtu,
                        Soct = "00000" + IdChungtu,
                        NgayHd = item.NgayHToan,
                        Ngayct = item.NgayCtu,
                        Diengiai = "GIÁ VỐN",
                        Tkno = "632",
                        Madtpnno = customer.Madtpn,
                        Madtpnco = "",
                        Tkco = "1561",
                        MaCt = "",
                        Madmco = model.Madm,
                        Tendm = model.Tendm,
                        Donvi = model.Donvi,
                        LuongCtu = 0,
                        Luong = modelDTO.Soluong,
                        Dgvnd = model.Dgban,
                        Ttvnd = Giavon,
                        PtCk = 0,
                        Chietkhau = 0,
                        Hdvat = "",
                        Tkthue = "",
                        TsGtgt = "",
                        Thuevnd = 0,
                        TtvndTt = 0,
                        Makh = customer.Madtpn,
                        Tenkh = customer.Tendtpn,
                        MsDn = customer.MsDn,
                        Diachi = customer.Diachi,
                        DiachiNgd = customer.Diachi,
                        Dgvon = 0,
                        Gtvon = 0,
                        LaiGop = modelDTO.Soluong * modelDTO.Dgban,
                        Tygia = 0,
                        Ttusd = 0,
                        Thueusd = 0,
                        TtusdTt = 0,
                        Ngayctgs = DateTime.UtcNow,
                        SttSc = stt + 1,
                        Thang = DateTime.UtcNow.Month,
                        Mauser = "QUANLY",
                        Dgusd = 0,
                        Tienhang = 0,
                        Dontrong = 0,
                        Col11 = 0,
                        Col12 = 0,
                        Col13 = 0,
                        Trangthai = 0,
                        ChietkhauUsd = 0,
                        DgGc = modelDTO.Soluong * modelDTO.Dgban,
                        DgVc = 0,
                        IdChungtu = IdChungtu,
                        Model = "T",
                        SlGc = 0,
                        SttTt = 0,
                        ThangN = DateTime.UtcNow.Month,
                        Thueeur = 0,
                        Mangd = customer.Madtpn,
                        TkChietkhau = "521",
                        TkXuatkho = "1561",
                        TnkUsd = 0,
                        TnkVnd = 0,
                        TsNk = 0,
                        TtGc = 0,
                        TtVc = 0,
                        Tteur = 0,
                        HsqdDvt = modelDTO.Soluong,
                        Luong1 = 0,
                        Luong2 = 0,
                        SttBt = t,
                        Httt = item.HthucThanhToan == 1.ToString() ? "Tiền mặt" : "Nợ",
                        Chietkhau2 = 0,
                        Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                        PtCk2 = 0,
                        IdNghiepvu = "GIAVON",
                        SttSapxep = stt + 1,
                        Guid = newGuid.ToString(),
                        SoctN = IdChungtu,
                        Dgmausac = 0,
                        Ttmausac = 0,
                        MaNvBan = item.MaNhanVien
                    };
                    await _unitOfWork.KTSCDAO.Add(insertPhieuHang);
                    await _unitOfWork.KTSCDAO.Add(insertPhieuXuat);
                    i++;
                    i++;
                    t++;
                };
                var insertChietKhauPhieuHang = new Ktsc()
                {
                    Lctg = "HDBR",
                    SrHd = DateTime.UtcNow.Year.ToString(),
                    SoHd = "0000" + IdChungtu,
                    Soct = "00000" + IdChungtu,
                    NgayHd = item.NgayHToan,
                    Ngayct = item.NgayCtu,
                    Diengiai = "CHIẾT KHẤU",
                    Tkno = "131",
                    Madtpnno = customer.Madtpn,
                    Madtpnco = "",
                    Tkco = "5111",
                    MaCt = "",
                    Madmco = "",
                    Tendm = "",
                    Donvi = "",
                    LuongCtu = 0,
                    Luong = 0,
                    Dgvnd = 0,
                    Ttvnd = -tongCK,
                    PtCk = 0,
                    Chietkhau = 0,
                    Hdvat = "",
                    Tkthue = "",
                    TsGtgt = "",
                    Thuevnd = 0,
                    TtvndTt = 0,
                    Makh = customer.Madtpn,
                    Tenkh = customer.Tendtpn,
                    MsDn = customer.MsDn,
                    Diachi = customer.Diachi,
                    DiachiNgd = customer.Diachi,
                    Dgvon = 0,
                    Gtvon = 0,
                    LaiGop = 0,
                    Tygia = 0,
                    Ttusd = 0,
                    Thueusd = 0,
                    TtusdTt = 0,
                    Ngayctgs = DateTime.UtcNow,
                    SttSc = stt + 2,
                    Thang = DateTime.UtcNow.Month,
                    Mauser = "QUANLY",
                    Dgusd = 0,
                    Tienhang = 0,
                    Dontrong = 0,
                    Col11 = 0,
                    Col12 = 0,
                    Col13 = 0,
                    Trangthai = 0,
                    ChietkhauUsd = 0,
                    DgGc = 0,
                    DgVc = 0,
                    IdChungtu = IdChungtu,
                    Model = "T",
                    SlGc = 0,
                    SttTt = 0,
                    ThangN = DateTime.UtcNow.Month,
                    Thueeur = 0,
                    TkChietkhau = "5211",
                    TkXuatkho = "1561",
                    TnkUsd = 0,
                    TnkVnd = 0,
                    TsNk = 0,
                    TtGc = 0,
                    TtVc = 0,
                    Tteur = 0,
                    Mangd = customer.Madtpn,
                    HsqdDvt = 0,
                    Luong1 = 0,
                    Luong2 = 0,
                    SttBt = t,
                    Httt = item.HthucThanhToan == 1.ToString() ? "Thanh Toán Trực Tiếp" : "Nợ",
                    Chietkhau2 = 0,
                    Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                    PtCk2 = 0,
                    IdNghiepvu = "CHIETKHAU_HDBR",
                    SttSapxep = stt + 2,
                    Guid = newGuid.ToString(),
                    SoctN = IdChungtu,
                    Dgmausac = 0,
                    Ttmausac = 0,
                    MaNvBan = item.MaNhanVien
                };
                var insertThuePhieuHang = new Ktsc()
                {
                    Lctg = "HDBR",
                    SrHd = DateTime.UtcNow.Year.ToString(),
                    SoHd = "0000" + IdChungtu,
                    Soct = "00000" + IdChungtu,
                    NgayHd = item.NgayHToan,
                    Ngayct = item.NgayCtu,
                    Diengiai = "Thuế GTGT đầu ra HĐ: 00000" + IdChungtu + "," + item.NgayCtu.ToShortDateString(),
                    Tkno = "131",
                    Madtpnno = customer.Madtpn,
                    Madtpnco = "",
                    Tkco = "5111",
                    MaCt = "",
                    Madmco = "",
                    Tendm = "",
                    Donvi = "",
                    LuongCtu = 0,
                    Luong = 0,
                    Dgvnd = 0,
                    Ttvnd = tongThue,
                    PtCk = 0,
                    Chietkhau = 0,
                    Hdvat = "",
                    Tkthue = "",
                    TsGtgt = "",
                    Thuevnd = 0,
                    TtvndTt = 0,
                    Makh = customer.Madtpn,
                    Tenkh = customer.Tendtpn,
                    MsDn = customer.MsDn,
                    Diachi = customer.Diachi,
                    DiachiNgd = customer.Diachi,
                    Dgvon = 0,
                    Gtvon = 0,
                    LaiGop = 0,
                    Tygia = 0,
                    Ttusd = 0,
                    Thueusd = 0,
                    TtusdTt = 0,
                    Ngayctgs = DateTime.UtcNow,
                    SttSc = stt + 3,
                    Thang = DateTime.UtcNow.Month,
                    Mauser = "QUANLY",
                    Dgusd = 0,
                    Tienhang = 0,
                    Dontrong = 0,
                    Col11 = 0,
                    Col12 = 0,
                    Col13 = 0,
                    Trangthai = 0,
                    ChietkhauUsd = 0,
                    DgGc = 0,
                    DgVc = 0,
                    IdChungtu = IdChungtu,
                    Model = "T",
                    SlGc = 0,
                    SttTt = 0,
                    ThangN = DateTime.UtcNow.Month,
                    Thueeur = 0,
                    TkChietkhau = "5211",
                    TkXuatkho = "1561",
                    TnkUsd = 0,
                    TnkVnd = 0,
                    TsNk = 0,
                    TtGc = 0,
                    TtVc = 0,
                    Tteur = 0,
                    Mangd = customer.Madtpn,
                    HsqdDvt = 0,
                    Luong1 = 0,
                    Luong2 = 0,
                    SttBt = t + 1,
                    Httt = item.HthucThanhToan == 1.ToString() ? "Thanh Toán Trực Tiếp" : "Nợ",
                    Chietkhau2 = 0,
                    Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                    PtCk2 = 0,
                    IdNghiepvu = "VAT_RA",
                    SttSapxep = stt + 3,
                    Guid = newGuid.ToString(),
                    SoctN = IdChungtu,
                    Dgmausac = 0,
                    Ttmausac = 0,
                    MaNvBan = item.MaNhanVien
                };
                await _unitOfWork.KTSCDAO.Add(insertChietKhauPhieuHang);
                await _unitOfWork.KTSCDAO.Add(insertThuePhieuHang);
            }
            await _unitOfWork.SaveChangesAsync();
            return models.Any();
        }

        public async Task Update(string key, string values)
        {
            var keyParse = Double.TryParse(key, out var valueParse);
            var model = new Ktsc();
            if (keyParse)
            {
                model = (await _unitOfWork.KTSCDAO.GetAll()).FirstOrDefault(item => item.SttSc == valueParse);
            }
            else
            {
                return;
            }
            if (model == null)
                return;

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateDetailPhieuBanHang(FormBanHangDTO item)
        {
            var phieu = (await GetAllDSPhieuBanHang()).Where(s => s.id == item.id).FirstOrDefault();
            var ktscs = phieu.ktscs;
            var ktscMau = ktscs.FirstOrDefault();
            var pxk = (await _unitOfWork.KTSCDAO.Find(s => s.Lctg == "PXK" && s.SoHd == ktscMau.SoHd, int.MaxValue, 1));
            if (item.Makh != ktscs.FirstOrDefault().Makh)
            {
                var khachHang = (await _unitOfWork.KTDTPNDAO.Find(s=>s.Madtpn == item.Makh,1,1)).FirstOrDefault();
                var phieuChietKhau = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "CHIETKHAU_HDBR", 1, 1)).FirstOrDefault();
                var phieuThue = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "VAT_RA", 1, 1)).FirstOrDefault();
                if (khachHang != null)
                {
                /*                    foreach(var ktsc in ktscs)
                                    {
                                       *//* ktsc.Makh = khachHang.Madtpn;
                                        ktsc.Madtpnno = khachHang.Madtpn;
                                        ktsc.Tenkh = khachHang.Tendtpn;
                                        ktsc.MsDn = khachHang.MsDn;
                                        ktsc.Diachi = khachHang.Diachi;
                                        ktsc.DiachiNgd = khachHang.Diachi;
                                        ktsc.Mangd = khachHang.Madtpn;
                                        ktsc.Httt = ktscs.LastOrDefault().Httt;
                                        var phieuNhapKho = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "GIAVON" && s.Madmco == ktsc.Madmco, 1, 1)).FirstOrDefault();
                                        phieuNhapKho.Makh = khachHang.Madtpn;
                                        phieuNhapKho.Madtpnno = khachHang.Madtpn;
                                        phieuNhapKho.Tenkh = khachHang.Tendtpn;
                                        phieuNhapKho.MsDn = khachHang.MsDn;
                                        phieuNhapKho.Diachi = khachHang.Diachi;
                                        phieuNhapKho.DiachiNgd = khachHang.Diachi;
                                        phieuNhapKho.Mangd = khachHang.Madtpn;
                                        phieuNhapKho.Httt = ktscs.LastOrDefault().Httt;
                                        await _unitOfWork.KTSCDAO.Update(ktsc);
                                        await _unitOfWork.SaveChangesAsync();*//*
                                    }*/
                    phieuChietKhau.Makh = khachHang.Madtpn;
                    phieuChietKhau.Madtpnno = khachHang.Madtpn;
                    phieuChietKhau.Tenkh = khachHang.Tendtpn;
                    phieuChietKhau.MsDn = khachHang.MsDn;
                    phieuChietKhau.Diachi = khachHang.Diachi;
                    phieuChietKhau.DiachiNgd = khachHang.Diachi;
                    phieuChietKhau.Mangd = khachHang.Madtpn;
                    phieuChietKhau.Httt = ktscs.LastOrDefault().Httt;
                    phieuThue.Makh = khachHang.Madtpn;
                    phieuThue.Madtpnno = khachHang.Madtpn;
                    phieuThue.Tenkh = khachHang.Tendtpn;
                    phieuThue.MsDn = khachHang.MsDn;
                    phieuThue.Diachi = khachHang.Diachi;
                    phieuThue.DiachiNgd = khachHang.Diachi;
                    phieuThue.Mangd = khachHang.Madtpn;
                    phieuThue.Httt = ktscs.LastOrDefault().Httt;
                }
                else
                {
                    return false;
                }
            }
            await _unitOfWork.KTSCDAO.RemoveRange(ktscs);
            await _unitOfWork.KTSCDAO.RemoveRange(pxk);
            if (item.ktdmDTOs.Count > 0)
            {
                double tongCK = 0;
                double tongThue = 0;
                double i = 0.0001;
                double t = 0.0001;
                foreach (var ktdmDTO in item.ktdmDTOs)
                {
                    /*if (ktscs.Any(s=>s.Madmco == ktdmDTO.Madm))
                    {
                        var ktsc = ktscs.Where(s => s.Madmco == ktdmDTO.Madm).FirstOrDefault();
                        var ktscGiavon = (await _unitOfWork.KTSCDAO.Find(s => s.SttSc == (ktsc.SttSc + 1) && s.IdChungtu == ktsc.IdChungtu && s.IdNghiepvu == "GIAVON", 1, 1)).FirstOrDefault();
                        if (ktsc != null && ktscGiavon != null)
                        {
                            var Ttvnd = ktdmDTO.Soluong * ktdmDTO.Dgban;
                            var Chietkhau = ktdmDTO.Soluong * ktdmDTO.Dgban * (ktdmDTO.PtChietKhau / 100);
                            var Thuevnd = (Ttvnd - Chietkhau) * (ktdmDTO.PtThue / 100);
                            tongCK += Chietkhau;
                            tongThue += Thuevnd;
                            ktsc.Dgvnd = ktdmDTO.Dgban;
                            ktsc.Luong = ktdmDTO.Soluong;
                            ktsc.Ttvnd = Ttvnd;
                            ktsc.PtCk = ktdmDTO.PtChietKhau;
                            ktsc.TsGtgt = ktdmDTO.PtThue.ToString();
                            ktsc.Chietkhau = Chietkhau;
                            ktsc.Thuevnd = Thuevnd;
                            ktsc.TtvndTt = Ttvnd - Chietkhau + Thuevnd;
                            ktscGiavon.Luong = ktdmDTO.Soluong;
                            ktscGiavon.Ttvnd = ktdmDTO.Soluong * ktscGiavon.Dgvnd;
                            await _unitOfWork.KTSCDAO.Update(ktsc);
                            await _unitOfWork.KTSCDAO.Update(ktscGiavon);
                            await _unitOfWork.SaveChangesAsync();
                        }
                    }
                    else*/
                    {
                        var khachHang = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.Makh, 1, 1)).FirstOrDefault();
                        var model = (await _unitOfWork.KTDMDao.GetAll()).FirstOrDefault(
                            x => x.Madm == ktdmDTO.Madm && x.Matk == ktdmDTO.Matk);
                        var Ttvnd = ktdmDTO.Soluong * ktdmDTO.Dgban;
                        var Chietkhau = ktdmDTO.Soluong * ktdmDTO.Dgban * (ktdmDTO.PtChietKhau / 100);
                        var Thuevnd = (Ttvnd - Chietkhau) * (ktdmDTO.PtThue / 100);
                        tongCK += Chietkhau;
                        tongThue += Thuevnd;
                        double SttSapXep = 0;
                        double stt = 0;
                        if (ktscMau != null && model != null && khachHang != null)
                        {
                            SttSapXep = ktscMau.SttSapxep + t + t;
                            var Giavon = ktdmDTO.Soluong * model.Dgban;
                            stt = ktscMau.SttSc + i;
                            var insertPhieuHang = new Ktsc()
                            {
                                Lctg = "HDBR",
                                SrHd = DateTime.UtcNow.Year.ToString(),
                                SoHd = "0000" + ktscMau.IdChungtu,
                                Soct = "00000" + ktscMau.IdChungtu,
                                NgayHd = ktscMau.NgayHd,
                                Ngayct = ktscMau.Ngayct,
                                Diengiai = "DOANH THU",
                                Tkno = "131",
                                Madtpnno = khachHang.Madtpn,
                                Madtpnco = "",
                                Tkco = "5111",
                                MaCt = "",
                                Madmco = model.Madm,
                                Tendm = model.Tendm,
                                Donvi = model.Donvi,
                                LuongCtu = 0,
                                Luong = ktdmDTO.Soluong,
                                Dgvnd = ktdmDTO.Dgban,
                                Ttvnd = Ttvnd,
                                PtCk = ktdmDTO.PtChietKhau,
                                Chietkhau = Chietkhau,
                                Hdvat = "R",
                                Tkthue = "33311",
                                TsGtgt = ktdmDTO.PtThue.ToString(),
                                Thuevnd = Thuevnd,
                                TtvndTt = Ttvnd - Chietkhau + Thuevnd,
                                Makh = khachHang.Madtpn,
                                Tenkh = khachHang.Tendtpn,
                                MsDn = khachHang.MsDn,
                                Diachi = khachHang.Diachi,
                                DiachiNgd = khachHang.Diachi,
                                Dgvon = 0,
                                Gtvon = 0,
                                LaiGop = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                Tygia = 0,
                                Ttusd = 0,
                                Thueusd = 0,
                                TtusdTt = 0,
                                Ngayctgs = DateTime.UtcNow,
                                SttSc = stt,
                                Thang = ktscMau.Thang,
                                Mauser = "QUANLY",
                                Dgusd = 0,
                                Tienhang = 0,
                                Dontrong = 0,
                                Col11 = 0,
                                Col12 = 0,
                                Col13 = 0,
                                Trangthai = 0,
                                ChietkhauUsd = 0,
                                DgGc = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                DgVc = 0,
                                IdChungtu = ktscMau.IdChungtu,
                                Model = "T",
                                SlGc = 0,
                                SttTt = 0,
                                ThangN = ktscMau.ThangN,
                                Thueeur = 0,
                                TkChietkhau = "5211",
                                TkXuatkho = "1561",
                                TnkUsd = 0,
                                TnkVnd = 0,
                                TsNk = 0,
                                TtGc = 0,
                                TtVc = 0,
                                Tteur = 0,
                                Mangd = khachHang.Madtpn,
                                HsqdDvt = ktdmDTO.Soluong,
                                Luong1 = 0,
                                Luong2 = 0,
                                SttBt = t,
                                Httt = ktscMau.Httt,
                                Chietkhau2 = 0,
                                Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                                PtCk2 = 0,
                                IdNghiepvu = "TIENHANG",
                                SttSapxep = SttSapXep,
                                Guid = ktscMau.Guid,
                                SoctN = ktscMau.IdChungtu,
                                Dgmausac = 0,
                                Ttmausac = 0,
                            };
                            var insertPhieuXuat = new Ktsc()
                            {
                                Lctg = "PXK",
                                SrHd = DateTime.UtcNow.Year.ToString(),
                                SoHd = "0000" + ktscMau.IdChungtu,
                                Soct = "00000" + ktscMau.IdChungtu,
                                NgayHd = ktscMau.NgayHd,
                                Ngayct = ktscMau.Ngayct,
                                Diengiai = "GIÁ VỐN",
                                Tkno = "632",
                                Madtpnno = khachHang.Madtpn,
                                Madtpnco = "",
                                Tkco = "1561",
                                MaCt = "",
                                Madmco = model.Madm,
                                Tendm = model.Tendm,
                                Donvi = model.Donvi,
                                LuongCtu = 0,
                                Luong = ktdmDTO.Soluong,
                                Dgvnd = model.Dgban,
                                Ttvnd = Giavon,
                                PtCk = 0,
                                Chietkhau = 0,
                                Hdvat = "",
                                Tkthue = "",
                                TsGtgt = "",
                                Thuevnd = 0,
                                TtvndTt = 0,
                                Makh = khachHang.Madtpn,
                                Tenkh = khachHang.Tendtpn,
                                MsDn = khachHang.MsDn,
                                Diachi = khachHang.Diachi,
                                DiachiNgd = khachHang.Diachi,
                                Dgvon = 0,
                                Gtvon = 0,
                                LaiGop = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                Tygia = 0,
                                Ttusd = 0,
                                Thueusd = 0,
                                TtusdTt = 0,
                                Ngayctgs = DateTime.UtcNow,
                                SttSc = stt + 0.001,
                                Thang = ktscMau.Thang,
                                Mauser = "QUANLY",
                                Dgusd = 0,
                                Tienhang = 0,
                                Dontrong = 0,
                                Col11 = 0,
                                Col12 = 0,
                                Col13 = 0,
                                Trangthai = 0,
                                ChietkhauUsd = 0,
                                DgGc = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                DgVc = 0,
                                IdChungtu = ktscMau.IdChungtu,
                                Model = "T",
                                SlGc = 0,
                                SttTt = 0,
                                ThangN = ktscMau.ThangN,
                                Thueeur = 0,
                                Mangd = khachHang.Madtpn,
                                TkChietkhau = "521",
                                TkXuatkho = "1561",
                                TnkUsd = 0,
                                TnkVnd = 0,
                                TsNk = 0,
                                TtGc = 0,
                                TtVc = 0,
                                Tteur = 0,
                                HsqdDvt = ktdmDTO.Soluong,
                                Luong1 = 0,
                                Luong2 = 0,
                                SttBt = t,
                                Httt = ktscMau.Httt,
                                Chietkhau2 = 0,
                                Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                                PtCk2 = 0,
                                IdNghiepvu = "GIAVON",
                                SttSapxep = SttSapXep + 0.001,
                                Guid = ktscMau.Guid,
                                SoctN = ktscMau.IdChungtu,
                                Dgmausac = 0,
                                Ttmausac = 0,
                            };
                            await _unitOfWork.KTSCDAO.Add(insertPhieuHang);
                            await _unitOfWork.KTSCDAO.Add(insertPhieuXuat);
                            i += 0.0002;
                            t += 0.0001;
                        }

                    }
                }
                var phieuChietKhau = (await _unitOfWork.KTSCDAO.Find(s=>s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "CHIETKHAU_HDBR", 1,1)).FirstOrDefault();
                var phieuThue = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "VAT_RA", 1, 1)).FirstOrDefault();
                if (phieuChietKhau != null && phieuThue != null && tongCK > 0 && tongThue > 0)
                {
                    phieuChietKhau.Ttvnd = -tongCK;
                    phieuThue.Ttvnd = tongThue;
                    await _unitOfWork.KTSCDAO.Update(phieuChietKhau);
                    await _unitOfWork.KTSCDAO.Update(phieuThue);
                }
                await _unitOfWork.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> UpdateDetailPhieuMuaHang(AddToKTSCDTO item)
        {
            var phieu = (await GetAllDSPhieuMuaHang()).Where(s => s.id == item.id).FirstOrDefault();
            var ktscs = phieu.ktscs;
            var ktscMau = ktscs.FirstOrDefault();
            if (item.Makh != ktscs.FirstOrDefault().Makh)
            {
                var khachHang = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.Makh, 1, 1)).FirstOrDefault();
                var phieuChietKhau = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "CHIETKHAU", 1, 1)).FirstOrDefault();
                var phieuThue = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "VAT_PNK_PC", 1, 1)).FirstOrDefault();
                if (khachHang != null)
                {
/*                    foreach (var ktsc in ktscs)
                    {
                        ktsc.Khachhang = khachHang.Tendtpn;
                        ktsc.Makh = khachHang.Madtpn;
                        ktsc.Tenkh = khachHang.Tendtpn;
                        ktsc.MsDn = khachHang.MsDn;
                        ktsc.Diachi = khachHang.Diachi;
                        ktsc.DiachiNgd = khachHang.Diachi;
                        ktsc.Mangd = khachHang.Madtpn;
                        ktsc.Httt = ktscs.LastOrDefault().Httt;
                        await _unitOfWork.KTSCDAO.Update(ktsc);
                    }*/
                    phieuChietKhau.Khachhang = khachHang.Tendtpn;
                    phieuChietKhau.Makh = khachHang.Madtpn;
                    phieuChietKhau.Tenkh = khachHang.Tendtpn;
                    phieuChietKhau.MsDn = khachHang.MsDn;
                    phieuChietKhau.Diachi = khachHang.Diachi;
                    phieuChietKhau.DiachiNgd = khachHang.Diachi;
                    phieuChietKhau.Mangd = khachHang.Madtpn;
                    phieuChietKhau.Httt = ktscs.LastOrDefault().Httt;
                    phieuThue.Khachhang = khachHang.Tendtpn;
                    phieuThue.Makh = khachHang.Madtpn;
                    phieuThue.Tenkh = khachHang.Tendtpn;
                    phieuThue.MsDn = khachHang.MsDn;
                    phieuThue.Diachi = khachHang.Diachi;
                    phieuThue.DiachiNgd = khachHang.Diachi;
                    phieuThue.Mangd = khachHang.Madtpn;
                    phieuThue.Httt = ktscs.LastOrDefault().Httt;
                }
                else
                {
                    return false;
                }
            }
            await _unitOfWork.KTSCDAO.RemoveRange(ktscs);
            if (item.ktdmDTOs.Count > 0)
            {
                double tongCK = 0;
                double tongThue = 0;
                double i = 0.0001;
                double t = 0.0001;
                foreach (var ktdmDTO in item.ktdmDTOs)
                {
                   /* if (ktscs.Any(s => s.Madmno == ktdmDTO.Madm))
                    {
                        var ktsc = ktscs.Where(s => s.Madmno == ktdmDTO.Madm).FirstOrDefault();
                        if (ktsc != null)
                        {
                            var Ttvnd = ktdmDTO.Soluong * ktdmDTO.Dgban;
                            var Chietkhau = ktdmDTO.Soluong * ktdmDTO.Dgban * (ktdmDTO.PtChietKhau / 100);
                            var Thuevnd = (Ttvnd - Chietkhau) * (ktdmDTO.PtThue / 100);
                            tongCK += Chietkhau;
                            tongThue += Thuevnd;
                            ktsc.Dgvnd = ktdmDTO.Dgban;
                            ktsc.Luong = ktdmDTO.Soluong;
                            ktsc.Ttvnd = Ttvnd;
                            ktsc.PtCk = ktdmDTO.PtChietKhau;
                            ktsc.TsGtgt = ktdmDTO.PtThue.ToString();
                            ktsc.Chietkhau = Chietkhau;
                            ktsc.Thuevnd = Thuevnd;
                            ktsc.TtvndTt = Ttvnd - Chietkhau + Thuevnd;
                            await _unitOfWork.KTSCDAO.Update(ktsc);
                        }
                    }
                    else*/
                    {
                        var khachHang = (await _unitOfWork.KTDTPNDAO.Find(s => s.Madtpn == item.Makh, 1, 1)).FirstOrDefault();
                        var model = (await _unitOfWork.KTDMDao.GetAll()).FirstOrDefault(
                            x => x.Madm == ktdmDTO.Madm && x.Matk == ktdmDTO.Matk);
                        var Ttvnd = ktdmDTO.Soluong * ktdmDTO.Dgban;
                        var Chietkhau = ktdmDTO.Soluong * ktdmDTO.Dgban * (ktdmDTO.PtChietKhau / 100);
                        var Thuevnd = (Ttvnd - Chietkhau) * (ktdmDTO.PtThue / 100);
                        tongCK += Chietkhau;
                        tongThue += Thuevnd;
                        double SttSapXep = 0;
                        double stt = 0;
                        if (ktscMau != null && model != null && khachHang != null)
                        {
                            SttSapXep = ktscMau.SttSapxep + t + t;
                            var Giavon = ktdmDTO.Soluong * model.Dgban;
                            stt = ktscMau.SttSc + i;
                            var insertPhieuHang = new Ktsc()
                            {
                                Lctg = "PNK",
                                SrHd = DateTime.UtcNow.Year.ToString(),
                                SoHd = "0000" + ktscMau.IdChungtu,
                                Soct = "00000" + ktscMau.IdChungtu,
                                NgayHd = ktscMau.NgayHd,
                                Ngayct = ktscMau.Ngayct,
                                Diengiai = "NHAP KHO",
                                Tkno = "1561",
                                Madtpnno = "",
                                Madtpnco = khachHang.Madtpn,
                                Madmno = model.Madm,
                                Tkco = "331",
                                MaCt = "",
                                Tendm = model.Tendm,
                                Donvi = model.Donvi,
                                LuongCtu = 0,
                                Luong = ktdmDTO.Soluong,
                                Dgvnd = ktdmDTO.Dgban,
                                Ttvnd = Ttvnd,
                                PtCk = ktdmDTO.PtChietKhau,
                                Chietkhau = Chietkhau,
                                Hdvat = "R",
                                Tkthue = "33311",
                                Khachhang = khachHang.Tendtpn,
                                TsGtgt = ktdmDTO.PtThue.ToString(),
                                Thuevnd = Thuevnd,
                                TtvndTt = Ttvnd - Chietkhau + Thuevnd,
                                Makh = khachHang.Madtpn,
                                Tenkh = khachHang.Tendtpn,
                                MsDn = khachHang.MsDn,
                                Diachi = khachHang.Diachi,
                                DiachiNgd = khachHang.Diachi,
                                Dgvon = 0,
                                Gtvon = 0,
                                LaiGop = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                Tygia = 0,
                                Ttusd = 0,
                                Thueusd = 0,
                                TtusdTt = 0,
                                Ngayctgs = DateTime.UtcNow,
                                SttSc = stt,
                                Thang = ktscMau.Thang,
                                Mauser = "QUANLY",
                                Dgusd = 0,
                                Tienhang = 0,
                                Dontrong = 0,
                                Col11 = 0,
                                Col12 = 0,
                                Col13 = 0,
                                Trangthai = 0,
                                ChietkhauUsd = 0,
                                DgGc = ktdmDTO.Soluong * ktdmDTO.Dgban,
                                DgVc = 0,
                                IdChungtu = ktscMau.IdChungtu,
                                Model = "T",
                                SlGc = 0,
                                SttTt = 0,
                                ThangN = ktscMau.ThangN,
                                Thueeur = 0,
                                TkChietkhau = "",
                                TkXuatkho = "",
                                TnkUsd = 0,
                                TnkVnd = 0,
                                TsNk = 0,
                                TtGc = 0,
                                TtVc = 0,
                                Tteur = 0,
                                Mangd = khachHang.Madtpn,
                                HsqdDvt = ktdmDTO.Soluong,
                                Luong1 = 0,
                                Luong2 = 0,
                                SttBt = t,
                                Httt = ktscMau.Httt,
                                Chietkhau2 = 0,
                                Thoigiannhap = DateTime.UtcNow.AddHours(7).ToString(),
                                PtCk2 = 0,
                                IdNghiepvu = "TIENHANG",
                                SttSapxep = SttSapXep,
                                Guid = ktscMau.Guid,
                                SoctN = ktscMau.IdChungtu,
                                Dgmausac = 0,
                                Ttmausac = 0,
                            };
                            await _unitOfWork.KTSCDAO.Add(insertPhieuHang);
                            i += 0.0001;
                            t += 0.0001;
                        }

                    }
                }
                var phieuChietKhau = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "CHIETKHAU", 1, 1)).FirstOrDefault();
                var phieuThue = (await _unitOfWork.KTSCDAO.Find(s => s.Soct == ktscMau.Soct && s.Ngayct == ktscMau.Ngayct && s.IdNghiepvu == "VAT_PNK_PC", 1, 1)).FirstOrDefault();
                if (phieuChietKhau != null && phieuThue != null && tongCK > 0 && tongThue > 0)
                {
                    phieuChietKhau.Ttvnd = -tongCK;
                    phieuThue.Ttvnd = tongThue;
                    await _unitOfWork.KTSCDAO.Update(phieuChietKhau);
                    await _unitOfWork.KTSCDAO.Update(phieuThue);
                }
            }
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        private void PopulateModel(Ktsc model, IDictionary values)
        {
            string LCTG = nameof(Ktsc.Lctg);
            string SR_HD = nameof(Ktsc.SrHd);
            string SO_HD = nameof(Ktsc.SoHd);
            string NGAY_HD = nameof(Ktsc.NgayHd);
            string SOCT = nameof(Ktsc.Soct);
            string SO_PC = nameof(Ktsc.SoPc);
            string NGAYCT = nameof(Ktsc.Ngayct);
            string DIENGIAI = nameof(Ktsc.Diengiai);
            string TKNO = nameof(Ktsc.Tkno);
            string MADTPNNO = nameof(Ktsc.Madtpnno);
            string MAYTCPNO = nameof(Ktsc.Maytcpno);
            string MADMNO = nameof(Ktsc.Madmno);
            string LO_NHAP = nameof(Ktsc.LoNhap);
            string TKCO = nameof(Ktsc.Tkco);
            string MADTPNCO = nameof(Ktsc.Madtpnco);
            string MAYTCPCO = nameof(Ktsc.Maytcpco);
            string MADMCO = nameof(Ktsc.Madmco);
            string LO_XUAT = nameof(Ktsc.LoXuat);
            string MA_CT = nameof(Ktsc.MaCt);
            string MADTGT = nameof(Ktsc.Madtgt);
            string TENDM = nameof(Ktsc.Tendm);
            string DONVI_CTU = nameof(Ktsc.DonviCtu);
            string DONVI = nameof(Ktsc.Donvi);
            string LUONG_CTU = nameof(Ktsc.LuongCtu);
            string LUONG = nameof(Ktsc.Luong);
            string DGVND = nameof(Ktsc.Dgvnd);
            string TTVND = nameof(Ktsc.Ttvnd);
            string PT_CK = nameof(Ktsc.PtCk);
            string CHIETKHAU = nameof(Ktsc.Chietkhau);
            string HDVAT = nameof(Ktsc.Hdvat);
            string TKTHUE = nameof(Ktsc.Tkthue);
            string TS_GTGT = nameof(Ktsc.TsGtgt);
            string THUEVND = nameof(Ktsc.Thuevnd);
            string TTVND_TT = nameof(Ktsc.TtvndTt);
            string MATHANG = nameof(Ktsc.Mathang);
            string MAKH = nameof(Ktsc.Makh);
            string TENKH = nameof(Ktsc.Tenkh);
            string MS_DN = nameof(Ktsc.MsDn);
            string DIACHI = nameof(Ktsc.Diachi);
            string DIACHI_NGD = nameof(Ktsc.DiachiNgd);
            string KHACHHANG = nameof(Ktsc.Khachhang);
            string GHICHU = nameof(Ktsc.Ghichu);
            string NV_BAN = nameof(Ktsc.NvBan);
            string DGVON = nameof(Ktsc.Dgvon);
            string GTVON = nameof(Ktsc.Gtvon);
            string LAI_GOP = nameof(Ktsc.LaiGop);
            string TYGIA = nameof(Ktsc.Tygia);
            string TTUSD = nameof(Ktsc.Ttusd);
            string THUEUSD = nameof(Ktsc.Thueusd);
            string TTUSD_TT = nameof(Ktsc.TtusdTt);
            string SOCTGS = nameof(Ktsc.Soctgs);
            string NGAYCTGS = nameof(Ktsc.Ngayctgs);
            string STT_SC = nameof(Ktsc.SttSc);
            string DT_NHAN = nameof(Ktsc.DtNhan);
            string DT_XUAT = nameof(Ktsc.DtXuat);
            string THANG = nameof(Ktsc.Thang);
            string SO_HOPDONG = nameof(Ktsc.SoHopdong);
            string MAUSER = nameof(Ktsc.Mauser);
            string MATTTU = nameof(Ktsc.Matttu);
            string NGAY_DAO_HAN = nameof(Ktsc.NgayDaoHan);
            string MADVTT = nameof(Ktsc.Madvtt);
            string TENDVTT = nameof(Ktsc.Tendvtt);
            string TKNHNO = nameof(Ktsc.Tknhno);
            string TENTKNHNO = nameof(Ktsc.Tentknhno);
            string MADVNT = nameof(Ktsc.Madvnt);
            string TENDVNT = nameof(Ktsc.Tendvnt);
            string TKNHCO = nameof(Ktsc.Tknhco);
            string TENTKNHCO = nameof(Ktsc.Tentknhco);
            string TENVUNG = nameof(Ktsc.Tenvung);
            string KYHIEU = nameof(Ktsc.Kyhieu);
            string MANGD = nameof(Ktsc.Mangd);
            string DIENGIAI2 = nameof(Ktsc.Diengiai2);
            string DGUSD = nameof(Ktsc.Dgusd);
            string TIENHANG = nameof(Ktsc.Tienhang);
            string TENHH_IN = nameof(Ktsc.TenhhIn);
            string HTTT = nameof(Ktsc.Httt);
            string INVOI = nameof(Ktsc.Invoi);
            string MASANPHAM = nameof(Ktsc.Masanpham);
            string DONTRONG = nameof(Ktsc.Dontrong);
            string MA_NV_BAN = nameof(Ktsc.MaNvBan);
            string SOCT_U = nameof(Ktsc.SoctU);
            string COL11 = nameof(Ktsc.Col11);
            string COL12 = nameof(Ktsc.Col12);
            string COL13 = nameof(Ktsc.Col13);
            string DANHDAU = nameof(Ktsc.Danhdau);
            string TRANGTHAI = nameof(Ktsc.Trangthai);
            string CHIETKHAU_USD = nameof(Ktsc.ChietkhauUsd);
            string DG_GC = nameof(Ktsc.DgGc);
            string DG_VC = nameof(Ktsc.DgVc);
            string HANSUDUNG = nameof(Ktsc.Hansudung);
            string ID_CHUNGTU = nameof(Ktsc.IdChungtu);
            string KHM_HD = nameof(Ktsc.KhmHd);
            string KXLDG = nameof(Ktsc.Kxldg);
            string LENHSX = nameof(Ktsc.Lenhsx);
            string MA_HD = nameof(Ktsc.MaHd);
            string MA_HH_GC = nameof(Ktsc.MaHhGc);
            string MA_TIEP_THI = nameof(Ktsc.MaTiepThi);
            string MA_TT = nameof(Ktsc.MaTt);
            string MA_VUNG = nameof(Ktsc.MaVung);
            string MANHOM = nameof(Ktsc.Manhom);
            string MANHOM1 = nameof(Ktsc.Manhom1);
            string MANHOM2 = nameof(Ktsc.Manhom2);
            string MODEL = nameof(Ktsc.Model);
            string MS_TM = nameof(Ktsc.MsTm);
            string NGAY_HOPDONG_SC = nameof(Ktsc.NgayHopdongSc);
            string NGAY_TT = nameof(Ktsc.NgayTt);
            string NGAYLO = nameof(Ktsc.Ngaylo);
            string NHACUNGCAP = nameof(Ktsc.Nhacungcap);
            string NHASANXUAT = nameof(Ktsc.Nhasanxuat);
            string NHOMKH = nameof(Ktsc.Nhomkh);
            string NOIDUNG_SC = nameof(Ktsc.NoidungSc);
            string SL_GC = nameof(Ktsc.SlGc);
            string SO_PT = nameof(Ktsc.SoPt);
            string SOKHEUOC = nameof(Ktsc.Sokheuoc);
            string STT_TT = nameof(Ktsc.SttTt);
            string TEN_TIEP_THI = nameof(Ktsc.TenTiepThi);
            string TENCT_SC = nameof(Ktsc.TenctSc);
            string TENYTCPNO = nameof(Ktsc.Tenytcpno);
            string THANG_N = nameof(Ktsc.ThangN);
            string THUEEUR = nameof(Ktsc.Thueeur);
            string TK_CHIETKHAU = nameof(Ktsc.TkChietkhau);
            string TK_XUATKHO = nameof(Ktsc.TkXuatkho);
            string TNK_USD = nameof(Ktsc.TnkUsd);
            string TNK_VND = nameof(Ktsc.TnkVnd);
            string TS_NK = nameof(Ktsc.TsNk);
            string TT_GC = nameof(Ktsc.TtGc);
            string TT_VC = nameof(Ktsc.TtVc);
            string TTEUR = nameof(Ktsc.Tteur);
            string DONVI1 = nameof(Ktsc.Donvi1);
            string DONVI2 = nameof(Ktsc.Donvi2);
            string HSQD_DVT = nameof(Ktsc.HsqdDvt);
            string LUONG1 = nameof(Ktsc.Luong1);
            string LUONG2 = nameof(Ktsc.Luong2);
            string MABPSX = nameof(Ktsc.Mabpsx);
            string STT_BT = nameof(Ktsc.SttBt);
            string TENDTGT = nameof(Ktsc.Tendtgt);
            string IMEI = nameof(Ktsc.Imei);
            string MADONHANG = nameof(Ktsc.Madonhang);
            string BARCODE = nameof(Ktsc.Barcode);
            string MADONHANG_MUA = nameof(Ktsc.MadonhangMua);
            string MANHOMDT1 = nameof(Ktsc.Manhomdt1);
            string TENNHOMDT1 = nameof(Ktsc.Tennhomdt1);
            string CHIETKHAU2 = nameof(Ktsc.Chietkhau2);
            string ID_UPDATE = nameof(Ktsc.IdUpdate);
            string PT_CK2 = nameof(Ktsc.PtCk2);
            string ID_NGHIEPVU = nameof(Ktsc.IdNghiepvu);
            string MACHINHANH = nameof(Ktsc.Machinhanh);
            string STT_SAPXEP = nameof(Ktsc.SttSapxep);
            string GUID = nameof(Ktsc.Guid);
            string THOIGIANNHAP = nameof(Ktsc.Thoigiannhap);
            string KYDUYET = nameof(Ktsc.Kyduyet);
            string SOCT_N = nameof(Ktsc.SoctN);
            string MAMAUSAC = nameof(Ktsc.Mamausac);
            string TENMAUSAC = nameof(Ktsc.Tenmausac);
            string DGMAUSAC = nameof(Ktsc.Dgmausac);
            string TTMAUSAC = nameof(Ktsc.Ttmausac);

            if (values.Contains(LCTG))
            {
                model.Lctg = Convert.ToString(values[LCTG]);
            }

            if (values.Contains(SR_HD))
            {
                model.SrHd = Convert.ToString(values[SR_HD]);
            }

            if (values.Contains(SO_HD))
            {
                model.SoHd = Convert.ToString(values[SO_HD]);
            }

            if (values.Contains(NGAY_HD))
            {
                model.NgayHd = values[NGAY_HD] != null ? Convert.ToDateTime(values[NGAY_HD]) : (DateTime?)null;
            }

            if (values.Contains(SOCT))
            {
                model.Soct = Convert.ToString(values[SOCT]);
            }

            if (values.Contains(SO_PC))
            {
                model.SoPc = Convert.ToString(values[SO_PC]);
            }

            if (values.Contains(NGAYCT))
            {
                model.Ngayct = values[NGAYCT] != null ? Convert.ToDateTime(values[NGAYCT]) : (DateTime?)null;
            }

            if (values.Contains(DIENGIAI))
            {
                model.Diengiai = Convert.ToString(values[DIENGIAI]);
            }

            if (values.Contains(TKNO))
            {
                model.Tkno = Convert.ToString(values[TKNO]);
            }

            if (values.Contains(MADTPNNO))
            {
                model.Madtpnno = Convert.ToString(values[MADTPNNO]);
            }

            if (values.Contains(MAYTCPNO))
            {
                model.Maytcpno = Convert.ToString(values[MAYTCPNO]);
            }

            if (values.Contains(MADMNO))
            {
                model.Madmno = Convert.ToString(values[MADMNO]);
            }

            if (values.Contains(LO_NHAP))
            {
                model.LoNhap = Convert.ToString(values[LO_NHAP]);
            }

            if (values.Contains(TKCO))
            {
                model.Tkco = Convert.ToString(values[TKCO]);
            }

            if (values.Contains(MADTPNCO))
            {
                model.Madtpnco = Convert.ToString(values[MADTPNCO]);
            }

            if (values.Contains(MAYTCPCO))
            {
                model.Maytcpco = Convert.ToString(values[MAYTCPCO]);
            }

            if (values.Contains(MADMCO))
            {
                model.Madmco = Convert.ToString(values[MADMCO]);
            }

            if (values.Contains(LO_XUAT))
            {
                model.LoXuat = Convert.ToString(values[LO_XUAT]);
            }

            if (values.Contains(MA_CT))
            {
                model.MaCt = Convert.ToString(values[MA_CT]);
            }

            if (values.Contains(MADTGT))
            {
                model.Madtgt = Convert.ToString(values[MADTGT]);
            }

            if (values.Contains(TENDM))
            {
                model.Tendm = Convert.ToString(values[TENDM]);
            }

            if (values.Contains(DONVI_CTU))
            {
                model.DonviCtu = Convert.ToString(values[DONVI_CTU]);
            }

            if (values.Contains(DONVI))
            {
                model.Donvi = Convert.ToString(values[DONVI]);
            }

            if (values.Contains(LUONG_CTU))
            {
                model.LuongCtu = Convert.ToDouble(values[LUONG_CTU], CultureInfo.InvariantCulture);
            }

            if (values.Contains(LUONG))
            {
                model.Luong = Convert.ToDouble(values[LUONG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DGVND))
            {
                model.Dgvnd = Convert.ToDouble(values[DGVND], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTVND))
            {
                model.Ttvnd = Convert.ToDouble(values[TTVND], CultureInfo.InvariantCulture);
            }

            if (values.Contains(PT_CK))
            {
                model.PtCk = Convert.ToDouble(values[PT_CK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(CHIETKHAU))
            {
                model.Chietkhau = Convert.ToDouble(values[CHIETKHAU], CultureInfo.InvariantCulture);
            }

            if (values.Contains(HDVAT))
            {
                model.Hdvat = Convert.ToString(values[HDVAT]);
            }

            if (values.Contains(TKTHUE))
            {
                model.Tkthue = Convert.ToString(values[TKTHUE]);
            }

            if (values.Contains(TS_GTGT))
            {
                model.TsGtgt = Convert.ToString(values[TS_GTGT]);
            }

            if (values.Contains(THUEVND))
            {
                model.Thuevnd = Convert.ToDouble(values[THUEVND], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTVND_TT))
            {
                model.TtvndTt = Convert.ToDouble(values[TTVND_TT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MATHANG))
            {
                model.Mathang = Convert.ToString(values[MATHANG]);
            }

            if (values.Contains(MAKH))
            {
                model.Makh = Convert.ToString(values[MAKH]);
            }

            if (values.Contains(TENKH))
            {
                model.Tenkh = Convert.ToString(values[TENKH]);
            }

            if (values.Contains(MS_DN))
            {
                model.MsDn = Convert.ToString(values[MS_DN]);
            }

            if (values.Contains(DIACHI))
            {
                model.Diachi = Convert.ToString(values[DIACHI]);
            }

            if (values.Contains(DIACHI_NGD))
            {
                model.DiachiNgd = Convert.ToString(values[DIACHI_NGD]);
            }

            if (values.Contains(KHACHHANG))
            {
                model.Khachhang = Convert.ToString(values[KHACHHANG]);
            }

            if (values.Contains(GHICHU))
            {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if (values.Contains(NV_BAN))
            {
                model.NvBan = Convert.ToString(values[NV_BAN]);
            }

            if (values.Contains(DGVON))
            {
                model.Dgvon = Convert.ToDouble(values[DGVON], CultureInfo.InvariantCulture);
            }

            if (values.Contains(GTVON))
            {
                model.Gtvon = Convert.ToDouble(values[GTVON], CultureInfo.InvariantCulture);
            }

            if (values.Contains(LAI_GOP))
            {
                model.LaiGop = Convert.ToDouble(values[LAI_GOP], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TYGIA))
            {
                model.Tygia = Convert.ToDouble(values[TYGIA], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTUSD))
            {
                model.Ttusd = Convert.ToDouble(values[TTUSD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(THUEUSD))
            {
                model.Thueusd = Convert.ToDouble(values[THUEUSD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTUSD_TT))
            {
                model.TtusdTt = Convert.ToDouble(values[TTUSD_TT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(SOCTGS))
            {
                model.Soctgs = Convert.ToString(values[SOCTGS]);
            }

            if (values.Contains(NGAYCTGS))
            {
                model.Ngayctgs = values[NGAYCTGS] != null ? Convert.ToDateTime(values[NGAYCTGS]) : (DateTime?)null;
            }

            if (values.Contains(STT_SC))
            {
                model.SttSc = Convert.ToDouble(values[STT_SC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DT_NHAN))
            {
                model.DtNhan = Convert.ToString(values[DT_NHAN]);
            }

            if (values.Contains(DT_XUAT))
            {
                model.DtXuat = Convert.ToString(values[DT_XUAT]);
            }

            if (values.Contains(THANG))
            {
                model.Thang = Convert.ToDouble(values[THANG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(SO_HOPDONG))
            {
                model.SoHopdong = Convert.ToString(values[SO_HOPDONG]);
            }

            if (values.Contains(MAUSER))
            {
                model.Mauser = Convert.ToString(values[MAUSER]);
            }

            if (values.Contains(MATTTU))
            {
                model.Matttu = Convert.ToString(values[MATTTU]);
            }

            if (values.Contains(NGAY_DAO_HAN))
            {
                model.NgayDaoHan = values[NGAY_DAO_HAN] != null ? Convert.ToDateTime(values[NGAY_DAO_HAN]) : (DateTime?)null;
            }

            if (values.Contains(MADVTT))
            {
                model.Madvtt = Convert.ToString(values[MADVTT]);
            }

            if (values.Contains(TENDVTT))
            {
                model.Tendvtt = Convert.ToString(values[TENDVTT]);
            }

            if (values.Contains(TKNHNO))
            {
                model.Tknhno = Convert.ToString(values[TKNHNO]);
            }

            if (values.Contains(TENTKNHNO))
            {
                model.Tentknhno = Convert.ToString(values[TENTKNHNO]);
            }

            if (values.Contains(MADVNT))
            {
                model.Madvnt = Convert.ToString(values[MADVNT]);
            }

            if (values.Contains(TENDVNT))
            {
                model.Tendvnt = Convert.ToString(values[TENDVNT]);
            }

            if (values.Contains(TKNHCO))
            {
                model.Tknhco = Convert.ToString(values[TKNHCO]);
            }

            if (values.Contains(TENTKNHCO))
            {
                model.Tentknhco = Convert.ToString(values[TENTKNHCO]);
            }

            if (values.Contains(TENVUNG))
            {
                model.Tenvung = Convert.ToString(values[TENVUNG]);
            }

            if (values.Contains(KYHIEU))
            {
                model.Kyhieu = Convert.ToString(values[KYHIEU]);
            }

            if (values.Contains(MANGD))
            {
                model.Mangd = Convert.ToString(values[MANGD]);
            }

            if (values.Contains(DIENGIAI2))
            {
                model.Diengiai2 = Convert.ToString(values[DIENGIAI2]);
            }

            if (values.Contains(DGUSD))
            {
                model.Dgusd = Convert.ToDouble(values[DGUSD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TIENHANG))
            {
                model.Tienhang = Convert.ToDouble(values[TIENHANG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TENHH_IN))
            {
                model.TenhhIn = Convert.ToString(values[TENHH_IN]);
            }

            if (values.Contains(HTTT))
            {
                model.Httt = Convert.ToString(values[HTTT]);
            }

            if (values.Contains(INVOI))
            {
                model.Invoi = Convert.ToString(values[INVOI]);
            }

            if (values.Contains(MASANPHAM))
            {
                model.Masanpham = Convert.ToString(values[MASANPHAM]);
            }

            if (values.Contains(DONTRONG))
            {
                model.Dontrong = Convert.ToDouble(values[DONTRONG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MA_NV_BAN))
            {
                model.MaNvBan = Convert.ToString(values[MA_NV_BAN]);
            }

            if (values.Contains(SOCT_U))
            {
                model.SoctU = Convert.ToString(values[SOCT_U]);
            }

            if (values.Contains(COL11))
            {
                model.Col11 = Convert.ToDouble(values[COL11], CultureInfo.InvariantCulture);
            }

            if (values.Contains(COL12))
            {
                model.Col12 = Convert.ToDouble(values[COL12], CultureInfo.InvariantCulture);
            }

            if (values.Contains(COL13))
            {
                model.Col13 = Convert.ToDouble(values[COL13], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DANHDAU))
            {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if (values.Contains(TRANGTHAI))
            {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if (values.Contains(CHIETKHAU_USD))
            {
                model.ChietkhauUsd = Convert.ToDouble(values[CHIETKHAU_USD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DG_GC))
            {
                model.DgGc = Convert.ToDouble(values[DG_GC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DG_VC))
            {
                model.DgVc = Convert.ToDouble(values[DG_VC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(HANSUDUNG))
            {
                model.Hansudung = values[HANSUDUNG] != null ? Convert.ToDateTime(values[HANSUDUNG]) : (DateTime?)null;
            }

            if (values.Contains(ID_CHUNGTU))
            {
                model.IdChungtu = Convert.ToDouble(values[ID_CHUNGTU], CultureInfo.InvariantCulture);
            }

            if (values.Contains(KHM_HD))
            {
                model.KhmHd = Convert.ToString(values[KHM_HD]);
            }

            if (values.Contains(KXLDG))
            {
                model.Kxldg = Convert.ToString(values[KXLDG]);
            }

            if (values.Contains(LENHSX))
            {
                model.Lenhsx = Convert.ToString(values[LENHSX]);
            }

            if (values.Contains(MA_HD))
            {
                model.MaHd = Convert.ToString(values[MA_HD]);
            }

            if (values.Contains(MA_HH_GC))
            {
                model.MaHhGc = Convert.ToString(values[MA_HH_GC]);
            }

            if (values.Contains(MA_TIEP_THI))
            {
                model.MaTiepThi = Convert.ToString(values[MA_TIEP_THI]);
            }

            if (values.Contains(MA_TT))
            {
                model.MaTt = Convert.ToString(values[MA_TT]);
            }

            if (values.Contains(MA_VUNG))
            {
                model.MaVung = Convert.ToString(values[MA_VUNG]);
            }

            if (values.Contains(MANHOM))
            {
                model.Manhom = Convert.ToString(values[MANHOM]);
            }

            if (values.Contains(MANHOM1))
            {
                model.Manhom1 = Convert.ToString(values[MANHOM1]);
            }

            if (values.Contains(MANHOM2))
            {
                model.Manhom2 = Convert.ToString(values[MANHOM2]);
            }

            if (values.Contains(MODEL))
            {
                model.Model = Convert.ToString(values[MODEL]);
            }

            if (values.Contains(MS_TM))
            {
                model.MsTm = Convert.ToString(values[MS_TM]);
            }

            if (values.Contains(NGAY_HOPDONG_SC))
            {
                model.NgayHopdongSc = values[NGAY_HOPDONG_SC] != null ? Convert.ToDateTime(values[NGAY_HOPDONG_SC]) : (DateTime?)null;
            }

            if (values.Contains(NGAY_TT))
            {
                model.NgayTt = values[NGAY_TT] != null ? Convert.ToDateTime(values[NGAY_TT]) : (DateTime?)null;
            }

            if (values.Contains(NGAYLO))
            {
                model.Ngaylo = values[NGAYLO] != null ? Convert.ToDateTime(values[NGAYLO]) : (DateTime?)null;
            }

            if (values.Contains(NHACUNGCAP))
            {
                model.Nhacungcap = Convert.ToString(values[NHACUNGCAP]);
            }

            if (values.Contains(NHASANXUAT))
            {
                model.Nhasanxuat = Convert.ToString(values[NHASANXUAT]);
            }

            if (values.Contains(NHOMKH))
            {
                model.Nhomkh = Convert.ToString(values[NHOMKH]);
            }

            if (values.Contains(NOIDUNG_SC))
            {
                model.NoidungSc = Convert.ToString(values[NOIDUNG_SC]);
            }

            if (values.Contains(SL_GC))
            {
                model.SlGc = Convert.ToDouble(values[SL_GC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(SO_PT))
            {
                model.SoPt = Convert.ToString(values[SO_PT]);
            }

            if (values.Contains(SOKHEUOC))
            {
                model.Sokheuoc = Convert.ToString(values[SOKHEUOC]);
            }

            if (values.Contains(STT_TT))
            {
                model.SttTt = Convert.ToDouble(values[STT_TT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TEN_TIEP_THI))
            {
                model.TenTiepThi = Convert.ToString(values[TEN_TIEP_THI]);
            }

            if (values.Contains(TENCT_SC))
            {
                model.TenctSc = Convert.ToString(values[TENCT_SC]);
            }

            if (values.Contains(TENYTCPNO))
            {
                model.Tenytcpno = Convert.ToString(values[TENYTCPNO]);
            }

            if (values.Contains(THANG_N))
            {
                model.ThangN = Convert.ToDouble(values[THANG_N], CultureInfo.InvariantCulture);
            }

            if (values.Contains(THUEEUR))
            {
                model.Thueeur = Convert.ToDouble(values[THUEEUR], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TK_CHIETKHAU))
            {
                model.TkChietkhau = Convert.ToString(values[TK_CHIETKHAU]);
            }

            if (values.Contains(TK_XUATKHO))
            {
                model.TkXuatkho = Convert.ToString(values[TK_XUATKHO]);
            }

            if (values.Contains(TNK_USD))
            {
                model.TnkUsd = Convert.ToDouble(values[TNK_USD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TNK_VND))
            {
                model.TnkVnd = Convert.ToDouble(values[TNK_VND], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TS_NK))
            {
                model.TsNk = Convert.ToDouble(values[TS_NK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TT_GC))
            {
                model.TtGc = Convert.ToDouble(values[TT_GC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TT_VC))
            {
                model.TtVc = Convert.ToDouble(values[TT_VC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTEUR))
            {
                model.Tteur = Convert.ToDouble(values[TTEUR], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DONVI1))
            {
                model.Donvi1 = Convert.ToString(values[DONVI1]);
            }

            if (values.Contains(DONVI2))
            {
                model.Donvi2 = Convert.ToString(values[DONVI2]);
            }

            if (values.Contains(HSQD_DVT))
            {
                model.HsqdDvt = Convert.ToDouble(values[HSQD_DVT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(LUONG1))
            {
                model.Luong1 = Convert.ToDouble(values[LUONG1], CultureInfo.InvariantCulture);
            }

            if (values.Contains(LUONG2))
            {
                model.Luong2 = Convert.ToDouble(values[LUONG2], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MABPSX))
            {
                model.Mabpsx = Convert.ToString(values[MABPSX]);
            }

            if (values.Contains(STT_BT))
            {
                model.SttBt = Convert.ToDouble(values[STT_BT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TENDTGT))
            {
                model.Tendtgt = Convert.ToString(values[TENDTGT]);
            }

            if (values.Contains(IMEI))
            {
                model.Imei = Convert.ToString(values[IMEI]);
            }

            if (values.Contains(MADONHANG))
            {
                model.Madonhang = Convert.ToString(values[MADONHANG]);
            }

            if (values.Contains(BARCODE))
            {
                model.Barcode = Convert.ToString(values[BARCODE]);
            }

            if (values.Contains(MADONHANG_MUA))
            {
                model.MadonhangMua = Convert.ToString(values[MADONHANG_MUA]);
            }

            if (values.Contains(MANHOMDT1))
            {
                model.Manhomdt1 = Convert.ToString(values[MANHOMDT1]);
            }

            if (values.Contains(TENNHOMDT1))
            {
                model.Tennhomdt1 = Convert.ToString(values[TENNHOMDT1]);
            }

            if (values.Contains(CHIETKHAU2))
            {
                model.Chietkhau2 = Convert.ToDouble(values[CHIETKHAU2], CultureInfo.InvariantCulture);
            }

            if (values.Contains(ID_UPDATE))
            {
                model.IdUpdate = Convert.ToString(values[ID_UPDATE]);
            }

            if (values.Contains(PT_CK2))
            {
                model.PtCk2 = Convert.ToDouble(values[PT_CK2], CultureInfo.InvariantCulture);
            }

            if (values.Contains(ID_NGHIEPVU))
            {
                model.IdNghiepvu = Convert.ToString(values[ID_NGHIEPVU]);
            }

            if (values.Contains(MACHINHANH))
            {
                model.Machinhanh = Convert.ToString(values[MACHINHANH]);
            }

            if (values.Contains(STT_SAPXEP))
            {
                model.SttSapxep = Convert.ToDouble(values[STT_SAPXEP], CultureInfo.InvariantCulture);
            }

            if (values.Contains(GUID))
            {
                model.Guid = Convert.ToString(values[GUID]);
            }

            if (values.Contains(THOIGIANNHAP))
            {
                model.Thoigiannhap = Convert.ToString(values[THOIGIANNHAP]);
            }

            if (values.Contains(KYDUYET))
            {
                model.Kyduyet = Convert.ToString(values[KYDUYET]);
            }

            if (values.Contains(SOCT_N))
            {
                model.SoctN = Convert.ToDouble(values[SOCT_N], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MAMAUSAC))
            {
                model.Mamausac = Convert.ToString(values[MAMAUSAC]);
            }

            if (values.Contains(TENMAUSAC))
            {
                model.Tenmausac = Convert.ToString(values[TENMAUSAC]);
            }

            if (values.Contains(DGMAUSAC))
            {
                model.Dgmausac = Convert.ToDouble(values[DGMAUSAC], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TTMAUSAC))
            {
                model.Ttmausac = Convert.ToDouble(values[TTMAUSAC], CultureInfo.InvariantCulture);
            }
        }
    }
}
