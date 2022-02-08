using CluedIn.Crawling.Chad2.Core;

namespace CluedIn.Crawling.Chad2.Infrastructure.Factories
{
    public interface IChad2ClientFactory
    {
        Chad2Client CreateNew(Chad2CrawlJobData Chad2CrawlJobData);
    }
}
