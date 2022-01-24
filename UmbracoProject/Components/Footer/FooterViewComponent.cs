using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoProject.Services;

namespace UmbracoProject.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        public FooterViewComponent(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IViewComponentResult Invoke()
        {
            var settings = _settingsService.GetSettings();
            var navigationBlockList = settings.FooterNavigationList.Select(x => (FooterNavigationComponent)x.Content);
            var sourceList = settings.SocialSourceList.Select(x => (SvgMediaItem)x.Content);

            var model = new FooterViewModel
            {
                FooterLogo = settings.FooterLogo,
                FooterGeneralInfo = settings.FooterGeneralInfo,
                SocialTitle = settings.SocialTitle,
                FooterNavigationBlockList = navigationBlockList,
                SocialSourceList = sourceList
            };

            return View(model);
        }
    }
}
