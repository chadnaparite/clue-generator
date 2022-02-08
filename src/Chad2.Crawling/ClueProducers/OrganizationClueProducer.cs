using System;
using CluedIn.Connector.DataDefinition.Interfaces;
using CluedIn.Connector.DataDefinition.Models;
using CluedIn.Connector.DataDefinition.Vocabularies;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Chad2.ClueProducers
{
    public class OrganizationClueProducer : BaseClueProducer<Organization>
    {
        private readonly IClueFactory factory;
        private readonly IClueGenerator clueGenerator;

        public OrganizationClueProducer(IClueFactory factory, IClueGenerator clueGenerator)
        {
            this.factory = factory;
            this.clueGenerator = clueGenerator;
        }

        protected override Clue MakeClueImpl(Organization input, Guid accountId)
        {
            return clueGenerator.MakeClueImpl(factory, input,accountId);
        }
    }
}
