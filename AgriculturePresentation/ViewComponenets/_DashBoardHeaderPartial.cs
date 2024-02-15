using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _DashBoardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
