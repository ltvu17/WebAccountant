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
using WebAccountant.Repository;
using WebAccountant.Repository.Implement;

namespace WebAccountant.Controllers
{
    [Route("api/[controller]/[action]")]
    public class KtdtpnsController : Controller
    {
        private readonly IKtdtpnsRepo _ktdtpnsRepo;

        public KtdtpnsController(IKtdtpnsRepo ktdtpnsRepo) {
            _ktdtpnsRepo = ktdtpnsRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktdtpns = await _ktdtpnsRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktdtpns, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Ktdtpn values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktdtpnsRepo.AddNew(values);
            return RedirectToAction("KTDTPN", "Home");
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            await _ktdtpnsRepo.Update(key, values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            await _ktdtpnsRepo.Delete(key);
        }


        private void PopulateModel(Ktdtpn model, IDictionary values) {
            string MADTPN = nameof(Ktdtpn.Madtpn);
            string TENDTPN = nameof(Ktdtpn.Tendtpn);
            string DIACHI = nameof(Ktdtpn.Diachi);
            string DIACHI_GH = nameof(Ktdtpn.DiachiGh);
            string MS_DN = nameof(Ktdtpn.MsDn);
            string LIEN_HE = nameof(Ktdtpn.LienHe);
            string DIENTHOAI = nameof(Ktdtpn.Dienthoai);
            string TKNH = nameof(Ktdtpn.Tknh);
            string TENTKNH = nameof(Ktdtpn.Tentknh);
            string MATT = nameof(Ktdtpn.Matt);
            string TENTT = nameof(Ktdtpn.Tentt);
            string MANHOM = nameof(Ktdtpn.Manhom);
            string TENNHOM = nameof(Ktdtpn.Tennhom);
            string DANHDAU = nameof(Ktdtpn.Danhdau);
            string TRANGTHAI = nameof(Ktdtpn.Trangthai);
            string FAX = nameof(Ktdtpn.Fax);
            string MANHOM1 = nameof(Ktdtpn.Manhom1);
            string MUCGIA = nameof(Ktdtpn.Mucgia);
            string PT_CK = nameof(Ktdtpn.PtCk);
            string TENNHOM1 = nameof(Ktdtpn.Tennhom1);
            string NGUOIDAIDIEN = nameof(Ktdtpn.Nguoidaidien);
            string EMAIL = nameof(Ktdtpn.Email);
            string KIEUDOITUONG = nameof(Ktdtpn.Kieudoituong);
            string NHOMCK = nameof(Ktdtpn.Nhomck);
            string MANHOMDT1 = nameof(Ktdtpn.Manhomdt1);
            string TENNHOMDT1 = nameof(Ktdtpn.Tennhomdt1);
            string NO_MAX = nameof(Ktdtpn.NoMax);
            string SONGAYTHANHTOAN = nameof(Ktdtpn.Songaythanhtoan);
            string TKCO = nameof(Ktdtpn.Tkco);
            string TKNO = nameof(Ktdtpn.Tkno);
            string EMAILCC = nameof(Ktdtpn.Emailcc);
            string MACTYME = nameof(Ktdtpn.Mactyme);
            string TENCTYME = nameof(Ktdtpn.Tenctyme);
            string LCTG = nameof(Ktdtpn.Lctg);
            string MACOSO_DQG = nameof(Ktdtpn.MacosoDqg);
            string MA_VUNG = nameof(Ktdtpn.MaVung);
            string TENVUNG = nameof(Ktdtpn.Tenvung);
            string ID_UPDATE = nameof(Ktdtpn.IdUpdate);

            if(values.Contains(MADTPN)) {
                model.Madtpn = Convert.ToString(values[MADTPN]);
            }

            if(values.Contains(TENDTPN)) {
                model.Tendtpn = Convert.ToString(values[TENDTPN]);
            }

            if(values.Contains(DIACHI)) {
                model.Diachi = Convert.ToString(values[DIACHI]);
            }

            if(values.Contains(DIACHI_GH)) {
                model.DiachiGh = Convert.ToString(values[DIACHI_GH]);
            }

            if(values.Contains(MS_DN)) {
                model.MsDn = Convert.ToString(values[MS_DN]);
            }

            if(values.Contains(LIEN_HE)) {
                model.LienHe = Convert.ToString(values[LIEN_HE]);
            }

            if(values.Contains(DIENTHOAI)) {
                model.Dienthoai = Convert.ToString(values[DIENTHOAI]);
            }

            if(values.Contains(TKNH)) {
                model.Tknh = Convert.ToString(values[TKNH]);
            }

            if(values.Contains(TENTKNH)) {
                model.Tentknh = Convert.ToString(values[TENTKNH]);
            }

            if(values.Contains(MATT)) {
                model.Matt = Convert.ToString(values[MATT]);
            }

            if(values.Contains(TENTT)) {
                model.Tentt = Convert.ToString(values[TENTT]);
            }

            if(values.Contains(MANHOM)) {
                model.Manhom = Convert.ToString(values[MANHOM]);
            }

            if(values.Contains(TENNHOM)) {
                model.Tennhom = Convert.ToString(values[TENNHOM]);
            }

            if(values.Contains(DANHDAU)) {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if(values.Contains(TRANGTHAI)) {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if(values.Contains(FAX)) {
                model.Fax = Convert.ToString(values[FAX]);
            }

            if(values.Contains(MANHOM1)) {
                model.Manhom1 = Convert.ToString(values[MANHOM1]);
            }

            if(values.Contains(MUCGIA)) {
                model.Mucgia = Convert.ToDouble(values[MUCGIA], CultureInfo.InvariantCulture);
            }

            if(values.Contains(PT_CK)) {
                model.PtCk = Convert.ToDouble(values[PT_CK], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TENNHOM1)) {
                model.Tennhom1 = Convert.ToString(values[TENNHOM1]);
            }

            if(values.Contains(NGUOIDAIDIEN)) {
                model.Nguoidaidien = Convert.ToString(values[NGUOIDAIDIEN]);
            }

            if(values.Contains(EMAIL)) {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if(values.Contains(KIEUDOITUONG)) {
                model.Kieudoituong = Convert.ToString(values[KIEUDOITUONG]);
            }

            if(values.Contains(NHOMCK)) {
                model.Nhomck = Convert.ToString(values[NHOMCK]);
            }

            if(values.Contains(MANHOMDT1)) {
                model.Manhomdt1 = Convert.ToString(values[MANHOMDT1]);
            }

            if(values.Contains(TENNHOMDT1)) {
                model.Tennhomdt1 = Convert.ToString(values[TENNHOMDT1]);
            }

            if(values.Contains(NO_MAX)) {
                model.NoMax = Convert.ToDouble(values[NO_MAX], CultureInfo.InvariantCulture);
            }

            if(values.Contains(SONGAYTHANHTOAN)) {
                model.Songaythanhtoan = Convert.ToDouble(values[SONGAYTHANHTOAN], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TKCO)) {
                model.Tkco = Convert.ToString(values[TKCO]);
            }

            if(values.Contains(TKNO)) {
                model.Tkno = Convert.ToString(values[TKNO]);
            }

            if(values.Contains(EMAILCC)) {
                model.Emailcc = Convert.ToString(values[EMAILCC]);
            }

            if(values.Contains(MACTYME)) {
                model.Mactyme = Convert.ToString(values[MACTYME]);
            }

            if(values.Contains(TENCTYME)) {
                model.Tenctyme = Convert.ToString(values[TENCTYME]);
            }

            if(values.Contains(LCTG)) {
                model.Lctg = Convert.ToString(values[LCTG]);
            }

            if(values.Contains(MACOSO_DQG)) {
                model.MacosoDqg = Convert.ToString(values[MACOSO_DQG]);
            }

            if(values.Contains(MA_VUNG)) {
                model.MaVung = Convert.ToString(values[MA_VUNG]);
            }

            if(values.Contains(TENVUNG)) {
                model.Tenvung = Convert.ToString(values[TENVUNG]);
            }

            if(values.Contains(ID_UPDATE)) {
                model.IdUpdate = Convert.ToString(values[ID_UPDATE]);
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