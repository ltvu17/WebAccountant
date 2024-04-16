using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebAccountant.ModelsBase;

namespace WebAccountant.Controllers
{
    [Route("api/[controller]/[action]")]
    public class KtscsController : Controller
    {
        private TIENHIEU2024Context _context;

        public KtscsController(TIENHIEU2024Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktscs = _context.Ktscs.Select(i => new {
                i.Lctg,
                i.SrHd,
                i.SoHd,
                i.NgayHd,
                i.Soct,
                i.SoPc,
                i.Ngayct,
                i.Diengiai,
                i.Tkno,
                i.Madtpnno,
                i.Maytcpno,
                i.Madmno,
                i.LoNhap,
                i.Tkco,
                i.Madtpnco,
                i.Maytcpco,
                i.Madmco,
                i.LoXuat,
                i.MaCt,
                i.Madtgt,
                i.Tendm,
                i.DonviCtu,
                i.Donvi,
                i.LuongCtu,
                i.Luong,
                i.Dgvnd,
                i.Ttvnd,
                i.PtCk,
                i.Chietkhau,
                i.Hdvat,
                i.Tkthue,
                i.TsGtgt,
                i.Thuevnd,
                i.TtvndTt,
                i.Mathang,
                i.Makh,
                i.Tenkh,
                i.MsDn,
                i.Diachi,
                i.DiachiNgd,
                i.Khachhang,
                i.Ghichu,
                i.NvBan,
                i.Dgvon,
                i.Gtvon,
                i.LaiGop,
                i.Tygia,
                i.Ttusd,
                i.Thueusd,
                i.TtusdTt,
                i.Soctgs,
                i.Ngayctgs,
                i.SttSc,
                i.DtNhan,
                i.DtXuat,
                i.Thang,
                i.SoHopdong,
                i.Mauser,
                i.Matttu,
                i.NgayDaoHan,
                i.Madvtt,
                i.Tendvtt,
                i.Tknhno,
                i.Tentknhno,
                i.Madvnt,
                i.Tendvnt,
                i.Tknhco,
                i.Tentknhco,
                i.Tenvung,
                i.Kyhieu,
                i.Mangd,
                i.Diengiai2,
                i.Dgusd,
                i.Tienhang,
                i.TenhhIn,
                i.Httt,
                i.Invoi,
                i.Masanpham,
                i.Dontrong,
                i.MaNvBan,
                i.SoctU,
                i.Col11,
                i.Col12,
                i.Col13,
                i.Danhdau,
                i.Trangthai,
                i.ChietkhauUsd,
                i.DgGc,
                i.DgVc,
                i.Hansudung,
                i.IdChungtu,
                i.KhmHd,
                i.Kxldg,
                i.Lenhsx,
                i.MaHd,
                i.MaHhGc,
                i.MaTiepThi,
                i.MaTt,
                i.MaVung,
                i.Manhom,
                i.Manhom1,
                i.Manhom2,
                i.Model,
                i.MsTm,
                i.NgayHopdongSc,
                i.NgayTt,
                i.Ngaylo,
                i.Nhacungcap,
                i.Nhasanxuat,
                i.Nhomkh,
                i.NoidungSc,
                i.SlGc,
                i.SoPt,
                i.Sokheuoc,
                i.SttTt,
                i.TenTiepThi,
                i.TenctSc,
                i.Tenytcpno,
                i.ThangN,
                i.Thueeur,
                i.TkChietkhau,
                i.TkXuatkho,
                i.TnkUsd,
                i.TnkVnd,
                i.TsNk,
                i.TtGc,
                i.TtVc,
                i.Tteur,
                i.Donvi1,
                i.Donvi2,
                i.HsqdDvt,
                i.Luong1,
                i.Luong2,
                i.Mabpsx,
                i.SttBt,
                i.Tendtgt,
                i.Imei,
                i.Madonhang,
                i.Barcode,
                i.MadonhangMua,
                i.Manhomdt1,
                i.Tennhomdt1,
                i.Chietkhau2,
                i.IdUpdate,
                i.PtCk2,
                i.IdNghiepvu,
                i.Machinhanh,
                i.SttSapxep,
                i.Guid,
                i.Thoigiannhap,
                i.Kyduyet,
                i.SoctN,
                i.Mamausac,
                i.Tenmausac,
                i.Dgmausac,
                i.Ttmausac
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "SttSc" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(ktscs, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Ktsc();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Ktscs.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.SttSc });
        }

        [HttpPut]
        public async Task<IActionResult> Put(double key, string values) {
            var model = await _context.Ktscs.FirstOrDefaultAsync(item => item.SttSc == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(double key) {
            var model = await _context.Ktscs.FirstOrDefaultAsync(item => item.SttSc == key);

            _context.Ktscs.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Ktsc model, IDictionary values) {
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

            if(values.Contains(LCTG)) {
                model.Lctg = Convert.ToString(values[LCTG]);
            }

            if(values.Contains(SR_HD)) {
                model.SrHd = Convert.ToString(values[SR_HD]);
            }

            if(values.Contains(SO_HD)) {
                model.SoHd = Convert.ToString(values[SO_HD]);
            }

            if(values.Contains(NGAY_HD)) {
                model.NgayHd = values[NGAY_HD] != null ? Convert.ToDateTime(values[NGAY_HD]) : (DateTime?)null;
            }

            if(values.Contains(SOCT)) {
                model.Soct = Convert.ToString(values[SOCT]);
            }

            if(values.Contains(SO_PC)) {
                model.SoPc = Convert.ToString(values[SO_PC]);
            }

            if(values.Contains(NGAYCT)) {
                model.Ngayct = values[NGAYCT] != null ? Convert.ToDateTime(values[NGAYCT]) : (DateTime?)null;
            }

            if(values.Contains(DIENGIAI)) {
                model.Diengiai = Convert.ToString(values[DIENGIAI]);
            }

            if(values.Contains(TKNO)) {
                model.Tkno = Convert.ToString(values[TKNO]);
            }

            if(values.Contains(MADTPNNO)) {
                model.Madtpnno = Convert.ToString(values[MADTPNNO]);
            }

            if(values.Contains(MAYTCPNO)) {
                model.Maytcpno = Convert.ToString(values[MAYTCPNO]);
            }

            if(values.Contains(MADMNO)) {
                model.Madmno = Convert.ToString(values[MADMNO]);
            }

            if(values.Contains(LO_NHAP)) {
                model.LoNhap = Convert.ToString(values[LO_NHAP]);
            }

            if(values.Contains(TKCO)) {
                model.Tkco = Convert.ToString(values[TKCO]);
            }

            if(values.Contains(MADTPNCO)) {
                model.Madtpnco = Convert.ToString(values[MADTPNCO]);
            }

            if(values.Contains(MAYTCPCO)) {
                model.Maytcpco = Convert.ToString(values[MAYTCPCO]);
            }

            if(values.Contains(MADMCO)) {
                model.Madmco = Convert.ToString(values[MADMCO]);
            }

            if(values.Contains(LO_XUAT)) {
                model.LoXuat = Convert.ToString(values[LO_XUAT]);
            }

            if(values.Contains(MA_CT)) {
                model.MaCt = Convert.ToString(values[MA_CT]);
            }

            if(values.Contains(MADTGT)) {
                model.Madtgt = Convert.ToString(values[MADTGT]);
            }

            if(values.Contains(TENDM)) {
                model.Tendm = Convert.ToString(values[TENDM]);
            }

            if(values.Contains(DONVI_CTU)) {
                model.DonviCtu = Convert.ToString(values[DONVI_CTU]);
            }

            if(values.Contains(DONVI)) {
                model.Donvi = Convert.ToString(values[DONVI]);
            }

            if(values.Contains(LUONG_CTU)) {
                model.LuongCtu = Convert.ToDouble(values[LUONG_CTU], CultureInfo.InvariantCulture);
            }

            if(values.Contains(LUONG)) {
                model.Luong = Convert.ToDouble(values[LUONG], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGVND)) {
                model.Dgvnd = Convert.ToDouble(values[DGVND], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTVND)) {
                model.Ttvnd = Convert.ToDouble(values[TTVND], CultureInfo.InvariantCulture);
            }

            if(values.Contains(PT_CK)) {
                model.PtCk = Convert.ToDouble(values[PT_CK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(CHIETKHAU)) {
                model.Chietkhau = Convert.ToDouble(values[CHIETKHAU], CultureInfo.InvariantCulture);
            }

            if(values.Contains(HDVAT)) {
                model.Hdvat = Convert.ToString(values[HDVAT]);
            }

            if(values.Contains(TKTHUE)) {
                model.Tkthue = Convert.ToString(values[TKTHUE]);
            }

            if(values.Contains(TS_GTGT)) {
                model.TsGtgt = Convert.ToString(values[TS_GTGT]);
            }

            if(values.Contains(THUEVND)) {
                model.Thuevnd = Convert.ToDouble(values[THUEVND], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTVND_TT)) {
                model.TtvndTt = Convert.ToDouble(values[TTVND_TT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MATHANG)) {
                model.Mathang = Convert.ToString(values[MATHANG]);
            }

            if(values.Contains(MAKH)) {
                model.Makh = Convert.ToString(values[MAKH]);
            }

            if(values.Contains(TENKH)) {
                model.Tenkh = Convert.ToString(values[TENKH]);
            }

            if(values.Contains(MS_DN)) {
                model.MsDn = Convert.ToString(values[MS_DN]);
            }

            if(values.Contains(DIACHI)) {
                model.Diachi = Convert.ToString(values[DIACHI]);
            }

            if(values.Contains(DIACHI_NGD)) {
                model.DiachiNgd = Convert.ToString(values[DIACHI_NGD]);
            }

            if(values.Contains(KHACHHANG)) {
                model.Khachhang = Convert.ToString(values[KHACHHANG]);
            }

            if(values.Contains(GHICHU)) {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if(values.Contains(NV_BAN)) {
                model.NvBan = Convert.ToString(values[NV_BAN]);
            }

            if(values.Contains(DGVON)) {
                model.Dgvon = Convert.ToDouble(values[DGVON], CultureInfo.InvariantCulture);
            }

            if(values.Contains(GTVON)) {
                model.Gtvon = Convert.ToDouble(values[GTVON], CultureInfo.InvariantCulture);
            }

            if(values.Contains(LAI_GOP)) {
                model.LaiGop = Convert.ToDouble(values[LAI_GOP], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TYGIA)) {
                model.Tygia = Convert.ToDouble(values[TYGIA], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTUSD)) {
                model.Ttusd = Convert.ToDouble(values[TTUSD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(THUEUSD)) {
                model.Thueusd = Convert.ToDouble(values[THUEUSD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTUSD_TT)) {
                model.TtusdTt = Convert.ToDouble(values[TTUSD_TT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(SOCTGS)) {
                model.Soctgs = Convert.ToString(values[SOCTGS]);
            }

            if(values.Contains(NGAYCTGS)) {
                model.Ngayctgs = values[NGAYCTGS] != null ? Convert.ToDateTime(values[NGAYCTGS]) : (DateTime?)null;
            }

            if(values.Contains(STT_SC)) {
                model.SttSc = Convert.ToDouble(values[STT_SC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DT_NHAN)) {
                model.DtNhan = Convert.ToString(values[DT_NHAN]);
            }

            if(values.Contains(DT_XUAT)) {
                model.DtXuat = Convert.ToString(values[DT_XUAT]);
            }

            if(values.Contains(THANG)) {
                model.Thang = Convert.ToDouble(values[THANG], CultureInfo.InvariantCulture);
            }

            if(values.Contains(SO_HOPDONG)) {
                model.SoHopdong = Convert.ToString(values[SO_HOPDONG]);
            }

            if(values.Contains(MAUSER)) {
                model.Mauser = Convert.ToString(values[MAUSER]);
            }

            if(values.Contains(MATTTU)) {
                model.Matttu = Convert.ToString(values[MATTTU]);
            }

            if(values.Contains(NGAY_DAO_HAN)) {
                model.NgayDaoHan = values[NGAY_DAO_HAN] != null ? Convert.ToDateTime(values[NGAY_DAO_HAN]) : (DateTime?)null;
            }

            if(values.Contains(MADVTT)) {
                model.Madvtt = Convert.ToString(values[MADVTT]);
            }

            if(values.Contains(TENDVTT)) {
                model.Tendvtt = Convert.ToString(values[TENDVTT]);
            }

            if(values.Contains(TKNHNO)) {
                model.Tknhno = Convert.ToString(values[TKNHNO]);
            }

            if(values.Contains(TENTKNHNO)) {
                model.Tentknhno = Convert.ToString(values[TENTKNHNO]);
            }

            if(values.Contains(MADVNT)) {
                model.Madvnt = Convert.ToString(values[MADVNT]);
            }

            if(values.Contains(TENDVNT)) {
                model.Tendvnt = Convert.ToString(values[TENDVNT]);
            }

            if(values.Contains(TKNHCO)) {
                model.Tknhco = Convert.ToString(values[TKNHCO]);
            }

            if(values.Contains(TENTKNHCO)) {
                model.Tentknhco = Convert.ToString(values[TENTKNHCO]);
            }

            if(values.Contains(TENVUNG)) {
                model.Tenvung = Convert.ToString(values[TENVUNG]);
            }

            if(values.Contains(KYHIEU)) {
                model.Kyhieu = Convert.ToString(values[KYHIEU]);
            }

            if(values.Contains(MANGD)) {
                model.Mangd = Convert.ToString(values[MANGD]);
            }

            if(values.Contains(DIENGIAI2)) {
                model.Diengiai2 = Convert.ToString(values[DIENGIAI2]);
            }

            if(values.Contains(DGUSD)) {
                model.Dgusd = Convert.ToDouble(values[DGUSD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TIENHANG)) {
                model.Tienhang = Convert.ToDouble(values[TIENHANG], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TENHH_IN)) {
                model.TenhhIn = Convert.ToString(values[TENHH_IN]);
            }

            if(values.Contains(HTTT)) {
                model.Httt = Convert.ToString(values[HTTT]);
            }

            if(values.Contains(INVOI)) {
                model.Invoi = Convert.ToString(values[INVOI]);
            }

            if(values.Contains(MASANPHAM)) {
                model.Masanpham = Convert.ToString(values[MASANPHAM]);
            }

            if(values.Contains(DONTRONG)) {
                model.Dontrong = Convert.ToDouble(values[DONTRONG], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MA_NV_BAN)) {
                model.MaNvBan = Convert.ToString(values[MA_NV_BAN]);
            }

            if(values.Contains(SOCT_U)) {
                model.SoctU = Convert.ToString(values[SOCT_U]);
            }

            if(values.Contains(COL11)) {
                model.Col11 = Convert.ToDouble(values[COL11], CultureInfo.InvariantCulture);
            }

            if(values.Contains(COL12)) {
                model.Col12 = Convert.ToDouble(values[COL12], CultureInfo.InvariantCulture);
            }

            if(values.Contains(COL13)) {
                model.Col13 = Convert.ToDouble(values[COL13], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DANHDAU)) {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if(values.Contains(TRANGTHAI)) {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if(values.Contains(CHIETKHAU_USD)) {
                model.ChietkhauUsd = Convert.ToDouble(values[CHIETKHAU_USD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DG_GC)) {
                model.DgGc = Convert.ToDouble(values[DG_GC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DG_VC)) {
                model.DgVc = Convert.ToDouble(values[DG_VC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(HANSUDUNG)) {
                model.Hansudung = values[HANSUDUNG] != null ? Convert.ToDateTime(values[HANSUDUNG]) : (DateTime?)null;
            }

            if(values.Contains(ID_CHUNGTU)) {
                model.IdChungtu = Convert.ToDouble(values[ID_CHUNGTU], CultureInfo.InvariantCulture);
            }

            if(values.Contains(KHM_HD)) {
                model.KhmHd = Convert.ToString(values[KHM_HD]);
            }

            if(values.Contains(KXLDG)) {
                model.Kxldg = Convert.ToString(values[KXLDG]);
            }

            if(values.Contains(LENHSX)) {
                model.Lenhsx = Convert.ToString(values[LENHSX]);
            }

            if(values.Contains(MA_HD)) {
                model.MaHd = Convert.ToString(values[MA_HD]);
            }

            if(values.Contains(MA_HH_GC)) {
                model.MaHhGc = Convert.ToString(values[MA_HH_GC]);
            }

            if(values.Contains(MA_TIEP_THI)) {
                model.MaTiepThi = Convert.ToString(values[MA_TIEP_THI]);
            }

            if(values.Contains(MA_TT)) {
                model.MaTt = Convert.ToString(values[MA_TT]);
            }

            if(values.Contains(MA_VUNG)) {
                model.MaVung = Convert.ToString(values[MA_VUNG]);
            }

            if(values.Contains(MANHOM)) {
                model.Manhom = Convert.ToString(values[MANHOM]);
            }

            if(values.Contains(MANHOM1)) {
                model.Manhom1 = Convert.ToString(values[MANHOM1]);
            }

            if(values.Contains(MANHOM2)) {
                model.Manhom2 = Convert.ToString(values[MANHOM2]);
            }

            if(values.Contains(MODEL)) {
                model.Model = Convert.ToString(values[MODEL]);
            }

            if(values.Contains(MS_TM)) {
                model.MsTm = Convert.ToString(values[MS_TM]);
            }

            if(values.Contains(NGAY_HOPDONG_SC)) {
                model.NgayHopdongSc = values[NGAY_HOPDONG_SC] != null ? Convert.ToDateTime(values[NGAY_HOPDONG_SC]) : (DateTime?)null;
            }

            if(values.Contains(NGAY_TT)) {
                model.NgayTt = values[NGAY_TT] != null ? Convert.ToDateTime(values[NGAY_TT]) : (DateTime?)null;
            }

            if(values.Contains(NGAYLO)) {
                model.Ngaylo = values[NGAYLO] != null ? Convert.ToDateTime(values[NGAYLO]) : (DateTime?)null;
            }

            if(values.Contains(NHACUNGCAP)) {
                model.Nhacungcap = Convert.ToString(values[NHACUNGCAP]);
            }

            if(values.Contains(NHASANXUAT)) {
                model.Nhasanxuat = Convert.ToString(values[NHASANXUAT]);
            }

            if(values.Contains(NHOMKH)) {
                model.Nhomkh = Convert.ToString(values[NHOMKH]);
            }

            if(values.Contains(NOIDUNG_SC)) {
                model.NoidungSc = Convert.ToString(values[NOIDUNG_SC]);
            }

            if(values.Contains(SL_GC)) {
                model.SlGc = Convert.ToDouble(values[SL_GC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(SO_PT)) {
                model.SoPt = Convert.ToString(values[SO_PT]);
            }

            if(values.Contains(SOKHEUOC)) {
                model.Sokheuoc = Convert.ToString(values[SOKHEUOC]);
            }

            if(values.Contains(STT_TT)) {
                model.SttTt = Convert.ToDouble(values[STT_TT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TEN_TIEP_THI)) {
                model.TenTiepThi = Convert.ToString(values[TEN_TIEP_THI]);
            }

            if(values.Contains(TENCT_SC)) {
                model.TenctSc = Convert.ToString(values[TENCT_SC]);
            }

            if(values.Contains(TENYTCPNO)) {
                model.Tenytcpno = Convert.ToString(values[TENYTCPNO]);
            }

            if(values.Contains(THANG_N)) {
                model.ThangN = Convert.ToDouble(values[THANG_N], CultureInfo.InvariantCulture);
            }

            if(values.Contains(THUEEUR)) {
                model.Thueeur = Convert.ToDouble(values[THUEEUR], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TK_CHIETKHAU)) {
                model.TkChietkhau = Convert.ToString(values[TK_CHIETKHAU]);
            }

            if(values.Contains(TK_XUATKHO)) {
                model.TkXuatkho = Convert.ToString(values[TK_XUATKHO]);
            }

            if(values.Contains(TNK_USD)) {
                model.TnkUsd = Convert.ToDouble(values[TNK_USD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TNK_VND)) {
                model.TnkVnd = Convert.ToDouble(values[TNK_VND], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TS_NK)) {
                model.TsNk = Convert.ToDouble(values[TS_NK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TT_GC)) {
                model.TtGc = Convert.ToDouble(values[TT_GC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TT_VC)) {
                model.TtVc = Convert.ToDouble(values[TT_VC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTEUR)) {
                model.Tteur = Convert.ToDouble(values[TTEUR], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DONVI1)) {
                model.Donvi1 = Convert.ToString(values[DONVI1]);
            }

            if(values.Contains(DONVI2)) {
                model.Donvi2 = Convert.ToString(values[DONVI2]);
            }

            if(values.Contains(HSQD_DVT)) {
                model.HsqdDvt = Convert.ToDouble(values[HSQD_DVT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(LUONG1)) {
                model.Luong1 = Convert.ToDouble(values[LUONG1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(LUONG2)) {
                model.Luong2 = Convert.ToDouble(values[LUONG2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MABPSX)) {
                model.Mabpsx = Convert.ToString(values[MABPSX]);
            }

            if(values.Contains(STT_BT)) {
                model.SttBt = Convert.ToDouble(values[STT_BT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TENDTGT)) {
                model.Tendtgt = Convert.ToString(values[TENDTGT]);
            }

            if(values.Contains(IMEI)) {
                model.Imei = Convert.ToString(values[IMEI]);
            }

            if(values.Contains(MADONHANG)) {
                model.Madonhang = Convert.ToString(values[MADONHANG]);
            }

            if(values.Contains(BARCODE)) {
                model.Barcode = Convert.ToString(values[BARCODE]);
            }

            if(values.Contains(MADONHANG_MUA)) {
                model.MadonhangMua = Convert.ToString(values[MADONHANG_MUA]);
            }

            if(values.Contains(MANHOMDT1)) {
                model.Manhomdt1 = Convert.ToString(values[MANHOMDT1]);
            }

            if(values.Contains(TENNHOMDT1)) {
                model.Tennhomdt1 = Convert.ToString(values[TENNHOMDT1]);
            }

            if(values.Contains(CHIETKHAU2)) {
                model.Chietkhau2 = Convert.ToDouble(values[CHIETKHAU2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(ID_UPDATE)) {
                model.IdUpdate = Convert.ToString(values[ID_UPDATE]);
            }

            if(values.Contains(PT_CK2)) {
                model.PtCk2 = Convert.ToDouble(values[PT_CK2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(ID_NGHIEPVU)) {
                model.IdNghiepvu = Convert.ToString(values[ID_NGHIEPVU]);
            }

            if(values.Contains(MACHINHANH)) {
                model.Machinhanh = Convert.ToString(values[MACHINHANH]);
            }

            if(values.Contains(STT_SAPXEP)) {
                model.SttSapxep = Convert.ToDouble(values[STT_SAPXEP], CultureInfo.InvariantCulture);
            }

            if(values.Contains(GUID)) {
                model.Guid = Convert.ToString(values[GUID]);
            }

            if(values.Contains(THOIGIANNHAP)) {
                model.Thoigiannhap = Convert.ToString(values[THOIGIANNHAP]);
            }

            if(values.Contains(KYDUYET)) {
                model.Kyduyet = Convert.ToString(values[KYDUYET]);
            }

            if(values.Contains(SOCT_N)) {
                model.SoctN = Convert.ToDouble(values[SOCT_N], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MAMAUSAC)) {
                model.Mamausac = Convert.ToString(values[MAMAUSAC]);
            }

            if(values.Contains(TENMAUSAC)) {
                model.Tenmausac = Convert.ToString(values[TENMAUSAC]);
            }

            if(values.Contains(DGMAUSAC)) {
                model.Dgmausac = Convert.ToDouble(values[DGMAUSAC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TTMAUSAC)) {
                model.Ttmausac = Convert.ToDouble(values[TTMAUSAC], CultureInfo.InvariantCulture);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}