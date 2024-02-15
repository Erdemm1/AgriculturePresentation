using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _AnnoucementPartial : ViewComponent
    {
        private readonly IAnnoucementService _annoucementService;

        public _AnnoucementPartial(IAnnoucementService annoucementService)
        {
            _annoucementService = annoucementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _annoucementService.GetListAll();
            return View(values);
        }
    }
}
