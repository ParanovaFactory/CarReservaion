using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.PricingViewComponents
{
    public class _PricingMainCoverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
