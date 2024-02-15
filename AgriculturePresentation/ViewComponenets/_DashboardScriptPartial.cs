using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
