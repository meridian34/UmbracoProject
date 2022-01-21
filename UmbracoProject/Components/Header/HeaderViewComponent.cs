using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using UmbracoProject.Services;

namespace UmbracoProject.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        private readonly PageCultureService _pageCultureService;
        public HeaderViewComponent(SettingsService settingsService, PageCultureService pageCultureService)
        {
            _settingsService = settingsService;
            _pageCultureService = pageCultureService;
        }

        public IViewComponentResult Invoke(IPublishedContent page)
        {
            var settings = _settingsService.GetSettings();
            var links = _pageCultureService.GetLanguagesLinks(page);

            var cultureInfo = new CultureInfo(page.GetCultureFromDomains());
            var bff2 = cultureInfo.NativeName[0].ToString().ToUpper() + cultureInfo.NativeName.Substring(1);
            var curentCultureName = links.FirstOrDefault(x => x.Url == page.Url());

            var model = new HeaderViewModel
            {
                Logo = settings.HeaderLogo,
                LanguageLinks = links,
                NavigationLinks = settings.HeaderNavigationLinks,
                CurrentUrl = page.Url(),
                CurrentCultureName = curentCultureName.Name
            };

            return View(model);
        }
    }
}
