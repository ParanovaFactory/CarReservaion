using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarMainCoverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
