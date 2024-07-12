using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.AboutViewComponents;

public class _BecomeADriverPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
