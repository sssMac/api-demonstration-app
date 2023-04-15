using Newtonsoft.Json;

namespace api_demonstration_app.Models.Json
{
    public class Status
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
