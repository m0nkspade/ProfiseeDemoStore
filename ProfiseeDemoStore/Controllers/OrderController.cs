using Microsoft.AspNetCore.Mvc;

namespace ProfiseeDemoStore.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
