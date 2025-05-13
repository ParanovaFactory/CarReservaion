using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
