using DevExpress.Pdf.Native.BouncyCastle.Utilities;
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
using WebAccountant.Models;
using WebAccountant.ModelsBase;
using WebAccountant.ModelsLogin;
using WebAccountant.Repository;
using WebAccountant.Repository.Implement;

namespace WebAccountant.Controllers
{
    [Route("api/[controller]/[action]")]
    public class KtscsController : Controller
    {
        private readonly IKtscRepo _ktscRepo;
        private readonly IUserKTSCColumnsRepo _userKTSCColumnsRepo;

        public KtscsController(IKtscRepo ktscRepo, IUserKTSCColumnsRepo userKTSCColumnsRepo) {
            _ktscRepo = ktscRepo;
            _userKTSCColumnsRepo = userKTSCColumnsRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetALLDSPhieuBanHang(DataSourceLoadOptions loadOptions)
        {
            var ktscBanHangs = await _ktscRepo.GetAllDSPhieuBanHang();
            return Json(DataSourceLoader.Load(ktscBanHangs, loadOptions));
        }


        [HttpGet]
        public async Task<IActionResult> GetALLDSPhieuBanHangByDate(DateTime fromDate, DateTime toDate)
        {
            toDate = toDate.AddHours(23).AddMinutes(59).AddSeconds(59);
            var ktscBanHangs = await _ktscRepo.GetAllDSPhieuBanHang();
            var filteredData = ktscBanHangs.Where(m => m.NgayCtu >= fromDate && m.NgayCtu <= toDate);
            return Json(filteredData);
        }

        [HttpGet]
        public async Task<IActionResult> GetSoHoaDon()
        {
            var ktsc = (await _ktscRepo.GetAllAsync()).OrderByDescending(s=>s.IdChungtu).FirstOrDefault().IdChungtu + 1;
            return Json(ktsc);
        }
        [HttpGet]
        public async Task<IActionResult> GetDetailPhieuBanHang(int id)
        {
            var phieuBanHang = await _ktscRepo.GetDetailPhieuBanHang(id);
            return PartialView("~/Views/Home/Pages/Actions/SellEditPage.cshtml", phieuBanHang);
        }

        [HttpGet]
        public async Task<IActionResult> GetALLDSPhieuMuaHangByDate(DateTime fromDate, DateTime toDate)
        {
            Console.WriteLine(fromDate.ToString());
            toDate = toDate.AddHours(23).AddMinutes(59).AddSeconds(59);
            var ktscBanHangs = await _ktscRepo.GetAllDSPhieuMuaHang();
            var filteredData = ktscBanHangs.Where(m => m.NgayCtu >= fromDate && m.NgayCtu <= toDate);
            return Json(filteredData);
        }
        [HttpGet]
        public async Task<IActionResult> GetDetailPhieuMuaHang(int id)
        {
            var phieuMuaHang = await _ktscRepo.GetDetailPhieuMuaHang(id);
            return PartialView("~/Views/Home/Pages/Actions/BuyEditPage.cshtml", phieuMuaHang);
        }
        [HttpGet]
        public async Task<IActionResult> GetALLDSPhieuMuaHang(DataSourceLoadOptions loadOptions)
        {
            var ktscMuaHangs = await _ktscRepo.GetAllDSPhieuMuaHang();
            return Json(DataSourceLoader.Load(ktscMuaHangs, loadOptions));
        }
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktscs = await _ktscRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktscs, loadOptions));
        }
        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            var ktscs = await _ktscRepo.GetAllAsync();
            return Json(ktscs);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Ktsc values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktscRepo.AddNew(values);
            return Json(new { result.Entity.SttSc });
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDetailPhieuBanHang(FormBanHangDTO items)
        {
            List<KtdmDTO> addList = new List<KtdmDTO>();
            var ktdmDTOs = this.Request.Form.Where(s => s.Key.Contains(typeof(KtdmDTO).Name.ToString(), StringComparison.OrdinalIgnoreCase));
            var keyString = ktdmDTOs.LastOrDefault().Key;
            var numberOfEntity = keyString.ElementAt(keyString.IndexOf("[") + 1);
            var result = int.TryParse(numberOfEntity.ToString(), out var totalEntity);
            if (result)
            {
                if (totalEntity != items.ktdmDTOs.Count)
                {
                    for (int i = 0; i < items.ktdmDTOs.Count; i++)
                    {
                        var checkValue = ktdmDTOs.Where(s => s.Key.Contains("[" + i + "]")).FirstOrDefault().Value;
                        if (!string.IsNullOrEmpty(checkValue))
                        {
                            var ts = typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban";
                            var test = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value;
                            addList.Add(new KtdmDTO
                            {
                                Dgban = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Donvi = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Donvi", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                Madm = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Madm", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                Matk = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Matk", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                PtChietKhau = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].PtChietKhau", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                PtThue = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].PtThue", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Soluong = int.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Soluong", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Tendm = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Tendm", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                            });
                        }
                    }
                }
            }
            if (addList.Count > 0)
            {
                items.ktdmDTOs = addList;
            }
            await _ktscRepo.UpdateDetailPhieuBanHang(items);
            return RedirectToAction("SellProduct", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDetailPhieuMuaHang(AddToKTSCDTO items)
        {
            List<KtdmDTO> addList = new List<KtdmDTO>();
            var ktdmDTOs = this.Request.Form.Where(s => s.Key.Contains(typeof(KtdmDTO).Name.ToString(), StringComparison.OrdinalIgnoreCase));
            var keyString = ktdmDTOs.LastOrDefault().Key;
            var numberOfEntity = keyString.ElementAt(keyString.IndexOf("[") + 1);
            var result = int.TryParse(numberOfEntity.ToString(), out var totalEntity);
            if (result)
            {
                if (totalEntity != items.ktdmDTOs.Count)
                {
                    for (int i = 0; i < items.ktdmDTOs.Count; i++)
                    {
                        var checkValue = ktdmDTOs.Where(s => s.Key.Contains("[" + i + "]")).FirstOrDefault().Value;
                        if (!string.IsNullOrEmpty(checkValue))
                        {
                            var ts = typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban";
                            var test = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value;
                            addList.Add(new KtdmDTO
                            {
                                Dgban = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Dgban", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Donvi = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Donvi", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                Madm = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Madm", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                Matk = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Matk", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                                PtChietKhau = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].PtChietKhau", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                PtThue = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].PtThue", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Soluong = int.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Soluong", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                Tendm = ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].Tendm", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value,
                            });
                        }
                    }
                }
            }
            if (addList.Count > 0)
            {
                items.ktdmDTOs = addList;
            }
            await _ktscRepo.UpdateDetailPhieuMuaHang(items);
            return RedirectToAction("BuyProduct", "Home");
        }
        [HttpPut]
        public async Task<IActionResult> Put(double key, string values) {
            await _ktscRepo.Update(key.ToString(), values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(double key) {
            await _ktscRepo.Delete(key.ToString());
        }
        [HttpDelete]
        public async Task DeletePhieuBanHang(int id)
        {
            await _ktscRepo.DeletePhieuBanHang(id);
        }
        [HttpDelete]
        public async Task DeletePhieuMuaHang(int id)
        {
            await _ktscRepo.DeletePhieuMuaHang(id);
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
        [HttpGet]
        public async Task<IActionResult> GetKTSCColumn() 
        {
            var ktscColumns = await _userKTSCColumnsRepo.GetAllKTSCColumn();
            return Json(ktscColumns);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitKTSCColunm()
        {
            List<UserKTSCColumn> ids = new();
            var getId = this.Request.Form.SkipLast(1).Where(s => s.Key.Contains("ids")).ToList();
            var getWidth = this.Request.Form.SkipLast(1).Where(s => s.Key.Contains("width")).ToList();
            foreach (var id in getId)
            {
                var index = id.Key.Substring(id.Key.IndexOf("[") + 1, id.Key.IndexOf("]") - id.Key.IndexOf("[") - 1);
                ids.Add(new UserKTSCColumn
                {
                    KTSCColumnId = Int32.Parse(id.Value[0]),
                    Width = int.Parse(getWidth.Where(s => s.Key == $"width[{index}]").FirstOrDefault().Value[0]),
                });
            }
            await _userKTSCColumnsRepo.AddAllColumnOfUser(4, ids);
            return RedirectToAction("KTSC", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> GetUserKTSCColumn()
        {
            var ktscColumns = await _userKTSCColumnsRepo.GetUserKTSCColumn(4);
            return Json(ktscColumns);
        }
    }
}