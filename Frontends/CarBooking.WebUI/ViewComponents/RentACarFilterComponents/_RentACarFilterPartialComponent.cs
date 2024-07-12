using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.RentACarFilterComponents;

public class _RentACarFilterPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke(string v)
    {
        v = "aaaa";
        TempData["value"] = v;
        return View();
    }
}
