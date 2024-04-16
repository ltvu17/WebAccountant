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

namespace WebAccountant.Controllers
{
    [Route("api/[controller]/[action]")]
    public class KtdmsController : Controller
    {
        private TIENHIEU2024Context _context;
        private readonly IKtdmRepo _ktdmRepo;

        public KtdmsController(TIENHIEU2024Context context, IKtdmRepo ktdmRepo) {
            _context = context;
            _ktdmRepo = ktdmRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var ktdms = await _ktdmRepo.GetAllKtdmsAsync();
            return Json(DataSourceLoader.Load(ktdms, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _ktdmRepo.AddNew(values);
            return Json(new { result.Entity.Madm, result.Entity.Matk });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            await _ktdmRepo.Update(key, values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
           await _ktdmRepo.Delete(key);
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