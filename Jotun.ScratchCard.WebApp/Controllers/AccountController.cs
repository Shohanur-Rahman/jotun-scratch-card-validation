using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
