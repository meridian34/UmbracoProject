using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace UmbracoProject.Components.Header
{
    public class HeaderViewModel
    {
        public MediaWithCrops Logo { get; set; }
        public IEnumerable<Link> NavigationLinks { get; set; }
        public IEnumerable<Link> LanguageLinks { get; set; }

    }
}
