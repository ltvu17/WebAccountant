using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAccountant.Models;
using WebAccountant.Repository;

namespace WebAccountant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserKTSCColumnsRepo _userKTSCColumnsRepo;
        public HomeController(ILogger<HomeController> logger, IUserKTSCColumnsRepo userKTSCColumnsRepo)
        {
            _logger = logger;
            _userKTSCColumnsRepo = userKTSCColumnsRepo;
        }
		public IActionResult Index()
        {
            ViewData["activeId"] = "1";
            return View();
        }
		public IActionResult Register()
		{
			return View("~/Views/RegisterAccount.cshtml");
		}
		public IActionResult KTCN()
        {
            ViewData["activeId"] = "7";
            return View("~/Views/Home/Pages/KTCN.cshtml");
        }
        public IActionResult KTDM()
        {
            ViewData["activeId"] = "6";
            return View("~/Views/Home/Pages/KTDM.cshtml");
        }
        public IActionResult KTDTPN()
        {
            ViewData["activeId"] = "5";
            return View("~/Views/Home/Pages/KTDTPN.cshtml");
        }
        public IActionResult KTLCTG()
        {
            ViewData["activeId"] = "4";
            return View("~/Views/Home/Pages/KTLCTG.cshtml");
        }
        public async Task<IActionResult> KTSC()
        {
/*            string height = HttpContext.Request.["clientScreenHeight"];
            string width = HttpContext.Current.Request.Params["clientScreenWidth"];*/
            var KTSCColumns = await _userKTSCColumnsRepo.GetAllKTSCColumn();
            var attribute = await _userKTSCColumnsRepo.GetUserKTSCColumn(4);
            ViewData["activeId"] = "8";
            ViewData["attribute"] = attribute;
            return View("~/Views/Home/Pages/KTSC.cshtml", KTSCColumns);
        }
        public IActionResult KTTK()
        {
            ViewData["activeId"] = "3";
            return View("~/Views/Home/Pages/KTTK.cshtml");
        }
        public IActionResult BuyProduct()
        {
            ViewData["isError"] = "0";
            ViewData["activeId"] = "9";
            return View("~/Views/Home/Pages/BuyProduct.cshtml");
        }
        public IActionResult SellProduct()
        {
            ViewData["activeId"] = "10";
            return View("~/Views/Home/Pages/SellProduct.cshtml");
        }
        public IActionResult ImportProduct()
        {
            ViewData["activeId"] = "11";
            return View("~/Views/Home/Pages/ImportProduct.cshtml");
        }
        public IActionResult ExportBuyProduct()
        {
            return View("~/Views/Home/Pages/ExportBuyProduct.cshtml");
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