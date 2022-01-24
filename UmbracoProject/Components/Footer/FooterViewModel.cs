using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Components.Footer
{
    public class FooterViewModel
    {
        public MediaWithCrops FooterLogo { get; set; }

        public string FooterGeneralInfo { get; set; }

        public string SocialTitle { get; set; }

        public IEnumerable<SvgMediaItem> SocialSourceList { get; set; }

        public IEnumerable<FooterNavigationComponent> FooterNavigationBlockList { get; set; }
    }
}
