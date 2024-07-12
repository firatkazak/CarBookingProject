using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Controllers;
public class SignalRCarController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
