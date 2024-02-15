using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
