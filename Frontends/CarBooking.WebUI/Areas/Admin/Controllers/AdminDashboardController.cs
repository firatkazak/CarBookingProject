using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
[Route("Admin/AdminDashboard")]
public class AdminDashboardController : Controller
{
    [Route("Index")]
    public IActionResult Index()
    {
        return View();
    }
}