using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;

namespace UmbracoProject.Services
{
    public class SettingsService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public SettingsService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public SiteSettings GetSettings()
        {
            var settings = _umbracoHelper
                .ContentAtRoot()
                .Where(x => x.GetType() == typeof(SiteSettings)).OfType<SiteSettings>()
                .FirstOrDefault();
                

            return settings;
        }
    }
}
