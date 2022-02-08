using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Chad1;
using CluedIn.Crawling.Chad1.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Chad1.Unit.Test
{
    public class Chad1CrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public Chad1CrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IChad1ClientFactory>();

            _sut = new Chad1Crawler(nameClientFactory.Object);
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
