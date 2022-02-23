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
            context.Log.LogDebug($"[PreProcessor] PersonPreProcessor.Accepts: {codes}");

            return codes.Any(c => c.Origin.Code == "Chad2");
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            context.Log.LogDebug($"[PreProcessor] PersonPreProcessor.Process: {metadata}");

            if (metadata.EntityType == EntityType.Person)
                this.ProcessPerson(context, metadata, data);
        }

        private void ProcessPerson(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            context.Log.LogDebug($"[PreProcessor] PersonPreProcessor.ProcessPerson: {metadata}");
            context.Log.LogDebug($"[PreProcessor] PersonPreProcessor.ProcessPerson: {metadata.Properties}");

            foreach (var prop in metadata.Properties)
                context.Log.LogDebug($"[PreProcessor] PersonPreProcessor: {prop}");

            if (!metadata.Properties.TryGetValue("chad.person.GCI", out var gci) || string.IsNullOrEmpty(gci))
            {
                metadata.Properties["chad.person.GCI"] = Guid.NewGuid().ToString();
            }
        }
    }
}
