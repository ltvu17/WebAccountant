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
    public class KtcnsController : Controller
    {
        private readonly IKtcnsRepo _ktcnsRepo;

        public KtcnsController(IKtcnsRepo ktcnsRepo) {
            _ktcnsRepo = ktcnsRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktcns = await _ktcnsRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktcns, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Ktcn values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktcnsRepo.AddNew(values);
            return RedirectToAction("KTCN", "Home");
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            await _ktcnsRepo.Update(key, values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            await _ktcnsRepo.Delete(key);
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