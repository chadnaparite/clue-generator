using CluedIn.Crawling.Chad1.Core;

namespace CluedIn.Crawling.Chad1
{
    public class Chad1CrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<Chad1CrawlJobData>
    {
        public Chad1CrawlerJobProcessor(Chad1CrawlerComponent component) : base(component)
        {
        }
    }
}
