using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace UmbracoProject.Services
{
    public class SectionsService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public SectionsService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public SectionsFolder GetSections()
        {
            var sections = _umbracoHelper
                .ContentAtRoot()
                .DescendantsOrSelf<HomePage>()
                .First()
                .DescendantsOrSelf<SectionsFolder>()
                .First();


            return sections;
        }
    }
}
