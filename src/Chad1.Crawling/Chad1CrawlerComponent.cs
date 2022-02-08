using CluedIn.Core;
using CluedIn.Crawling.Chad1.Core;

using ComponentHost;

namespace CluedIn.Crawling.Chad1
{
    [Component(Chad1Constants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class Chad1CrawlerComponent : CrawlerComponentBase
    {
        public Chad1CrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

