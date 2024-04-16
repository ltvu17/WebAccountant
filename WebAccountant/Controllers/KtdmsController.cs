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
    public class KtdmsController : Controller
    {
        private TIENHIEU2024Context _context;

        public KtdmsController(TIENHIEU2024Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktdms = _context.Ktdms.Select(i => new {
                i.Matk,
                i.Madm,
                i.Tendm,
                i.Manhom,
                i.Tennhom,
                i.Kyhieu,
                i.Donvi,
                i.Lo,
                i.Ngaylo,
                i.Hansudung,
                i.Nhacungcap,
                i.Nhasanxuat,
                i.Ptchietkhau,
                i.Thuesuat,
                i.Dgxuat,
                i.TonT,
                i.VndtonT,
                i.NhapT,
                i.VndnhapT,
                i.XuatT,
                i.VndxuatT,
                i.TonCk,
                i.VndtonCk,
                i.Danhdau,
                i.Dgban,
                i.Dgban1,
                i.Dgban2,
                i.Dgban3,
                i.Dgban4,
                i.Donvi1,
                i.Donvi2,
                i.Donvi3,
                i.Hsqd1,
                i.Hsqd2,
                i.Hsqd3,
                i.UsdtonT,
                i.UsdnhapT,
                i.UsdxuatT,
                i.UsdtonCk,
                i.Dgusd,
                i.Dgnhap1,
                i.Dgnhap2,
                i.Dgnhap3,
                i.Dgnhap4,
                i.Dgnhap5,
                i.Trangthai,
                i.Dgnhap,
                i.DgChuyenkho,
                i.DgCktm,
                i.DgVc,
                i.DmCktm,
                i.Gioihanton,
                i.MadmMe,
                i.Manhom1,
                i.Manhom2,
                i.Manhomtp,
                i.Model,
                i.SoDdh,
                i.TenDdh,
                i.TendmMe,
                i.Tennhom1,
                i.Tennhom2,
                i.Tennhomtp,
                i.TgCktm,
                i.TkChietkhau,
                i.TkDoanhthu,
                i.TkGiavon,
                i.TkTralai,
                i.TyleOfNhom,
                i.NhapTDv1,
                i.NhapTDv2,
                i.TonCkDv1,
                i.TonCkDv2,
                i.TonTDv1,
                i.TonTDv2,
                i.XuatTDv1,
                i.XuatTDv2,
                i.Nhomck,
                i.Makho,
                i.Mavach,
                i.GioihantonMax,
                i.IdUpdate,
                i.Tendm2,
                i.DgbanGanNhat,
                i.DgmuaGanNhat,
                i.Ghichu,
                i.NgaybanGanNhat,
                i.NgaymuaGanNhat,
                i.Quycach,
                i.Songaysudung
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Madm", "Matk" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(ktdms, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Ktdm();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Ktdms.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Madm, result.Entity.Matk });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyMadm = Convert.ToString(keys["Madm"]);
            var keyMatk = Convert.ToString(keys["Matk"]);
            var model = await _context.Ktdms.FirstOrDefaultAsync(item =>
                            item.Madm == keyMadm && 
                            item.Matk == keyMatk);
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
        public async Task Delete(string key) {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyMadm = Convert.ToString(keys["Madm"]);
            var keyMatk = Convert.ToString(keys["Matk"]);
            var model = await _context.Ktdms.FirstOrDefaultAsync(item =>
                            item.Madm == keyMadm && 
                            item.Matk == keyMatk);

            _context.Ktdms.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Ktdm model, IDictionary values) {
            string MATK = nameof(Ktdm.Matk);
            string MADM = nameof(Ktdm.Madm);
            string TENDM = nameof(Ktdm.Tendm);
            string MANHOM = nameof(Ktdm.Manhom);
            string TENNHOM = nameof(Ktdm.Tennhom);
            string KYHIEU = nameof(Ktdm.Kyhieu);
            string DONVI = nameof(Ktdm.Donvi);
            string LO = nameof(Ktdm.Lo);
            string NGAYLO = nameof(Ktdm.Ngaylo);
            string HANSUDUNG = nameof(Ktdm.Hansudung);
            string NHACUNGCAP = nameof(Ktdm.Nhacungcap);
            string NHASANXUAT = nameof(Ktdm.Nhasanxuat);
            string PTCHIETKHAU = nameof(Ktdm.Ptchietkhau);
            string THUESUAT = nameof(Ktdm.Thuesuat);
            string DGXUAT = nameof(Ktdm.Dgxuat);
            string TON_T = nameof(Ktdm.TonT);
            string VNDTON_T = nameof(Ktdm.VndtonT);
            string NHAP_T = nameof(Ktdm.NhapT);
            string VNDNHAP_T = nameof(Ktdm.VndnhapT);
            string XUAT_T = nameof(Ktdm.XuatT);
            string VNDXUAT_T = nameof(Ktdm.VndxuatT);
            string TON_CK = nameof(Ktdm.TonCk);
            string VNDTON_CK = nameof(Ktdm.VndtonCk);
            string DANHDAU = nameof(Ktdm.Danhdau);
            string DGBAN = nameof(Ktdm.Dgban);
            string DGBAN1 = nameof(Ktdm.Dgban1);
            string DGBAN2 = nameof(Ktdm.Dgban2);
            string DGBAN3 = nameof(Ktdm.Dgban3);
            string DGBAN4 = nameof(Ktdm.Dgban4);
            string DONVI1 = nameof(Ktdm.Donvi1);
            string DONVI2 = nameof(Ktdm.Donvi2);
            string DONVI3 = nameof(Ktdm.Donvi3);
            string HSQD1 = nameof(Ktdm.Hsqd1);
            string HSQD2 = nameof(Ktdm.Hsqd2);
            string HSQD3 = nameof(Ktdm.Hsqd3);
            string USDTON_T = nameof(Ktdm.UsdtonT);
            string USDNHAP_T = nameof(Ktdm.UsdnhapT);
            string USDXUAT_T = nameof(Ktdm.UsdxuatT);
            string USDTON_CK = nameof(Ktdm.UsdtonCk);
            string DGUSD = nameof(Ktdm.Dgusd);
            string DGNHAP1 = nameof(Ktdm.Dgnhap1);
            string DGNHAP2 = nameof(Ktdm.Dgnhap2);
            string DGNHAP3 = nameof(Ktdm.Dgnhap3);
            string DGNHAP4 = nameof(Ktdm.Dgnhap4);
            string DGNHAP5 = nameof(Ktdm.Dgnhap5);
            string TRANGTHAI = nameof(Ktdm.Trangthai);
            string DGNHAP = nameof(Ktdm.Dgnhap);
            string DG_CHUYENKHO = nameof(Ktdm.DgChuyenkho);
            string DG_CKTM = nameof(Ktdm.DgCktm);
            string DG_VC = nameof(Ktdm.DgVc);
            string DM_CKTM = nameof(Ktdm.DmCktm);
            string GIOIHANTON = nameof(Ktdm.Gioihanton);
            string MADM_ME = nameof(Ktdm.MadmMe);
            string MANHOM1 = nameof(Ktdm.Manhom1);
            string MANHOM2 = nameof(Ktdm.Manhom2);
            string MANHOMTP = nameof(Ktdm.Manhomtp);
            string MODEL = nameof(Ktdm.Model);
            string SO_DDH = nameof(Ktdm.SoDdh);
            string TEN_DDH = nameof(Ktdm.TenDdh);
            string TENDM_ME = nameof(Ktdm.TendmMe);
            string TENNHOM1 = nameof(Ktdm.Tennhom1);
            string TENNHOM2 = nameof(Ktdm.Tennhom2);
            string TENNHOMTP = nameof(Ktdm.Tennhomtp);
            string TG_CKTM = nameof(Ktdm.TgCktm);
            string TK_CHIETKHAU = nameof(Ktdm.TkChietkhau);
            string TK_DOANHTHU = nameof(Ktdm.TkDoanhthu);
            string TK_GIAVON = nameof(Ktdm.TkGiavon);
            string TK_TRALAI = nameof(Ktdm.TkTralai);
            string TYLE_OF_NHOM = nameof(Ktdm.TyleOfNhom);
            string NHAP_TDV1 = nameof(Ktdm.NhapTDv1);
            string NHAP_TDV2 = nameof(Ktdm.NhapTDv2);
            string TON_CK_DV1 = nameof(Ktdm.TonCkDv1);
            string TON_CK_DV2 = nameof(Ktdm.TonCkDv2);
            string TON_TDV1 = nameof(Ktdm.TonTDv1);
            string TON_TDV2 = nameof(Ktdm.TonTDv2);
            string XUAT_TDV1 = nameof(Ktdm.XuatTDv1);
            string XUAT_TDV2 = nameof(Ktdm.XuatTDv2);
            string NHOMCK = nameof(Ktdm.Nhomck);
            string MAKHO = nameof(Ktdm.Makho);
            string MAVACH = nameof(Ktdm.Mavach);
            string GIOIHANTON_MAX = nameof(Ktdm.GioihantonMax);
            string ID_UPDATE = nameof(Ktdm.IdUpdate);
            string TENDM2 = nameof(Ktdm.Tendm2);
            string DGBAN_GAN_NHAT = nameof(Ktdm.DgbanGanNhat);
            string DGMUA_GAN_NHAT = nameof(Ktdm.DgmuaGanNhat);
            string GHICHU = nameof(Ktdm.Ghichu);
            string NGAYBAN_GAN_NHAT = nameof(Ktdm.NgaybanGanNhat);
            string NGAYMUA_GAN_NHAT = nameof(Ktdm.NgaymuaGanNhat);
            string QUYCACH = nameof(Ktdm.Quycach);
            string SONGAYSUDUNG = nameof(Ktdm.Songaysudung);

            if(values.Contains(MATK)) {
                model.Matk = Convert.ToString(values[MATK]);
            }

            if(values.Contains(MADM)) {
                model.Madm = Convert.ToString(values[MADM]);
            }

            if(values.Contains(TENDM)) {
                model.Tendm = Convert.ToString(values[TENDM]);
            }

            if(values.Contains(MANHOM)) {
                model.Manhom = Convert.ToString(values[MANHOM]);
            }

            if(values.Contains(TENNHOM)) {
                model.Tennhom = Convert.ToString(values[TENNHOM]);
            }

            if(values.Contains(KYHIEU)) {
                model.Kyhieu = Convert.ToString(values[KYHIEU]);
            }

            if(values.Contains(DONVI)) {
                model.Donvi = Convert.ToString(values[DONVI]);
            }

            if(values.Contains(LO)) {
                model.Lo = Convert.ToString(values[LO]);
            }

            if(values.Contains(NGAYLO)) {
                model.Ngaylo = values[NGAYLO] != null ? Convert.ToDateTime(values[NGAYLO]) : (DateTime?)null;
            }

            if(values.Contains(HANSUDUNG)) {
                model.Hansudung = values[HANSUDUNG] != null ? Convert.ToDateTime(values[HANSUDUNG]) : (DateTime?)null;
            }

            if(values.Contains(NHACUNGCAP)) {
                model.Nhacungcap = Convert.ToString(values[NHACUNGCAP]);
            }

            if(values.Contains(NHASANXUAT)) {
                model.Nhasanxuat = Convert.ToString(values[NHASANXUAT]);
            }

            if(values.Contains(PTCHIETKHAU)) {
                model.Ptchietkhau = Convert.ToDouble(values[PTCHIETKHAU], CultureInfo.InvariantCulture);
            }

            if(values.Contains(THUESUAT)) {
                model.Thuesuat = Convert.ToDouble(values[THUESUAT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGXUAT)) {
                model.Dgxuat = Convert.ToDouble(values[DGXUAT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_T)) {
                model.TonT = Convert.ToDouble(values[TON_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(VNDTON_T)) {
                model.VndtonT = Convert.ToDouble(values[VNDTON_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(NHAP_T)) {
                model.NhapT = Convert.ToDouble(values[NHAP_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(VNDNHAP_T)) {
                model.VndnhapT = Convert.ToDouble(values[VNDNHAP_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(XUAT_T)) {
                model.XuatT = Convert.ToDouble(values[XUAT_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(VNDXUAT_T)) {
                model.VndxuatT = Convert.ToDouble(values[VNDXUAT_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_CK)) {
                model.TonCk = Convert.ToDouble(values[TON_CK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(VNDTON_CK)) {
                model.VndtonCk = Convert.ToDouble(values[VNDTON_CK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DANHDAU)) {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if(values.Contains(DGBAN)) {
                model.Dgban = Convert.ToDouble(values[DGBAN], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGBAN1)) {
                model.Dgban1 = Convert.ToDouble(values[DGBAN1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGBAN2)) {
                model.Dgban2 = Convert.ToDouble(values[DGBAN2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGBAN3)) {
                model.Dgban3 = Convert.ToDouble(values[DGBAN3], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGBAN4)) {
                model.Dgban4 = Convert.ToDouble(values[DGBAN4], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DONVI1)) {
                model.Donvi1 = Convert.ToString(values[DONVI1]);
            }

            if(values.Contains(DONVI2)) {
                model.Donvi2 = Convert.ToString(values[DONVI2]);
            }

            if(values.Contains(DONVI3)) {
                model.Donvi3 = Convert.ToString(values[DONVI3]);
            }

            if(values.Contains(HSQD1)) {
                model.Hsqd1 = Convert.ToDouble(values[HSQD1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(HSQD2)) {
                model.Hsqd2 = Convert.ToDouble(values[HSQD2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(HSQD3)) {
                model.Hsqd3 = Convert.ToDouble(values[HSQD3], CultureInfo.InvariantCulture);
            }

            if(values.Contains(USDTON_T)) {
                model.UsdtonT = Convert.ToDouble(values[USDTON_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(USDNHAP_T)) {
                model.UsdnhapT = Convert.ToDouble(values[USDNHAP_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(USDXUAT_T)) {
                model.UsdxuatT = Convert.ToDouble(values[USDXUAT_T], CultureInfo.InvariantCulture);
            }

            if(values.Contains(USDTON_CK)) {
                model.UsdtonCk = Convert.ToDouble(values[USDTON_CK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGUSD)) {
                model.Dgusd = Convert.ToDouble(values[DGUSD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGNHAP1)) {
                model.Dgnhap1 = Convert.ToDouble(values[DGNHAP1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGNHAP2)) {
                model.Dgnhap2 = Convert.ToDouble(values[DGNHAP2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGNHAP3)) {
                model.Dgnhap3 = Convert.ToDouble(values[DGNHAP3], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGNHAP4)) {
                model.Dgnhap4 = Convert.ToDouble(values[DGNHAP4], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGNHAP5)) {
                model.Dgnhap5 = Convert.ToDouble(values[DGNHAP5], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TRANGTHAI)) {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if(values.Contains(DGNHAP)) {
                model.Dgnhap = Convert.ToDouble(values[DGNHAP], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DG_CHUYENKHO)) {
                model.DgChuyenkho = Convert.ToDouble(values[DG_CHUYENKHO], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DG_CKTM)) {
                model.DgCktm = Convert.ToString(values[DG_CKTM]);
            }

            if(values.Contains(DG_VC)) {
                model.DgVc = Convert.ToDouble(values[DG_VC], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DM_CKTM)) {
                model.DmCktm = Convert.ToString(values[DM_CKTM]);
            }

            if(values.Contains(GIOIHANTON)) {
                model.Gioihanton = Convert.ToDouble(values[GIOIHANTON], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MADM_ME)) {
                model.MadmMe = Convert.ToString(values[MADM_ME]);
            }

            if(values.Contains(MANHOM1)) {
                model.Manhom1 = Convert.ToString(values[MANHOM1]);
            }

            if(values.Contains(MANHOM2)) {
                model.Manhom2 = Convert.ToString(values[MANHOM2]);
            }

            if(values.Contains(MANHOMTP)) {
                model.Manhomtp = Convert.ToString(values[MANHOMTP]);
            }

            if(values.Contains(MODEL)) {
                model.Model = Convert.ToString(values[MODEL]);
            }

            if(values.Contains(SO_DDH)) {
                model.SoDdh = Convert.ToString(values[SO_DDH]);
            }

            if(values.Contains(TEN_DDH)) {
                model.TenDdh = Convert.ToString(values[TEN_DDH]);
            }

            if(values.Contains(TENDM_ME)) {
                model.TendmMe = Convert.ToString(values[TENDM_ME]);
            }

            if(values.Contains(TENNHOM1)) {
                model.Tennhom1 = Convert.ToString(values[TENNHOM1]);
            }

            if(values.Contains(TENNHOM2)) {
                model.Tennhom2 = Convert.ToString(values[TENNHOM2]);
            }

            if(values.Contains(TENNHOMTP)) {
                model.Tennhomtp = Convert.ToString(values[TENNHOMTP]);
            }

            if(values.Contains(TG_CKTM)) {
                model.TgCktm = Convert.ToString(values[TG_CKTM]);
            }

            if(values.Contains(TK_CHIETKHAU)) {
                model.TkChietkhau = Convert.ToString(values[TK_CHIETKHAU]);
            }

            if(values.Contains(TK_DOANHTHU)) {
                model.TkDoanhthu = Convert.ToString(values[TK_DOANHTHU]);
            }

            if(values.Contains(TK_GIAVON)) {
                model.TkGiavon = Convert.ToString(values[TK_GIAVON]);
            }

            if(values.Contains(TK_TRALAI)) {
                model.TkTralai = Convert.ToString(values[TK_TRALAI]);
            }

            if(values.Contains(TYLE_OF_NHOM)) {
                model.TyleOfNhom = Convert.ToDouble(values[TYLE_OF_NHOM], CultureInfo.InvariantCulture);
            }

            if(values.Contains(NHAP_TDV1)) {
                model.NhapTDv1 = Convert.ToDouble(values[NHAP_TDV1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(NHAP_TDV2)) {
                model.NhapTDv2 = Convert.ToDouble(values[NHAP_TDV2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_CK_DV1)) {
                model.TonCkDv1 = Convert.ToDouble(values[TON_CK_DV1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_CK_DV2)) {
                model.TonCkDv2 = Convert.ToDouble(values[TON_CK_DV2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_TDV1)) {
                model.TonTDv1 = Convert.ToDouble(values[TON_TDV1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TON_TDV2)) {
                model.TonTDv2 = Convert.ToDouble(values[TON_TDV2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(XUAT_TDV1)) {
                model.XuatTDv1 = Convert.ToDouble(values[XUAT_TDV1], CultureInfo.InvariantCulture);
            }

            if(values.Contains(XUAT_TDV2)) {
                model.XuatTDv2 = Convert.ToDouble(values[XUAT_TDV2], CultureInfo.InvariantCulture);
            }

            if(values.Contains(NHOMCK)) {
                model.Nhomck = Convert.ToString(values[NHOMCK]);
            }

            if(values.Contains(MAKHO)) {
                model.Makho = Convert.ToString(values[MAKHO]);
            }

            if(values.Contains(MAVACH)) {
                model.Mavach = Convert.ToString(values[MAVACH]);
            }

            if(values.Contains(GIOIHANTON_MAX)) {
                model.GioihantonMax = Convert.ToDouble(values[GIOIHANTON_MAX], CultureInfo.InvariantCulture);
            }

            if(values.Contains(ID_UPDATE)) {
                model.IdUpdate = Convert.ToString(values[ID_UPDATE]);
            }

            if(values.Contains(TENDM2)) {
                model.Tendm2 = Convert.ToString(values[TENDM2]);
            }

            if(values.Contains(DGBAN_GAN_NHAT)) {
                model.DgbanGanNhat = Convert.ToDouble(values[DGBAN_GAN_NHAT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(DGMUA_GAN_NHAT)) {
                model.DgmuaGanNhat = Convert.ToDouble(values[DGMUA_GAN_NHAT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(GHICHU)) {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if(values.Contains(NGAYBAN_GAN_NHAT)) {
                model.NgaybanGanNhat = values[NGAYBAN_GAN_NHAT] != null ? Convert.ToDateTime(values[NGAYBAN_GAN_NHAT]) : (DateTime?)null;
            }

            if(values.Contains(NGAYMUA_GAN_NHAT)) {
                model.NgaymuaGanNhat = values[NGAYMUA_GAN_NHAT] != null ? Convert.ToDateTime(values[NGAYMUA_GAN_NHAT]) : (DateTime?)null;
            }

            if(values.Contains(QUYCACH)) {
                model.Quycach = Convert.ToString(values[QUYCACH]);
            }

            if(values.Contains(SONGAYSUDUNG)) {
                model.Songaysudung = Convert.ToDouble(values[SONGAYSUDUNG], CultureInfo.InvariantCulture);
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