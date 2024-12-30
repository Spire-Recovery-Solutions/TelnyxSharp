using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationType
    {
        Unknown,

        [JsonPropertyName("start")]
        Start,

        [JsonPropertyName("stop")]
        Stop,

        [JsonPropertyName("info")]
        Info
    }
}
