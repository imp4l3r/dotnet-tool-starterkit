using System.Text.Json.Serialization;

public class RandomApiResponse
{
        [JsonPropertyName("icon_url")]
        public string icon_url { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("value")]
        public string value { get; set; }
}
