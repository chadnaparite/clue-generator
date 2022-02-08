using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Chad2;
using CluedIn.Crawling.Chad2.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Chad2.Unit.Test
{
    public class Chad2CrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public Chad2CrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IChad2ClientFactory>();

            _sut = new Chad2Crawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
