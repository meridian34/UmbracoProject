using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using UmbracoProject.Services;

namespace UmbracoProject.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        public HeaderViewComponent(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IViewComponentResult Invoke(IPublishedContent content)
        {
            var settings = _settingsService.GetSettings();

            return View(new HeaderViewModel
            {
                Logo = settings.HeaderLogo,
                LanguageLinks = settings.HeaderLanguageLinks,
                NavigationLinks = settings.HeaderNavigationLinks
            });
        }
    }
}
