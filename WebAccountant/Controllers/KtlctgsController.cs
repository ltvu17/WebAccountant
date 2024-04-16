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
    public class KtlctgsController : Controller
    {
        private readonly IKtlctgRepo _ktlctgRepo;

        public KtlctgsController(IKtlctgRepo ktlctgRepo) {
            _ktlctgRepo = ktlctgRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktlctgs = await _ktlctgRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(ktlctgs, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktlctgRepo.AddNew(values);
            return Json(new { result.Entity.Lctg });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            await _ktlctgRepo.Update(key, values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            await _ktlctgRepo.Delete(key);
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