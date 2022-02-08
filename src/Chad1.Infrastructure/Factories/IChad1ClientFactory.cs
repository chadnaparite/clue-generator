using CluedIn.Crawling.Chad1.Core;

namespace CluedIn.Crawling.Chad1.Infrastructure.Factories
{
    public interface IChad1ClientFactory
    {
        Chad1Client CreateNew(Chad1CrawlJobData Chad1CrawlJobData);
    }
}
