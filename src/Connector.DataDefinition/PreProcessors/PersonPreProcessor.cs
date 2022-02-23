using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;
using CluedIn.Processing.Models.Utilities;
using CluedIn.Processing.Processors.PreProcessing;
using Microsoft.Extensions.Logging;

namespace CluedIn.Connector.DataDefinition.PreProcessors
{
    public class PersonPreProcessor : IPreProcessor
    {
        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return codes.Any(c => c.Origin.Code == "Chad2");
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (metadata.EntityType == EntityType.Person)
                this.ProcessPerson(context, metadata, data);
        }

        private void ProcessPerson(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            context.Log.LogDebug($"[PreProcessor] PersonPreProcessor.ProcessPerson: {metadata.DisplayName}");

            if (!metadata.Properties.TryGetValue("chad.person.GCI", out var gci) || string.IsNullOrEmpty(gci))
            {
                metadata.Properties["chad.person.GCI"] = Guid.NewGuid().ToString();
            }
        }
    }
}
