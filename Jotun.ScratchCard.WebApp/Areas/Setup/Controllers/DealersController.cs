using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class DealersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
