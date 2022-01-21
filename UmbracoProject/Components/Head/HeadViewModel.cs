using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Components.Head
{
    public class HeadViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Keywords { get; set; }

        public string OpenGraphTitle { get; set; }

        public string OpenGraphType { get; set; }

        public string OpenGraphUrl { get; set; }

        public string OpenGraphImage { get; set; }

        public IEnumerable<OpenGraphMetaItem> MetaList { get; set; }
    }
}
