using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.UILayoutViewComponents;

public class _MainCoverUILayoutPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
