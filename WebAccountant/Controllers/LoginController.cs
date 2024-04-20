using Microsoft.AspNetCore.Mvc;

namespace WebAccountant.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
            ViewData["isLoginPage"] = "1";
            return View("~/Views/Login.cshtml");
		}
	}
}
