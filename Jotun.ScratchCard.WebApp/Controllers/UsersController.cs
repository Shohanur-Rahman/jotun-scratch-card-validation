using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
