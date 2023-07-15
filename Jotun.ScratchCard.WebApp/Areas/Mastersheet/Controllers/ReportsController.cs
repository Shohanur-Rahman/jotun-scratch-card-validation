using Microsoft.AspNetCore.Mvc;

namespace Jotun.ScratchCard.WebApp.Areas.Mastersheet.Controllers
{
    [Area("Mastersheet")]
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DateToDate()
        {
            return View();
        }
        public IActionResult Dealer()
        {
            return View();
        }

		public IActionResult Painter()
		{
			return View();
		}
	}
}
