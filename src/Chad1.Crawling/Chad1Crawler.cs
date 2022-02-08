using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Chad1.Core;
using CluedIn.Crawling.Chad1.Infrastructure.Factories;

namespace CluedIn.Crawling.Chad1
{
    public class Chad1Crawler : ICrawlerDataGenerator
    {
        private readonly IChad1ClientFactory clientFactory;
        public Chad1Crawler(IChad1ClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is Chad1CrawlJobData Chad1crawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(Chad1crawlJobData);

            //retrieve data from provider and yield objects

            foreach (var person in client.GetPersons())
                yield return person;

            foreach (var organization in client.GetOrganizations())
                yield return organization;
        }       
    }
}
