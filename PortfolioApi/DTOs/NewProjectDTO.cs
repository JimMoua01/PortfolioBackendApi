using System.Text.Json.Serialization;

namespace PortfolioApi.DTOs
{
    public class NewProjectDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("link")]
        public string? Link { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
