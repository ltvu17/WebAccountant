using Newtonsoft.Json;

namespace WebAccountant.Models
{
    public class DataChange
    {
        [JsonProperty("key")]
        public object Key { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
