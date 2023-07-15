using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
