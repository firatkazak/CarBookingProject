using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailTabPanePartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}