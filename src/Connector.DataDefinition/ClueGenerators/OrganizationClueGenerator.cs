using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Connector.DataDefinition.Interfaces;
using CluedIn.Connector.DataDefinition.Models;
using CluedIn.Connector.DataDefinition.Vocabularies;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Connector.DataDefinition.ClueGenerator
{
    public partial class ChadClueGenerator : IClueGenerator
    {
        public Clue MakeClueImpl(IClueFactory factory, Organization input, Guid accountId)
        {
            // TODO: Verify EntityType and identifier are correct
            var clue = factory.Create(EntityType.Organization, input.Id.ToString(), accountId);

            var organizationVocabulary = new OrganizationVocabulary();

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.Name != null)
            {
                data.Name = input.Name;
                data.DisplayName = input.Name;
                data.Description = input.Name;
            }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[organizationVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[organizationVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[organizationVocabulary.Status] = input.Status.PrintIfAvailable();
            data.Properties[organizationVocabulary.Location] = input.Location.PrintIfAvailable();

            return clue;
        }
    }
}
