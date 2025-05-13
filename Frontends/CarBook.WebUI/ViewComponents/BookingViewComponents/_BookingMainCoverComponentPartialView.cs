using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BookingViewComponents
{
    public class _BookingMainCoverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
