using Microsoft.AspNetCore.Mvc;

namespace WebAccountant.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Admin/Admin.cshtml");
        }

    }
}
