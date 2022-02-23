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
        public Clue MakeClueImpl(IClueFactory factory, Person input, Guid accountId)
        {
            // TODO: Verify EntityType and identifier are correct
            var clue = factory.Create(EntityType.Person, input.Id.ToString(), accountId);

            var personVocabulary = new PersonVocabulary();

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }

            //TODO: Examples of edge creation
            if (input.OrganizationId != null)
            {
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input.OrganizationId, input.OrganizationId);
            }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[personVocabulary.GCI] = input.GCI.PrintIfAvailable();
            data.Properties[personVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[personVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[personVocabulary.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[personVocabulary.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[personVocabulary.OrganizationId] = input.OrganizationId.PrintIfAvailable();

            return clue;
        }
    }
}
