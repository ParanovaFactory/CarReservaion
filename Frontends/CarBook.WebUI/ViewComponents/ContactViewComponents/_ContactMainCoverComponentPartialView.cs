using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ContactViewComponent
{
    public class _ContactMainCoverComponentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
