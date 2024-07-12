using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailParagraphPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
