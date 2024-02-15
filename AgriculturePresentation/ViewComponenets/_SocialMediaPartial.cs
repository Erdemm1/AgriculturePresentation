using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponenets
{
    public class _SocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
