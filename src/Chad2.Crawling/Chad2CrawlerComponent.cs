using CluedIn.Core;
using CluedIn.Crawling.Chad2.Core;

using ComponentHost;

namespace CluedIn.Crawling.Chad2
{
    [Component(Chad2Constants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class Chad2CrawlerComponent : CrawlerComponentBase
    {
        public Chad2CrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

