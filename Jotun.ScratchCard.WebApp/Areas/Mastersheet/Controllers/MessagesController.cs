using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Areas.Mastersheet.Controllers
{
    [Area("Mastersheet")]
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pending()
        {
            return View();
        }
    }
}
