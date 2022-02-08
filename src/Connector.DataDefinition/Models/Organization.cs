using CluedIn.Core;
using Newtonsoft.Json;

namespace CluedIn.Connector.DataDefinition.Models
{
    public class Organization : IIdentifiable
    {
        [JsonIgnore]
        object IIdentifiable.Id => Id;

        [JsonProperty("Id")]
        public string Id {get; set;}

        [JsonProperty("Name")]
        public string Name { get; set;}

        [JsonProperty("Status")]
        public string Status { get; set;}

        [JsonProperty("Location")]
        public string Location {get; set;}
    }
}
