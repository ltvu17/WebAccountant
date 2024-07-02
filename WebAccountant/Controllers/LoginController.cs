using DevExpress.Internal;
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
        private readonly IUserTableRepo _userTable;

        public LoginController(ILoginRepo loginRepo, IUserTableRepo userTable)
        {
            _loginRepo = loginRepo;
            _userTable = userTable;
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
				var userPermission = await _userTable.GetUserPermission(userDTO.UserName);
                HttpContext.Session.SetString("permission", JsonConvert.SerializeObject(userPermission));
                return RedirectToAction("SellProduct", "Home");
            }
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterDTO entity)
		{
			var userDTO = await _loginRepo.RegisterTest(entity);
			return RedirectToAction("Index", "Login");		
		}
		[HttpPost]
		public async Task<IActionResult> Logout()
		{
			HttpContext.Session.Clear();
			_loginRepo.Logout();
			return View("~/Views/Login.cshtml");
		}
	}
}
