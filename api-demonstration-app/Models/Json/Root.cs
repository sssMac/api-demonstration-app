using Newtonsoft.Json;

namespace api_demonstration_app.Models.Json
{
    public class Root
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
