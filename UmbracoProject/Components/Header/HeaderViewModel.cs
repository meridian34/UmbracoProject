using System.Collections.Generic;
using Umbraco.Cms.Core.Models;

namespace UmbracoProject.Components.Header
{
    public class HeaderViewModel
    {
        public MediaWithCrops Logo { get; set; }
        public IEnumerable<Link> NavigationLinks { get; set; }
        public IEnumerable<Link> LanguageLinks { get; set; }
        public string CurrentUrl { get; set; }
        public string CurrentCultureName { get; set; }

    }
}
