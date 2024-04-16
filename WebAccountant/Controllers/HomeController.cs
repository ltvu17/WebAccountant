using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAccountant.Models;

namespace WebAccountant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KTCN()
        {
            return View("~/Views/Home/Pages/KTCN.cshtml");
        }
        public IActionResult KTDM()
        {
            return View("~/Views/Home/Pages/KTDM.cshtml");
        }
        public IActionResult KTDTPN()
        {
            return View("~/Views/Home/Pages/KTDTPN.cshtml");
        }
        public IActionResult KTLCTG()
        {
            return View("~/Views/Home/Pages/KTLCTG.cshtml");
        }
        public IActionResult KTSC()
        {
            return View("~/Views/Home/Pages/KTSC.cshtml");
        }
        public IActionResult KTTK()
        {
            return View("~/Views/Home/Pages/KTTK.cshtml");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}