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
    public class KttksController : Controller
    {
        private readonly IKttkRepo _kttkRepo;

        public KttksController(IKttkRepo kttkRepo) {
            _kttkRepo = kttkRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var kttks = await _kttkRepo.GetAllAsync();
            return Json(DataSourceLoader.Load(kttks, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            if (!ModelState.IsValid)
            {
                return BadRequest(GetFullErrorMessage(ModelState));
            }
            var result = await _kttkRepo.AddNew(values);
            return Json(new { result.Entity.Matk });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            await _kttkRepo.Update(key.ToString(), values);
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            await _kttkRepo.Delete(key.ToString());
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