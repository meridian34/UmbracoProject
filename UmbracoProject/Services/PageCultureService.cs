using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace UmbracoProject.Services
{
    public class PageCultureService
    {
        public IEnumerable<Link> GetLanguagesLinks(IPublishedContent page)
        {
            var links = new List<Link>();
            var cultures = page.Cultures.Select(x => x.Key).ToList();

            foreach (var culture in cultures)
            {
                CultureInfo cultureInfo = new CultureInfo(culture, false);

                links.Add(new Link
                {
                    Name = $"{cultureInfo.NativeName[0].ToString().ToUpper()}{cultureInfo.NativeName.Substring(1)}",
                    Url = page.Url(culture)
                });
            }

            return links;
        }
    }
}
