using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageType
    {
        Unknown,

        [JsonPropertyName("long-code")]
        LongCode, // Corresponds to "long-code"

        [JsonPropertyName("toll-free")]
        TollFree, // Corresponds to "toll-free"

        [JsonPropertyName("short-code")]
        ShortCode, // Corresponds to "short-code"

        [JsonPropertyName("longcode")]
        Longcode, // Corresponds to "longcode"

        [JsonPropertyName("tollfree")]
        Tollfree, // Corresponds to "tollfree"

        [JsonPropertyName("shortcode")]
        Shortcode,

        [JsonPropertyName("SMS")]
        Sms, // Corresponds to "tollfree"

        [JsonPropertyName("MMS")]
        Mms
    }
}
