using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using UmbracoProject.Components.Bundling;

namespace UmbracoProject.Composers
{
    public class ComponentComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.AddComponent<BundlingComponent>();
        }
    }
}
