using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceMainCoverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
