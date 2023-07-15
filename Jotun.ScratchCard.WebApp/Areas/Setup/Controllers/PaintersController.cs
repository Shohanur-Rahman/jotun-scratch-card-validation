using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class PaintersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
