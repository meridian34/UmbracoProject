using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
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
