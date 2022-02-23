using CluedIn.Core;
using Newtonsoft.Json;

namespace CluedIn.Connector.DataDefinition.Models
{
    public class Person : IIdentifiable
    {
        [JsonIgnore]
        object IIdentifiable.Id => Id;

        [JsonProperty("Id")]
        public string Id {get; set;}

        [JsonProperty("GCI")]
        public string GCI { get; set;}

        [JsonProperty("FirstName")]
        public string FirstName {get; set;}

        [JsonProperty("MiddleName")]
        public string MiddleName {get; set;}

        [JsonProperty("LastName")]
        public string LastName {get; set;}
        public string OrganizationId { get; set;}

        public string FullName => string.Join(" ", FirstName, MiddleName, LastName);
    }
}
