using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.UILayoutViewComponents;

public class _ScriptUILayoutPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
