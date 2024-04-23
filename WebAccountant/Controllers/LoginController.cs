using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAccountant.Models;
using WebAccountant.ModelsLogin;
using WebAccountant.Repository;

namespace WebAccountant.Controllers
{
	public class LoginController : Controller
	{
		private readonly ILoginRepo _loginRepo;
        public LoginController(ILoginRepo loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public IActionResult Index()
		{
            ViewData["isLoginPage"] = "1";
            return View("~/Views/Login.cshtml");
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginDTO entity)
		{
			var userDTO = await _loginRepo.Login(entity);
			if(userDTO == null)
			{
				ViewData["loginMessage"] = "Tên đăng nhập hoặc mật khẩu không chính xác";
                return View("~/Views/Login.cshtml");
            }
			else
			{
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(userDTO));
				return RedirectToAction("Index", "Home");
            }
		}
	}
}
