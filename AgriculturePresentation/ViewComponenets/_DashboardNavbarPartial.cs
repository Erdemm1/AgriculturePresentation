using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _DashboardNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
