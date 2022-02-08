using CluedIn.Crawling.Chad2.Core;

namespace CluedIn.Crawling.Chad2
{
    public class Chad2CrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<Chad2CrawlJobData>
    {
        public Chad2CrawlerJobProcessor(Chad2CrawlerComponent component) : base(component)
        {
        }
    }
}
