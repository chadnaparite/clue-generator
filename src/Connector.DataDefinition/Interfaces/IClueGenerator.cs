using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Connector.DataDefinition.Models;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;

namespace CluedIn.Connector.DataDefinition.Interfaces
{
    public interface IClueGenerator
    {
        Clue MakeClueImpl(IClueFactory factory, Person input, Guid accountId);
        Clue MakeClueImpl(IClueFactory factory, Organization input, Guid accountId);
    }
}
