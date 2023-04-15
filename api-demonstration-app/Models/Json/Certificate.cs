using System.Text.Json.Serialization;

namespace api_demonstration_app.Models.Json
{
    public class Certificate
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
