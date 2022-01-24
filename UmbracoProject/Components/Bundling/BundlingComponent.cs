using System;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.WebAssets;

namespace UmbracoProject.Components.Bundling
{
    public class BundlingComponent : IComponent
    {
        private readonly IRuntimeMinifier _runtimeMinifier;
        public BundlingComponent(IRuntimeMinifier runtimeMinifier)
        {
            _runtimeMinifier = runtimeMinifier;
        }
        
        public void Initialize()
        {
            _runtimeMinifier.CreateCssBundle("inline-css-bundle",
                BundlingOptions.NotOptimizedAndComposite,
                new[] { "~/css/customFooter.css", "~/css/customHeader.css", "~/css/customHome.css" });
        }

        public void Terminate()
        {
        }
    }
}
