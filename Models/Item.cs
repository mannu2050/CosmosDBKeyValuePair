namespace todo.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    public class Item
    {
        public Item()
        {
            TimeToLive = 100; //100 seconds
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeToLive { get; set; }
    }
}