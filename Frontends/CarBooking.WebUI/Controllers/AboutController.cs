using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Controllers;
public class AboutController : Controller
{
    public IActionResult Index()
    {
        ViewBag.v1 = "Hakkımızda";
        ViewBag.v2 = "Misyonumuz";
        return View();
    }
}
