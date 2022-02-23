using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Chad1.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using CluedIn.Connector.DataDefinition.Models;

namespace CluedIn.Crawling.Chad1.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class Chad1Client
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<Chad1Client> log;


        private readonly IRestClient client;

        public Chad1Client(ILogger<Chad1Client> log, Chad1CrawlJobData Chad1CrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (Chad1CrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(Chad1CrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));

            // TODO use info from Chad1CrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", Chad1CrawlJobData.ApiKey, ParameterType.QueryString);
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var request = new RestRequest(url, Method.GET);

            var response = await client.ExecuteAsync(request, request.Method);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var diagnosticMessage = $"Request to {client.BaseUrl}{url} failed, response {response.ErrorMessage} ({response.StatusCode})";
                log.LogError(diagnosticMessage);
                throw new InvalidOperationException($"Communication to jsonplaceholder unavailable. {diagnosticMessage}");
            }

            var data = JsonConvert.DeserializeObject<T>(response.Content);

            return data;
        }

        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation("", "");
        }

        public IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person { GCI = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301").ToString(), Id = "Cust01", FirstName = "Richard 01", LastName = "Naparite", OrganizationId = "Org01" }
            };
        }

        public IEnumerable<Organization> GetOrganizations()
        {
            return new List<Organization>
            {
                new Organization { Id = "Org01", Name = "Chad Org 01", Status = "Active" }
            };
        }
    }
}
