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
    public class KtscsController : Controller
    {
        private readonly IKtscRepo _ktscRepo;

        public KtscsController(IKtscRepo ktscRepo) {
            _ktscRepo = ktscRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktscs = await _ktscRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktscs, loadOptions));
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

        [HttpPut]
        public async Task<IActionResult> Put(double key, string values) {
            await _ktscRepo.Update(key.ToString(), values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(double key) {
            await _ktscRepo.Delete(key.ToString());
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