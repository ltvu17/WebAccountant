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
    public class KtdmsController : Controller
    {
        private readonly IKtdmRepo _ktdmRepo;
        private readonly IUserKTDMColumnRepo _userKTDMColumnRepo;
        public static List<KtdmDTO> ktdmsDTO = new List<KtdmDTO>();

        public KtdmsController(IKtdmRepo ktdmRepo, IUserKTDMColumnRepo userKTDMColumnRepo) {
            _ktdmRepo = ktdmRepo;
            _userKTDMColumnRepo = userKTDMColumnRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetDto(DataSourceLoadOptions loadOptions)
        {
            ktdmsDTO = (await _ktdmRepo.GetAllKtdmDTO()).ToList();
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                ktdmsDTO = JsonConvert.DeserializeObject<List<KtdmDTO>>(cart);
            }
            else
            {
                var data = JsonConvert.SerializeObject(ktdmsDTO);
                HttpContext.Session.SetString("cart", data);
            }
            return Json(DataSourceLoader.Load(ktdmsDTO, loadOptions));
        }
        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            var ktscs = await _ktdmRepo.GetAllAsync();
            return Json(ktscs);
        }
        [HttpPost]
        public async Task<object> Batch([FromBody] List<DataChange> changes)
        {
            foreach (var change in changes)
            {
                Ktdm ktdm;

                if (change.Type == "update" || change.Type == "remove")
                {
                    var key = change.Key.ToString();
                    ktdm = await _ktdmRepo.GetKTDMByKey(key);
                }
                else
                {
                    ktdm = new Ktdm();
                }

                if (change.Type == "insert" || change.Type == "update")
                {
                    JsonConvert.PopulateObject(change.Data.ToString(), ktdm);

                    if (!TryValidateModel(ktdm))
                        return BadRequest();

                 /*   if (change.Type == "insert")
                    {
                        _nwind.Orders.Add(order);
                    }*/
                    if(change.Type == "update")
                    {
                        await _ktdmRepo.UpdateKTDM(ktdm);
                    }
                    change.Data = ktdm;
                }
                else if (change.Type == "remove")
                {
                    await _ktdmRepo.Delete(change.Key.ToString());
                }
            }


            return Ok(changes);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitKTDMColunm()
        {
            List<UserKTDMColumn> ids = new();
            var getId = this.Request.Form.SkipLast(1).Where(s => s.Key.Contains("ids")).ToList();
            var getWidth = this.Request.Form.SkipLast(1).Where(s => s.Key.Contains("width")).ToList();
            foreach (var id in getId)
            {
                var index = id.Key.Substring(id.Key.IndexOf("[") + 1, id.Key.IndexOf("]") - id.Key.IndexOf("[") - 1);
                ids.Add(new UserKTDMColumn
                {
                    KTDMColumnId = Int32.Parse(id.Value[0]),
                    Width = int.Parse(getWidth.Where(s => s.Key == $"width[{index}]").FirstOrDefault().Value[0]),
                });
            }
            await _userKTDMColumnRepo.AddAllColumnOfUser(4, ids);
            return RedirectToAction("KTDM", "Home");
        }
        [HttpPut]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UpdateDto(string key, string values)
        {
/*            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                ktdmsDTO = JsonConvert.DeserializeObject<List<KtdmDTO>>(cart);
            }*/

            var newCart = await _ktdmRepo.UpdateKtdmDTO(key, values, ktdmsDTO);
            var data = JsonConvert.SerializeObject(newCart);
            HttpContext.Session.SetString("cart", data);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktdms = await _ktdmRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktdms, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Ktdm entity) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktdmRepo.AddNew(entity);
            return RedirectToAction("KTDM", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Put(Ktdm ktdm) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            await _ktdmRepo.UpdateKTDM(ktdm);
            return RedirectToAction("KTDM", "Home");
        }

        [HttpDelete]
        public async Task Delete(string key) {
           await _ktdmRepo.Delete(key);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitCartToExportPhieuBanHang(IEnumerable<PhieuBanHangDTO> items)
        {
            items = JsonConvert.DeserializeObject<IEnumerable<PhieuBanHangDTO>>(Request.Form.Keys.FirstOrDefault().Replace("and", "&").ToString());
            var pathValue = await _ktdmRepo.ExportPDFPhieuBanHang(items);
            return Json(pathValue);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitCartToExportPhieuMuaHang(IEnumerable<PhieuMuaHangDTO> items)
        {
            items = JsonConvert.DeserializeObject<IEnumerable<PhieuMuaHangDTO>>(Request.Form.Keys.FirstOrDefault().Replace("and", "&").ToString());
            var pathValue = await _ktdmRepo.ExportPDFPhieuMuaHang(items);
            return Json(pathValue);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitCartToExport(AddToKTSCDTO items)
        {
            var pathValue = await _ktdmRepo.ExportPDF(items);
            return Json(items);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitCartToSave(FormBanHangDTO items)
        {
            List<KtdmDTO> addList = new List<KtdmDTO>();
            var ktdmDTOs = this.Request.Form.Where(s => s.Key.Contains(typeof(KtdmDTO).Name.ToString(), StringComparison.OrdinalIgnoreCase));
            var keyString = ktdmDTOs.LastOrDefault().Key;
            var numberOfEntity = keyString.ElementAt(keyString.IndexOf("[") + 1);
            var result = int.TryParse(numberOfEntity.ToString(), out var totalEntity);
            if (result)
            {
                if(totalEntity != items.ktdmDTOs.Count)
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
                                ThueThanhTien = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].ThueThanhTien", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                ChietKhauThanhTien = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].ChietKhauThanhTien", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                            });
                        }
                    }
                }    
            }
            if(addList.Count > 0)
            {
                items.ktdmDTOs = addList;
            }
            await _ktdmRepo.SaveCartToDB(items);
            return RedirectToAction("SellProduct", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> SubmitBuyCartToSave(AddToKTSCDTO items)
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
                                ThueThanhTien = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].ThueThanhTien", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                                ChietKhauThanhTien = double.Parse(ktdmDTOs.Where(s => s.Key.Equals(typeof(KtdmDTO).Name.ToString() + "s[" + i + "].ChietKhauThanhTien", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value),
                            });
                        }
                    }
                }
            }
            if (addList.Count > 0)
            {
                items.ktdmDTOs = addList;
            }
            await _ktdmRepo.SaveBuyingCartToDB(items);
            return RedirectToAction("BuyProduct", "Home");
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