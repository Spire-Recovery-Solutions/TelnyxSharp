using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class ValidationErrorDetail
    {
        [JsonPropertyName("loc")]
        public List<string> Location { get; set; } = new();

        [JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}