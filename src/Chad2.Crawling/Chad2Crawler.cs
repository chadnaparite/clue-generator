using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Chad2.Core;
using CluedIn.Crawling.Chad2.Infrastructure.Factories;

namespace CluedIn.Crawling.Chad2
{
    public class Chad2Crawler : ICrawlerDataGenerator
    {
        private readonly IChad2ClientFactory clientFactory;
        public Chad2Crawler(IChad2ClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is Chad2CrawlJobData Chad2crawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(Chad2crawlJobData);

            //retrieve data from provider and yield objects

            foreach (var person in client.GetPersons())
                yield return person;

            foreach (var organization in client.GetOrganizations())
                yield return organization;
        }       
    }
}
