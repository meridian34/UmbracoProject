using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoProject.Services;

namespace UmbracoProject.Components.Head
{
    public class HeadViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        public HeadViewComponent(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IViewComponentResult Invoke(IPublishedContent page)
        {
            var head = CreateHeadData(page);

            return View(head);
        }

        private HeadViewModel CreateHeadData(IPublishedContent page)
        {
            var seoData = (IBaseSeoBlock)page;
            var defaultSeo = _settingsService.GetDefautSiteSeo();
            var head = new HeadViewModel();

            head.Title = string.IsNullOrWhiteSpace(seoData.SeoTitle) ? defaultSeo.SeoTitle : seoData.SeoTitle;
            head.Description = string.IsNullOrWhiteSpace(seoData.SeoDescription) ? defaultSeo.SeoDescription : seoData.SeoDescription;
            head.Keywords = string.IsNullOrWhiteSpace(seoData.SeoKeywords)? defaultSeo.SeoKeywords : seoData.SeoKeywords;
            head.OpenGraphTitle = string.IsNullOrWhiteSpace(seoData.OpenGraphTitle) ? defaultSeo.OpenGraphTitle : seoData.OpenGraphTitle;
            head.OpenGraphType = string.IsNullOrWhiteSpace(seoData.OpenGraphType) ? defaultSeo.OpenGraphType : seoData.OpenGraphType;
            head.OpenGraphUrl = string.IsNullOrWhiteSpace(seoData.OpenGraphUrl) ? defaultSeo.OpenGraphUrl : seoData.OpenGraphUrl;
            head.OpenGraphImage = string.IsNullOrWhiteSpace(seoData.OpenGraphImage) ? defaultSeo.OpenGraphImage: seoData.OpenGraphImage;

            return head;
        }
    }
}
