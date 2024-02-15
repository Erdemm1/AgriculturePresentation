using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
	public class _HeadViewPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
