using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarDetailMainCoverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
