using System.Linq;
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
                .DescendantsOrSelf<HomePage>()
                .First()
                .DescendantsOrSelf<SiteSettings>()
                .First();

            return settings;
        }

        public IBaseSeoBlock GetDefautSiteSeo()
        {
            return GetSettings().DescendantOrSelf<IBaseSeoBlock>();
        }

        public IOpenGraphSeoData GetDefautOpenGraphSeo()
        {
            return GetSettings().DescendantOrSelf<IOpenGraphSeoData>();
        }
    }
}
