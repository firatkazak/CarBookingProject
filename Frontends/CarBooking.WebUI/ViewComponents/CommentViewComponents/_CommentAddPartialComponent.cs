using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.ViewComponents.CommentViewComponents;

public class _CommentAddPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
