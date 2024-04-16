using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using WebAccountant.DAOs;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository.Implement
{
    public class KtlctgRepo : IKtlctgRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public KtlctgRepo(UnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<EntityEntry<Ktlctg>> AddNew(string values)
        {
            var model = new Ktlctg();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            var result = await _unitOfWork.KTLCTGDAO.Add(model);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task Delete(string key)
        {
            var model = (await _unitOfWork.KTLCTGDAO.GetAll()).FirstOrDefault(item => item.Lctg == key);

            await _unitOfWork.KTLCTGDAO.RemoveEntity(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ktlctg>> GetAllAsync()
        {
            return await _unitOfWork.KTLCTGDAO.GetAll();
        }

        public async Task Update(string key, string values)
        {
            var model = (await _unitOfWork.KTLCTGDAO.GetAll()).FirstOrDefault(item => item.Lctg == key);
            if (model == null)
                return;

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            await _unitOfWork.SaveChangesAsync();
        }
        private void PopulateModel(Ktlctg model, IDictionary values)
        {
            string LCTG = nameof(Ktlctg.Lctg);
            string TENCTG = nameof(Ktlctg.Tenctg);
            string TKTHUE = nameof(Ktlctg.Tkthue);
            string CO_TKDUTKTHUE = nameof(Ktlctg.CoTkdutkthue);
            string CO_TSCHITIET = nameof(Ktlctg.CoTschitiet);
            string CO_VTHH = nameof(Ktlctg.CoVthh);
            string SR_HD = nameof(Ktlctg.SrHd);
            string LOAITIEN = nameof(Ktlctg.Loaitien);
            string SOCT = nameof(Ktlctg.Soct);
            string SO_HD = nameof(Ktlctg.SoHd);
            string MA_SUFIX = nameof(Ktlctg.MaSufix);
            string MA_PRIFIX = nameof(Ktlctg.MaPrifix);
            string CO_XUATKHO = nameof(Ktlctg.CoXuatkho);
            string NHIEU_HD = nameof(Ktlctg.NhieuHd);
            string MANHINH = nameof(Ktlctg.Manhinh);
            string TKNO = nameof(Ktlctg.Tkno);
            string TKCO = nameof(Ktlctg.Tkco);
            string VONGLAP = nameof(Ktlctg.Vonglap);
            string TK_TNK = nameof(Ktlctg.TkTnk);
            string DANHDAU = nameof(Ktlctg.Danhdau);
            string HAMINCHUNGTU = nameof(Ktlctg.Haminchungtu);
            string CO_MHUNC = nameof(Ktlctg.CoMhunc);
            string XK_DM = nameof(Ktlctg.XkDm);
            string NGUOIGD = nameof(Ktlctg.Nguoigd);
            string TDTVUNG = nameof(Ktlctg.TDtvung);
            string CO_BBCHOMUON = nameof(Ktlctg.CoBbchomuon);
            string CO_LONHAP = nameof(Ktlctg.CoLonhap);
            string TENWB = nameof(Ktlctg.Tenwb);
            string NHIEULIEN = nameof(Ktlctg.Nhieulien);
            string CO_CLTG = nameof(Ktlctg.CoCltg);
            string CO_HOIIN = nameof(Ktlctg.CoHoiin);
            string DIENGIAI = nameof(Ktlctg.Diengiai);
            string SODONG = nameof(Ktlctg.Sodong);
            string MATT = nameof(Ktlctg.Matt);
            string NHIEU_DV = nameof(Ktlctg.NhieuDv);
            string CO_DIENGIAI2 = nameof(Ktlctg.CoDiengiai2);
            string CO_CHIETKHAU = nameof(Ktlctg.CoChietkhau);
            string TKCLTG_LAI = nameof(Ktlctg.TkcltgLai);
            string TKCLTG_LO = nameof(Ktlctg.TkcltgLo);
            string CO_CHUYENKHO = nameof(Ktlctg.CoChuyenkho);
            string CO_TIENHANG = nameof(Ktlctg.CoTienhang);
            string CO_FORM_RIENG = nameof(Ktlctg.CoFormRieng);
            string CO_CK_TRUOC = nameof(Ktlctg.CoCkTruoc);
            string CO_DONVI_PHU = nameof(Ktlctg.CoDonviPhu);
            string CO_TENHH_IN = nameof(Ktlctg.CoTenhhIn);
            string CO_HTPHELIEU = nameof(Ktlctg.CoHtphelieu);
            string MS_KH = nameof(Ktlctg.MsKh);
            string HDVAT = nameof(Ktlctg.Hdvat);
            string BERONGGAP_HD = nameof(Ktlctg.BeronggapHd);
            string CO_DGNHAP = nameof(Ktlctg.CoDgnhap);
            string MADTPNNO = nameof(Ktlctg.Madtpnno);
            string MADTPNCO = nameof(Ktlctg.Madtpnco);
            string CO_TTTDB = nameof(Ktlctg.CoTttdb);
            string NHIEU_USER = nameof(Ktlctg.NhieuUser);
            string TRANGTHAI = nameof(Ktlctg.Trangthai);
            string CO_TK_XUAT = nameof(Ktlctg.CoTkXuat);
            string TK_XUAT = nameof(Ktlctg.TkXuat);
            string TK_GIAVON = nameof(Ktlctg.TkGiavon);
            string NHOMCHUNGTU = nameof(Ktlctg.Nhomchungtu);
            string NHOM_DSCOT = nameof(Ktlctg.NhomDscot);
            string TS_GTGT = nameof(Ktlctg.TsGtgt);
            string KIEU_CONGTY = nameof(Ktlctg.KieuCongty);
            string CO_CKTM = nameof(Ktlctg.CoCktm);
            string CO_CKTT = nameof(Ktlctg.CoCktt);
            string CO_LENHSX = nameof(Ktlctg.CoLenhsx);
            string CO_VC = nameof(Ktlctg.CoVc);
            string COT_GAP_XCH = nameof(Ktlctg.CotGapXch);
            string DSCOT_SHOW_EDIT = nameof(Ktlctg.DscotShowEdit);
            string KHM_HD = nameof(Ktlctg.KhmHd);
            string KIEU_NHAPPS = nameof(Ktlctg.KieuNhapps);
            string MA_HD = nameof(Ktlctg.MaHd);
            string PXK_OF_HDBR = nameof(Ktlctg.PxkOfHdbr);
            string SOCOT_CD_EDIT = nameof(Ktlctg.SocotCdEdit);
            string TK_CHIETKHAU = nameof(Ktlctg.TkChietkhau);
            string KIEU_CHUNGTU = nameof(Ktlctg.KieuChungtu);
            string TKDU_TKTHUE = nameof(Ktlctg.TkduTkthue);
            string CHUNGTU_COPY = nameof(Ktlctg.ChungtuCopy);
            string DSCOT_SHOW_NHAPPS = nameof(Ktlctg.DscotShowNhapps);
            string SAPXEPCHUNGTU = nameof(Ktlctg.Sapxepchungtu);
            string PT_CK = nameof(Ktlctg.PtCk);
            string KIEUTANGSOCT = nameof(Ktlctg.Kieutangsoct);
            string LCTG_PC = nameof(Ktlctg.LctgPc);
            string LCTG_PT = nameof(Ktlctg.LctgPt);
            string MA_CT = nameof(Ktlctg.MaCt);
            string MABOPHAN = nameof(Ktlctg.Mabophan);
            string SOKYTUSOCT = nameof(Ktlctg.Sokytusoct);

            if (values.Contains(LCTG))
            {
                model.Lctg = Convert.ToString(values[LCTG]);
            }

            if (values.Contains(TENCTG))
            {
                model.Tenctg = Convert.ToString(values[TENCTG]);
            }

            if (values.Contains(TKTHUE))
            {
                model.Tkthue = Convert.ToString(values[TKTHUE]);
            }

            if (values.Contains(CO_TKDUTKTHUE))
            {
                model.CoTkdutkthue = Convert.ToString(values[CO_TKDUTKTHUE]);
            }

            if (values.Contains(CO_TSCHITIET))
            {
                model.CoTschitiet = Convert.ToString(values[CO_TSCHITIET]);
            }

            if (values.Contains(CO_VTHH))
            {
                model.CoVthh = Convert.ToString(values[CO_VTHH]);
            }

            if (values.Contains(SR_HD))
            {
                model.SrHd = Convert.ToString(values[SR_HD]);
            }

            if (values.Contains(LOAITIEN))
            {
                model.Loaitien = Convert.ToString(values[LOAITIEN]);
            }

            if (values.Contains(SOCT))
            {
                model.Soct = Convert.ToString(values[SOCT]);
            }

            if (values.Contains(SO_HD))
            {
                model.SoHd = Convert.ToString(values[SO_HD]);
            }

            if (values.Contains(MA_SUFIX))
            {
                model.MaSufix = Convert.ToString(values[MA_SUFIX]);
            }

            if (values.Contains(MA_PRIFIX))
            {
                model.MaPrifix = Convert.ToString(values[MA_PRIFIX]);
            }

            if (values.Contains(CO_XUATKHO))
            {
                model.CoXuatkho = Convert.ToString(values[CO_XUATKHO]);
            }

            if (values.Contains(NHIEU_HD))
            {
                model.NhieuHd = Convert.ToString(values[NHIEU_HD]);
            }

            if (values.Contains(MANHINH))
            {
                model.Manhinh = Convert.ToString(values[MANHINH]);
            }

            if (values.Contains(TKNO))
            {
                model.Tkno = Convert.ToString(values[TKNO]);
            }

            if (values.Contains(TKCO))
            {
                model.Tkco = Convert.ToString(values[TKCO]);
            }

            if (values.Contains(VONGLAP))
            {
                model.Vonglap = Convert.ToString(values[VONGLAP]);
            }

            if (values.Contains(TK_TNK))
            {
                model.TkTnk = Convert.ToString(values[TK_TNK]);
            }

            if (values.Contains(DANHDAU))
            {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if (values.Contains(HAMINCHUNGTU))
            {
                model.Haminchungtu = Convert.ToString(values[HAMINCHUNGTU]);
            }

            if (values.Contains(CO_MHUNC))
            {
                model.CoMhunc = Convert.ToString(values[CO_MHUNC]);
            }

            if (values.Contains(XK_DM))
            {
                model.XkDm = Convert.ToString(values[XK_DM]);
            }

            if (values.Contains(NGUOIGD))
            {
                model.Nguoigd = Convert.ToString(values[NGUOIGD]);
            }

            if (values.Contains(TDTVUNG))
            {
                model.TDtvung = Convert.ToString(values[TDTVUNG]);
            }

            if (values.Contains(CO_BBCHOMUON))
            {
                model.CoBbchomuon = Convert.ToString(values[CO_BBCHOMUON]);
            }

            if (values.Contains(CO_LONHAP))
            {
                model.CoLonhap = Convert.ToString(values[CO_LONHAP]);
            }

            if (values.Contains(TENWB))
            {
                model.Tenwb = Convert.ToString(values[TENWB]);
            }

            if (values.Contains(NHIEULIEN))
            {
                model.Nhieulien = Convert.ToString(values[NHIEULIEN]);
            }

            if (values.Contains(CO_CLTG))
            {
                model.CoCltg = Convert.ToString(values[CO_CLTG]);
            }

            if (values.Contains(CO_HOIIN))
            {
                model.CoHoiin = Convert.ToString(values[CO_HOIIN]);
            }

            if (values.Contains(DIENGIAI))
            {
                model.Diengiai = Convert.ToString(values[DIENGIAI]);
            }

            if (values.Contains(SODONG))
            {
                model.Sodong = Convert.ToDouble(values[SODONG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MATT))
            {
                model.Matt = Convert.ToString(values[MATT]);
            }

            if (values.Contains(NHIEU_DV))
            {
                model.NhieuDv = Convert.ToString(values[NHIEU_DV]);
            }

            if (values.Contains(CO_DIENGIAI2))
            {
                model.CoDiengiai2 = Convert.ToString(values[CO_DIENGIAI2]);
            }

            if (values.Contains(CO_CHIETKHAU))
            {
                model.CoChietkhau = Convert.ToString(values[CO_CHIETKHAU]);
            }

            if (values.Contains(TKCLTG_LAI))
            {
                model.TkcltgLai = Convert.ToString(values[TKCLTG_LAI]);
            }

            if (values.Contains(TKCLTG_LO))
            {
                model.TkcltgLo = Convert.ToString(values[TKCLTG_LO]);
            }

            if (values.Contains(CO_CHUYENKHO))
            {
                model.CoChuyenkho = Convert.ToString(values[CO_CHUYENKHO]);
            }

            if (values.Contains(CO_TIENHANG))
            {
                model.CoTienhang = Convert.ToString(values[CO_TIENHANG]);
            }

            if (values.Contains(CO_FORM_RIENG))
            {
                model.CoFormRieng = Convert.ToString(values[CO_FORM_RIENG]);
            }

            if (values.Contains(CO_CK_TRUOC))
            {
                model.CoCkTruoc = Convert.ToString(values[CO_CK_TRUOC]);
            }

            if (values.Contains(CO_DONVI_PHU))
            {
                model.CoDonviPhu = Convert.ToString(values[CO_DONVI_PHU]);
            }

            if (values.Contains(CO_TENHH_IN))
            {
                model.CoTenhhIn = Convert.ToString(values[CO_TENHH_IN]);
            }

            if (values.Contains(CO_HTPHELIEU))
            {
                model.CoHtphelieu = Convert.ToString(values[CO_HTPHELIEU]);
            }

            if (values.Contains(MS_KH))
            {
                model.MsKh = Convert.ToString(values[MS_KH]);
            }

            if (values.Contains(HDVAT))
            {
                model.Hdvat = Convert.ToString(values[HDVAT]);
            }

            if (values.Contains(BERONGGAP_HD))
            {
                model.BeronggapHd = Convert.ToDouble(values[BERONGGAP_HD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(CO_DGNHAP))
            {
                model.CoDgnhap = Convert.ToString(values[CO_DGNHAP]);
            }

            if (values.Contains(MADTPNNO))
            {
                model.Madtpnno = Convert.ToString(values[MADTPNNO]);
            }

            if (values.Contains(MADTPNCO))
            {
                model.Madtpnco = Convert.ToString(values[MADTPNCO]);
            }

            if (values.Contains(CO_TTTDB))
            {
                model.CoTttdb = Convert.ToString(values[CO_TTTDB]);
            }

            if (values.Contains(NHIEU_USER))
            {
                model.NhieuUser = Convert.ToString(values[NHIEU_USER]);
            }

            if (values.Contains(TRANGTHAI))
            {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if (values.Contains(CO_TK_XUAT))
            {
                model.CoTkXuat = Convert.ToString(values[CO_TK_XUAT]);
            }

            if (values.Contains(TK_XUAT))
            {
                model.TkXuat = Convert.ToString(values[TK_XUAT]);
            }

            if (values.Contains(TK_GIAVON))
            {
                model.TkGiavon = Convert.ToString(values[TK_GIAVON]);
            }

            if (values.Contains(NHOMCHUNGTU))
            {
                model.Nhomchungtu = Convert.ToString(values[NHOMCHUNGTU]);
            }

            if (values.Contains(NHOM_DSCOT))
            {
                model.NhomDscot = Convert.ToString(values[NHOM_DSCOT]);
            }

            if (values.Contains(TS_GTGT))
            {
                model.TsGtgt = Convert.ToString(values[TS_GTGT]);
            }

            if (values.Contains(KIEU_CONGTY))
            {
                model.KieuCongty = Convert.ToString(values[KIEU_CONGTY]);
            }

            if (values.Contains(CO_CKTM))
            {
                model.CoCktm = Convert.ToString(values[CO_CKTM]);
            }

            if (values.Contains(CO_CKTT))
            {
                model.CoCktt = Convert.ToString(values[CO_CKTT]);
            }

            if (values.Contains(CO_LENHSX))
            {
                model.CoLenhsx = Convert.ToString(values[CO_LENHSX]);
            }

            if (values.Contains(CO_VC))
            {
                model.CoVc = Convert.ToString(values[CO_VC]);
            }

            if (values.Contains(COT_GAP_XCH))
            {
                model.CotGapXch = Convert.ToString(values[COT_GAP_XCH]);
            }

            if (values.Contains(DSCOT_SHOW_EDIT))
            {
                model.DscotShowEdit = Convert.ToString(values[DSCOT_SHOW_EDIT]);
            }

            if (values.Contains(KHM_HD))
            {
                model.KhmHd = Convert.ToString(values[KHM_HD]);
            }

            if (values.Contains(KIEU_NHAPPS))
            {
                model.KieuNhapps = Convert.ToString(values[KIEU_NHAPPS]);
            }

            if (values.Contains(MA_HD))
            {
                model.MaHd = Convert.ToString(values[MA_HD]);
            }

            if (values.Contains(PXK_OF_HDBR))
            {
                model.PxkOfHdbr = Convert.ToString(values[PXK_OF_HDBR]);
            }

            if (values.Contains(SOCOT_CD_EDIT))
            {
                model.SocotCdEdit = Convert.ToDouble(values[SOCOT_CD_EDIT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TK_CHIETKHAU))
            {
                model.TkChietkhau = Convert.ToString(values[TK_CHIETKHAU]);
            }

            if (values.Contains(KIEU_CHUNGTU))
            {
                model.KieuChungtu = Convert.ToString(values[KIEU_CHUNGTU]);
            }

            if (values.Contains(TKDU_TKTHUE))
            {
                model.TkduTkthue = Convert.ToString(values[TKDU_TKTHUE]);
            }

            if (values.Contains(CHUNGTU_COPY))
            {
                model.ChungtuCopy = Convert.ToString(values[CHUNGTU_COPY]);
            }

            if (values.Contains(DSCOT_SHOW_NHAPPS))
            {
                model.DscotShowNhapps = Convert.ToString(values[DSCOT_SHOW_NHAPPS]);
            }

            if (values.Contains(SAPXEPCHUNGTU))
            {
                model.Sapxepchungtu = Convert.ToDouble(values[SAPXEPCHUNGTU], CultureInfo.InvariantCulture);
            }

            if (values.Contains(PT_CK))
            {
                model.PtCk = Convert.ToDouble(values[PT_CK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(KIEUTANGSOCT))
            {
                model.Kieutangsoct = Convert.ToString(values[KIEUTANGSOCT]);
            }

            if (values.Contains(LCTG_PC))
            {
                model.LctgPc = Convert.ToString(values[LCTG_PC]);
            }

            if (values.Contains(LCTG_PT))
            {
                model.LctgPt = Convert.ToString(values[LCTG_PT]);
            }

            if (values.Contains(MA_CT))
            {
                model.MaCt = Convert.ToString(values[MA_CT]);
            }

            if (values.Contains(MABOPHAN))
            {
                model.Mabophan = Convert.ToString(values[MABOPHAN]);
            }

            if (values.Contains(SOKYTUSOCT))
            {
                model.Sokytusoct = Convert.ToDouble(values[SOKYTUSOCT], CultureInfo.InvariantCulture);
            }
        }
    }
}
